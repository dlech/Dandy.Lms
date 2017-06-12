using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dandy.Core;

namespace Dandy.Lms.Bytecodes.EV3
{
    partial class BytecodeFactory
    {
        /// <summary>
        /// Contains all of the system command factory methods.
        /// </summary>
        public static class SystemCommand
        {
            /// <summary>
            /// Create a new EV3 system command to begin transferring a file to an EV3.
            /// </summary>
            /// <param name="size">The size of the file to be downloded.</param>
            /// <param name="path">The path where the file will be saved on the EV3.</param>
            /// <returns>A new commnd that returns an handle to the remote file for writing.</returns>
            /// <remarks>
            /// <list type="bullet">
            /// <item>The path is relative to <c>lms2012/sys</c>.</item>
            /// <item>Destination folders are automatically created from filename path.</item>
            /// <item>First folder name must be: "apps", "prjs" or "tools".</item>
            /// <item>Second folder name in filename path must be equal to byte code executable name.</item>
            /// </list>
            /// If the command returns sucessfully, the handle should be passed to a <see cref="ContinueDownload"/>
            /// command along with the actual file data.
            /// </remarks>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="path"/> is <c>null</c>;
            /// </exception>
            public static ICommand<byte> BeginDownload(int size, string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writeCommandParameters = (writer) =>
                {
                    writer.Write(size);
                    writer.Write(path, 0);
                };

                Func<BinaryReader, byte> parseReplyParameters = (reader) =>
                {
                    var handle = reader.ReadByte();
                    return handle;
                };

                return new SystemCommand<byte>(SystemCommandValue.BeginDownload,
                    writeCommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a command to continue a download started by <see cref="BeginDownload"/>.
            /// </summary>
            /// <param name="handle">A file handle returned from a <see cref="BeginDownload"/> command.</param>
            /// <param name="payload">
            /// The next portion of the file to send. This must not exceede the maximum packet size.
            /// </param>
            /// <returns>A new command that returns a new file handle.</returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="payload"/>is <c>null</c>.
            /// </exception>
            public static ICommand<byte> ContinueDownload(byte handle, byte[] payload)
            {
                if (payload == null)
                {
                    throw new ArgumentNullException(nameof(payload));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(payload);
                };

                Func<BinaryReader, byte> parseReplyParameters = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    return newHandle;
                };

                return new SystemCommand<byte>(SystemCommandValue.ContinueDownload,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to begin retriving a file from an EV3.
            /// </summary>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <param name="path">The path of the file on the EV3.</param>
            /// <returns>
            /// A new command that returns the total size of the file, a file handle, and the first payload.
            /// </returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="path"/> is <c>null</c>.
            /// </exception>
            public static ICommand<ValueTuple<int, byte, byte[]>> BeginUpload(ushort payloadSize, string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(payloadSize);
                    writer.Write(path, 0);
                };

                Func<BinaryReader, ValueTuple<int, byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var length = reader.ReadInt32();
                    var handle = reader.ReadByte();
                    var payload = reader.ReadBytes(payloadSize);
                    return (length, handle, payload);
                };

                return new SystemCommand<ValueTuple<int, byte, byte[]>>(SystemCommandValue.BeginUpload,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to continue retriving a file from an EV3.
            /// </summary>
            /// <param name="handle">
            /// The handle returned by a command created with <see cref="BeginUpload"/>.
            /// </param>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <returns>A new command that returns a new file handle and the payload.</returns>
            public static ICommand<ValueTuple<byte, byte[]>> ContinueUpload(byte handle, ushort payloadSize)
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(payloadSize);
                };

                Func<BinaryReader, ValueTuple<byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    var payload = reader.ReadBytes(payloadSize);
                    return (newHandle, payload);
                };

                return new SystemCommand<ValueTuple<byte, byte[]>>(SystemCommandValue.ContinueUpload,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to begin retriving a data log file from an EV3.
            /// </summary>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <param name="path">The path of the file on the EV3.</param>
            /// <returns>
            /// A new command that returns the total size of the file, a file handle, and the first payload.
            /// </returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="path"/> is <c>null</c>.
            /// </exception>
            public static ICommand<ValueTuple<int, byte, byte[]>> BeginGetFile(ushort payloadSize, string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(payloadSize);
                    writer.Write(path, 0);
                };

                Func<BinaryReader, ValueTuple<int, byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var length = reader.ReadInt32();
                    var handle = reader.ReadByte();
                    var payload = reader.ReadBytes(payloadSize);
                    return (length, handle, payload);
                };

                return new SystemCommand<ValueTuple<int, byte, byte[]>>(SystemCommandValue.BeginGetFile,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to continue retriving a data log file from an EV3.
            /// </summary>
            /// <param name="handle">
            /// The handle returned by a command created with <see cref="BeginUpload"/>.
            /// </param>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <returns>A new command that returns a new file handle and the payload.</returns>
            public static ICommand<ValueTuple<int, byte, byte[]>> ContinueGetFile(byte handle, ushort payloadSize)
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(payloadSize);
                };

                Func<BinaryReader, ValueTuple<int, byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var length = reader.ReadInt32();
                    var newHandle = reader.ReadByte();
                    var payload = reader.ReadBytes(payloadSize);
                    return (length, newHandle, payload);
                };

                return new SystemCommand<ValueTuple<int, byte, byte[]>>(SystemCommandValue.ContinueGetFile,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to begin listing files in a directory on an EV3.
            /// </summary>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <param name="path">The path of the directory on the EV3.</param>
            /// <returns>
            /// A new command that returns the total size of the list, a file handle, and the first payload.
            /// </returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="path"/> is <c>null</c>.
            /// </exception>
            /// <remarks>
            /// The payload format is a newline delimited list. Files are listed as:
            /// <code>
            /// [32-char MD5 sum (ASCII encoded hex)] + [space] + [8-char file size (ASCII encoded hex)] + [space] + [filename]
            /// </code>
            /// Directories are listed as:
            /// <code>
            /// [folder name] + [slash character (/)]
            /// </code>
            /// </remarks>
            public static ICommand<ValueTuple<int, byte, byte[]>> BeginListFiles(ushort payloadSize, string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(payloadSize);
                    writer.Write(path, 0);
                };

                Func<BinaryReader, ValueTuple<int, byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var length = reader.ReadInt32();
                    var handle = reader.ReadByte();
                    var payload = reader.ReadBytes(length);
                    return (length, handle, payload);
                };

                return new SystemCommand<ValueTuple<int, byte, byte[]>>(SystemCommandValue.BeginListFiles,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to continue listing files in a directory on an EV3.
            /// </summary>
            /// <param name="handle">
            /// The file handle returned by a command created with <see cref="BeginListFiles"/>.
            /// </param>
            /// <param name="payloadSize">
            /// The number of bytes to transfer in this command. This must not exceede the packet size.
            /// </param>
            /// <returns>
            /// A new command that returns a new file handle, and a payload.
            /// </returns>
            public static ICommand<ValueTuple<byte, byte[]>> ContinueListFiles(byte handle, ushort payloadSize)
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(payloadSize);
                };

                Func<BinaryReader, ValueTuple<byte, byte[]>> parseReplyParameters = (reader) =>
                {
                    var newHandle = reader.ReadByte();
                    var payload = reader.ReadBytes(payloadSize);
                    return (newHandle, payload);
                };

                return new SystemCommand<ValueTuple<byte, byte[]>>(SystemCommandValue.ContinueListFiles,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to close a file handle.
            /// </summary>
            /// <param name="handle">The file handle to close.</param>
            /// <param name="hash">The hash of the file.</param>
            /// <returns>A new command.</returns>
            public static ICommand<Unit> CloseFileHandle(byte handle, ulong hash)
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(handle);
                    writer.Write(hash);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.CloseFileHandle,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to create a directory on an EV3.
            /// </summary>
            /// <param name="path">The name of the directory.</param>
            /// <returns>The new command.</returns>
            /// <exception cref="ArgumentNullException">
            /// Throwns if <paramref name="path"/> is <c>null</c>.
            /// </exception>
            public static ICommand<Unit> CreateDirectory(string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(path, 0);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.CreateDirectory,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to delete a file on an EV3.
            /// </summary>
            /// <param name="path">The name of the file.</param>
            /// <returns>A new command.</returns>
            /// <exception cref="ArgumentNullException">
            /// Throwns if <paramref name="path"/> is <c>null</c>.
            /// </exception>
            public static ICommand<Unit> DeleteFile(string path)
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(path, 0);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.DeleteFile,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command to list open file handles on an EV3.
            /// </summary>
            /// <returns>A new command that returns bit flags indicating if a file handle is open or not.</returns>
            public static ICommand<ushort> ListOpenHandles()
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                };

                Func<BinaryReader, ushort> parseReplyParameters = (reader) =>
                {
                    // FIXME: how do we know how many bytes to read?
                    var flags = reader.ReadUInt16();
                    return flags;
                };

                return new SystemCommand<ushort>(SystemCommandValue.ListOpenHandles,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new command that writes a payload to a mailbox.
            /// </summary>
            /// <param name="name">The mailbox name.</param>
            /// <param name="payload">The data to send.</param>
            /// <returns>A new command.</returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="name"/> or <paramref name="payload"/> is <c>null</c>.
            /// </exception>
            /// <remarks>
            /// The returned command will never receive a reply, so don't expect one.
            /// </remarks>
            public static ICommand<Unit> WriteMailbox(string name, byte[] payload)
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                if (payload == null)
                {
                    throw new ArgumentNullException(nameof(payload));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(name, sizeof(byte), includeNullCharInLength: false);
                    writer.Write((ushort)payload.Length);
                    writer.Write(payload);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    throw new InvalidOperationException();
                };

                return new SystemCommand<Unit>(SystemCommandValue.WriteMailbox,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command that sets the Bluetooth pin code and retrives the EV3 Bluetooth MAC address.
            /// </summary>
            /// <param name="hostMACAddress">The host MAC address.</param>
            /// <param name="pinCode">The pin code.</param>
            /// <returns>A new command that returns the EV3 MAC address and the pin code.</returns>
            /// <exception cref="ArgumentNullException">
            /// Thrown if <paramref name="hostMACAddress"/> or <paramref name="pinCode"/> is <c>null</c>.
            /// </exception>
            public static ICommand<ValueTuple<string, string>> SendBluetoothPin(string hostMACAddress, string pinCode)
            {
                if (hostMACAddress == null)
                {
                    throw new ArgumentNullException(nameof(hostMACAddress));
                }

                if (pinCode == null)
                {
                    throw new ArgumentNullException(nameof(pinCode));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(hostMACAddress, sizeof(byte));
                    writer.Write(pinCode, sizeof(byte));
                };

                Func<BinaryReader, ValueTuple<string, string>> parseReplyParameters = (reader) =>
                {
                    var clientMacAddressLength = reader.ReadByte();
                    var clientMACAddress = reader.ReadString(clientMacAddressLength);
                    var pinCodeLength = reader.ReadByte();
                    var clientPinCode = reader.ReadString(pinCodeLength);
                    return (clientMACAddress, clientPinCode);
                };

                return new SystemCommand<ValueTuple<string, string>>(SystemCommandValue.SendBluetoothPin,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new EV3 system command that instructs the EV3 to reboot into the firmware update mode.
            /// </summary>
            /// <returns>A new command.</returns>
            public static ICommand<Unit> EnterFimrwareUpdateMode()
            {
                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.EnterFimrwareUpdateMode,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new command that sets the Bluetooth bundle ID (for iOS).
            /// </summary>
            /// <param name="id">The ID.</param>
            /// <returns>A new command.</returns>
            public static ICommand<Unit> SetBundleID(string id)
            {
                if (id == null)
                {
                    throw new ArgumentNullException(nameof(id));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(id, 0);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.SetBundleID,
                    writecommandParameters, parseReplyParameters);
            }

            /// <summary>
            /// Creates a new command that sets the Bluetooth bundle seed ID (for iOS).
            /// </summary>
            /// <param name="id">The ID.</param>
            /// <returns>A new command.</returns>
            public static ICommand<Unit> SetBundleSeedID(string id)
            {
                if (id == null)
                {
                    throw new ArgumentNullException(nameof(id));
                }

                Action<BinaryWriter> writecommandParameters = (writer) =>
                {
                    writer.Write(id, 0);
                };

                Func<BinaryReader, Unit> parseReplyParameters = (reader) =>
                {
                    return Unit.Value;
                };

                return new SystemCommand<Unit>(SystemCommandValue.SetBundleSeedID,
                    writecommandParameters, parseReplyParameters);
            }
        }
    }
}
