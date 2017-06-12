using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3.System
{
    abstract class SystemCommand<TReply> : EV3Command<TReply>
    {
        internal sealed override CommandTypeFlags CommandType => CommandTypeFlags.System;

        internal abstract SystemCommandValue SystemCommandValue { get; }

        public sealed override byte[] ToBytes(bool expectReply)
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                var replyFlag = expectReply ? 0 : CommandTypeFlags.NoReply;
                writer.Write((byte)(CommandType | replyFlag));
                writer.Write((byte)SystemCommandValue);
                WriteCommandParameters(writer);
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }

        protected abstract void WriteCommandParameters(BinaryWriter writer);

        public sealed override TReply ParseReply(byte[] data)
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
