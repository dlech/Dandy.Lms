using System;
using System.Collections.Generic;
using System.Text;
using Dandy.Lms.Devices;
using System.IO;

namespace Dandy.Lms.Bytecodes.NXT
{
    /// <summary>
    /// Common class for NXT system and direct commands.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Command<T> : ICommand<T>
    {
        readonly CommandTypeFlags type;
        readonly CommandValue value;
        readonly Action<BinaryWriter> writeParameters;
        readonly Func<BinaryReader, T> parseReply;

        public DeviceKind DeviceKind => DeviceKind.NXT;

        internal Command(CommandTypeFlags type, CommandValue value, Action<BinaryWriter> writeParameters, Func<BinaryReader, T> parseReply)
        {
            if (type != CommandTypeFlags.Direct && type != CommandTypeFlags.System)
            {
                throw new ArgumentOutOfRangeException("Can only be system or direct", nameof(type));
            }

            this.type = type;
            this.value = value;
            this.writeParameters = writeParameters ?? throw new ArgumentNullException(nameof(writeParameters));
            this.parseReply = parseReply ?? throw new ArgumentNullException(nameof(parseReply));
        }

        public byte[] ToBytes(bool expectReply = true)
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                var flags = type;
                if (!expectReply)
                {
                    flags |= CommandTypeFlags.NoReply;
                }
                writer.Write((byte)flags);
                writer.Write((byte)value);
                writeParameters(writer);
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }
        public T ParseReply(byte[] data)
        {
            using (var reader = new BinaryReader(new MemoryStream(data)))
            {
                var flags = (CommandTypeFlags)reader.ReadByte();
                if (!flags.HasFlag(CommandTypeFlags.Reply))
                {
                    throw new IOException("Reply flag is missing");
                }
                var command = (CommandValue)reader.ReadByte();
                if (command != value)
                {
                    throw new IOException("Reply command does not match sent command");
                }
                var status = (ReplyStatus)reader.ReadByte();
                if (flags.HasFlag(CommandTypeFlags.Error))
                {
                    throw new CommandFailedException(status);
                }
                return parseReply(reader);
            }
        }
    }
}
