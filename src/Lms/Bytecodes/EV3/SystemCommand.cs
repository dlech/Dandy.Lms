using Dandy.Lms.Devices;
using System;
using System.IO;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    sealed class SystemCommand<TReply> : ICommand<TReply>
    {
        readonly SystemCommandValue systemCommandValue;
        readonly Action<BinaryWriter> writeCommandParameters;
        readonly Func<BinaryReader, TReply> parseReplyParameters;

        /// <summary>
        /// Gets the type of device compatible with this command.
        /// </summary>
        /// <value>
        /// Always returns <see cref="DeviceKind.EV3"/>.
        /// </value>
        public DeviceKind DeviceKind => DeviceKind.EV3;

        internal SystemCommand(SystemCommandValue value,
            Action<BinaryWriter> writeCommandParameters,
            Func<BinaryReader, TReply> parseReplyParameters)
        {
            systemCommandValue = value;
            this.writeCommandParameters = writeCommandParameters ?? throw new ArgumentNullException(nameof(writeCommandParameters));
            this.parseReplyParameters = parseReplyParameters ?? throw new ArgumentNullException(nameof(parseReplyParameters));
        }

        public byte[] ToBytes(bool expectReply = true)
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                var commandType = CommandTypeFlags.System;
                if (!expectReply)
                {
                    commandType |= CommandTypeFlags.NoReply;
                }
                writer.Write((byte)commandType);
                writer.Write((byte)systemCommandValue);
                writeCommandParameters(writer);
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }

        public TReply ParseReply(byte[] data)
        {
            using (var reader = new BinaryReader(new MemoryStream(data), Encoding.ASCII))
            {
                var replyType = (CommandTypeFlags)reader.ReadByte();
                var systemCommand = (SystemCommandValue)reader.ReadByte();
                var replyStatus = (ReplyStatus)reader.ReadByte();
                if (replyType.HasFlag(CommandTypeFlags.Error))
                {
                    // TODO: include replyStatus in exception
                    throw new IOException("Command did not return success", (int)replyStatus);
                }
                return parseReplyParameters(reader);
            }
        }
    }
}
