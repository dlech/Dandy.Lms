using Dandy.Lms.Devices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3.System
{
    abstract class SystemCommand<TReply> : ICommand<TReply>
    {
        internal abstract SystemCommandValue SystemCommandValue { get; }

        /// <summary>
        /// Gets the type of device compatible with this command.
        /// </summary>
        /// <value>
        /// Always returns <see cref="DeviceKind.EV3"/>.
        /// </value>
        public DeviceKind DeviceKind => DeviceKind.EV3;

        public byte[] ToBytes(bool expectReply)
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                var replyFlag = expectReply ? 0 : CommandTypeFlags.NoReply;
                writer.Write((byte)(CommandTypeFlags.System | replyFlag));
                writer.Write((byte)SystemCommandValue);
                WriteCommandParameters(writer);
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }

        protected abstract void WriteCommandParameters(BinaryWriter writer);

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
                return ParseReplyParameters(reader);
            }
        }

        protected abstract TReply ParseReplyParameters(BinaryReader reader);
    }
}
