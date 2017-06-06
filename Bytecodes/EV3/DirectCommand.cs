using System;
using System.IO;

namespace Dandy.Lms.Bytecodes.EV3
{
    public sealed class DirectCommand<TReply> : EV3Command<TReply>
    {
        const int maxLocals = 64;
        const int maxGlobals = 1021;
        const int maxByteCodes = 64;

        readonly int globals;
        readonly ReplyParser<TReply> replyParser;
        readonly BytecodeObject obj;

        public sealed override CommandTypeFlags CommandType => CommandTypeFlags.Direct;

        internal DirectCommand(int globals, ReplyParser<TReply> replyParser, BytecodeObject obj)
        {
            if (globals < 0 || globals > maxGlobals)
            {
                throw new ArgumentOutOfRangeException($"Cannot be < 0 or excede {maxGlobals}", nameof(globals));
            }
            
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (obj.Type != BytecodeObjectType.VMThread)
            {
                throw new ArgumentOutOfRangeException("Only vmthread objects are supported", nameof(obj));
            }

            if (obj.Locals > maxLocals)
            {
                throw new ArgumentOutOfRangeException("Exceeds max local size", nameof(obj));
            }

            this.globals = globals;
            this.replyParser = replyParser ?? throw new ArgumentNullException(nameof(replyParser));
            this.obj = obj;
        }

        public DirectCommand<TReply> WithBytecodeObject(BytecodeObject obj)
        {
            return new DirectCommand<TReply>(globals, replyParser, obj);
        }
        
        public override sealed byte[] ToBytes(bool expectReply = true)
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                var commandType = CommandType;
                if (!expectReply)
                {
                    commandType |= CommandTypeFlags.NoReply;
                }
                writer.Write((byte)commandType);
                var variables = ((obj.Locals & 0x3F) << 10) | (globals & 0x3FF);
                writer.Write((ushort)variables);
                writer.Write(obj);
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }

        public sealed override TReply ParseReply(byte[] data)
        {
            using (var reader = new BinaryReader(new MemoryStream(data)))
            {
                var status = (CommandTypeFlags)reader.ReadByte();
                if (status.HasFlag(CommandTypeFlags.Error))
                {
                    throw new IOException();
                }
                return replyParser.Invoke(reader);
            }
        }
    }
}
