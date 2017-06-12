using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dandy.Lms.Bytecodes.NXT
{
    partial class BytecodeFactory
    {
        /// <summary>
        /// Contains all of the NXT system command factory methods.
        /// </summary>
        public static class SystemCommand
        {
            static void AssertFileName(string fileName)
            {
                if (fileName == null)
                {
                    throw new ArgumentNullException(nameof(fileName));
                }

                var parts = fileName.Split('.');
                if (parts.Length != 2)
                {
                    throw new ArgumentException("Missing file extension", nameof(fileName));
                }
                if (parts[0].Length == 0)
                {
                    throw new ArgumentException("File name is too short", nameof(fileName));
                }
                if (parts[0].Length > 15)
                {
                    throw new ArgumentException("File name is too long", nameof(fileName));
                }
                if (parts[1].Length != 3)
                {
                    throw new ArgumentException("Extension must be 3 characters", nameof(fileName));
                }
            }

            /// <summary>
            /// Creates a new NXT system command that opens a file handle for reading.
            /// </summary>
            /// <param name="fileName">The name of the file.</param>
            /// <returns>A new command that returns a file handle and the size of the file.</returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="fileName"/> is <c>null</c>.
            /// </exception>
            /// <exception cref="ArgumentException">
            /// Thrown if <paramref name="fileName"/> does not have a 3 character file extension or
            /// base name exceeds 15 characters.
            /// </exception>
            /// <remarks>
            /// When this command returns successfully, the file handle must be closed with
            /// a <see cref="Close"/> command when it is no longer needed.
            /// </remarks>
            public static ICommand<(byte, int)> OpenRead(string fileName)
            {
                AssertFileName(fileName);

                Action<BinaryWriter> writeParameters = (writer) =>
                {
                    var bytes = new byte[20];
                    Encoding.ASCII.GetBytes(fileName, 0, fileName.Length, bytes, 0);
                    writer.Write(bytes);
                };

                Func<BinaryReader, (byte, int)> parseReply = (reader) =>
                {
                    var handle = reader.ReadByte();
                    var size = reader.ReadInt32();
                    return (handle, size);
                };

                return new Command<(byte, int)>(CommandTypeFlags.System,
                    CommandValue.OpenRead, writeParameters, parseReply);
            }

            /// <summary>
            /// Creates a new NXT system command that opens a file handle for writing.
            /// </summary>
            /// <param name="fileName">The name of the file.</param>
            /// <param name="size">The size of the file.</param>
            /// <returns>A new command that returns a file handle.</returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="fileName"/> is <c>null</c>.
            /// </exception>
            /// <exception cref="ArgumentException">
            /// Thrown if <paramref name="fileName"/> does not have a 3 character file extension or
            /// base name exceeds 15 characters.
            /// </exception>
            /// <remarks>
            /// When this command returns successfully, the file handle must be closed with
            /// a <see cref="Close"/> command when it is no longer needed.
            /// </remarks>
            public static ICommand<byte> OpenWrite(string fileName, int size)
            {
                AssertFileName(fileName);

                if (size < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(size));
                }

                Action<BinaryWriter> writeParameters = (writer) =>
                {
                    var bytes = new byte[20];
                    Encoding.ASCII.GetBytes(fileName, 0, fileName.Length, bytes, 0);
                    writer.Write(bytes);
                    writer.Write(size);
                };

                Func<BinaryReader, byte> parseReply = (reader) =>
                {
                    var handle = reader.ReadByte();
                    return handle;
                };

                return new Command<byte>(CommandTypeFlags.System,
                    CommandValue.OpenWrite, writeParameters, parseReply);
            }

            /// <summary>
            /// Creates a new NXT system command that reads data from a file.
            /// </summary>
            /// <param name="handle">A file handled returned byte <see cref="OpenRead"/>.</param>
            /// <param name="size">The number of bytes to read from the file.</param>
            /// <returns>A new command that returns a file handle and the data read.</returns>
            public static ICommand<(byte, byte[])> Read(byte handle, int size)
            {
                if (size < ushort.MinValue || size > ushort.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(size));
                }

                Action<BinaryWriter> writeParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write((ushort)size);
                };

                Func<BinaryReader, (byte, byte[])> parseReply = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    var readSize = reader.ReadUInt16();
                    var readData = reader.ReadBytes(readSize);
                    return (newHandle, readData);
                };

                return new Command<(byte, byte[])>(CommandTypeFlags.System,
                    CommandValue.Read, writeParameters, parseReply);
            }

            /// <summary>
            /// Creates a new NXT system command that writes data from a file.
            /// </summary>
            /// <param name="handle">A file handled returned byte <see cref="OpenWrite"/>.</param>
            /// <param name="data">The data to write to the file.</param>
            /// <returns>A new command that returns a file handle and the number of bytes actually writtern.</returns>
            public static ICommand<(byte, int)> Write(byte handle, byte[] data)
            {
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data));
                }

                Action<BinaryWriter> writeParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(data);
                };

                Func<BinaryReader, (byte, int)> parseReply = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    var writeSize = reader.ReadUInt16();
                    return (newHandle, writeSize);
                };

                return new Command<(byte, int)>(CommandTypeFlags.System,
                    CommandValue.Write, writeParameters, parseReply);
            }

            /// <summary>
            /// Creates a new NXT system command that closes an open file handle.
            /// </summary>
            /// <param name="handle">A file handled returned byte <see cref="OpenWrite"/>.</param>
            /// <returns>A new command that returns a file handle.</returns>
            public static ICommand<byte> Close(byte handle)
            {
                Action<BinaryWriter> writeParameters = (writer) =>
                {
                    writer.Write(handle);
                };

                Func<BinaryReader, byte> parseReply = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    return newHandle;
                };

                return new Command<byte>(CommandTypeFlags.System,
                    CommandValue.Close, writeParameters, parseReply);
            }

            /// <summary>
            /// Creates a new NXT system command that gets information about the NXT.
            /// </summary>
            /// <returns>
            /// A new command that returns the NXT name, the Bluetooth MAC address, the Bluetooth
            /// signal strength, and the free flash memory size in bytes.
            /// </returns>
            public static ICommand<(string, ulong, int, int)> GetDeviceInfo()
            {
                Action<BinaryWriter> writeParameters = (writer) =>
                {
                };

                Func<BinaryReader, (string, ulong, int, int)> parseReply = (reader) =>
                {
                    var nameBytes = reader.ReadBytes(15);
                    var name = Encoding.ASCII.GetString(nameBytes).TrimEnd('\0');
                    ulong macAddress = 0;
                    macAddress |= (ulong)reader.ReadByte() << 40;
                    macAddress |= (ulong)reader.ReadByte() << 32;
                    macAddress |= (ulong)reader.ReadByte() << 24;
                    macAddress |= (ulong)reader.ReadByte() << 16;
                    macAddress |= (ulong)reader.ReadByte() << 8;
                    macAddress |= (ulong)reader.ReadByte() << 0;
                    var rssi = reader.ReadInt32();
                    var freeFlash = reader.ReadInt32();
                    return (name, macAddress, rssi, freeFlash);
                };

                return new Command<(string, ulong, int, int)>(CommandTypeFlags.System,
                    CommandValue.GetDeviceInfo, writeParameters, parseReply);
            }
        }
    }
}
