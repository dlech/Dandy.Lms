using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Dandy.Lms.Bytecodes.EV3;

namespace Dandy.Lms.Bytecodes
{
    /// <summary>
    /// Internal extension methods
    /// </summary>
    static class BytecodeExtensions
    {
        internal static void Write(this BinaryWriter writer, string value, int sizeOfLengthPrefix, bool includeNullCharInLength = true, bool includeNullTerminator = true)
        {
            var bytes = Encoding.ASCII.GetBytes(value);
            var length = bytes.Length;
            if (includeNullCharInLength && includeNullTerminator)
            {
                length++;
            }
            switch (sizeOfLengthPrefix)
            {
                case 0:
                    break;
                case 1:
                    writer.Write((byte)length);
                    break;
                case 2:
                    writer.Write((ushort)length);
                    break;
                case 4:
                    writer.Write(length);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(sizeOfLengthPrefix));
            }
            writer.Write(bytes);
            if (includeNullTerminator)
            {
                writer.Write((byte)0);
            }
        }

        internal static string ReadString(this BinaryReader reader, int length)
        {
            var bytes = reader.ReadBytes(length);
            var str = Encoding.ASCII.GetString(bytes);
            return str.TrimEnd('\0');
        }

        internal static void Write(this BinaryWriter writer, IByteCode bytecode)
        {
            bytecode.Write(writer);
        }
       

        internal static void WriteDeferred(this BinaryWriter writer, ref Action<int> write)
        {
            // create a delegate that seeks back to the current position before writing
            var pos = writer.BaseStream.Position;
            var originalWrite = write;
            write = (v) =>
            {
                var currentPos = writer.BaseStream.Position;
                writer.BaseStream.Position = pos;
                originalWrite(v);
                writer.BaseStream.Position = currentPos;
            };
            // write empty bytes to hold place in stream
            originalWrite(0);
        }
    }
}
