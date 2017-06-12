using System;
using System.IO;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Object that represents an EV3 direct command.
    /// </summary>
    /// <typeparam name="TReply">The data type for values returned by the command.</typeparam>
    /// <seealso cref="Command{TReply}"/>
    public sealed class DirectCommand<TReply> : EV3Command<TReply>
    {
        const int maxLocals = 64;
        const int maxGlobals = 1021;
        const int maxBytecodes = 64;

        readonly int globals;
        readonly ReplyParser<TReply> replyParser;
        readonly BytecodeObject obj;

        /// <summary>
        /// The type of command. Always returns <see cref="CommandTypeFlags.Direct"/>
        /// </summary>
        internal sealed override CommandTypeFlags CommandType => CommandTypeFlags.Direct;

        internal DirectCommand(int globals, ReplyParser<TReply> replyParser, BytecodeObject obj)
        {
            if (globals < 0 || globals > maxGlobals)
            {
                throw new ArgumentOutOfRangeException($"Cannot be < 0 or exceed {maxGlobals}", nameof(globals));
            }
            
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            if (obj.Type != BytecodeObjectType.VMThread)
            {
                throw new ArgumentOutOfRangeException("Only vmthread objects are supported", nameof(obj));
            }

            // TODO: could do a check here to see if we exceed maxBytecodes instead of waiting until ToBytes() is called.

            if (obj.Locals > maxLocals)
            {
                throw new ArgumentOutOfRangeException("Exceeds max local size", nameof(obj));
            }

            this.globals = globals;
            this.replyParser = replyParser ?? throw new ArgumentNullException(nameof(replyParser));
            this.obj = obj;
        }

        /// <summary>
        /// Creates a copy of this command with the specified bytecode object.
        /// </summary>
        /// <param name="obj">The bytecode object.</param>
        /// <returns>A new direct command.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="obj"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="obj"/> is not a <see cref="BytecodeObjectType.VMThread"/>
        /// or the size of the local variables exceeds 1021 bytes.
        /// </exception>
        public DirectCommand<TReply> WithBytecodeObject(BytecodeObject obj)
        {
            return new DirectCommand<TReply>(globals, replyParser, obj);
        }
        
        /// <summary>
        /// Converts the direct command to a sequence of bytes suitable for sending to a device.
        /// </summary>
        /// <param name="expectReply">When set to <c>false</c>, the device will not send a reply.</param>
        /// <returns>The bytecode data.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the direct command exceeds 64 bytes in size.
        /// </exception>
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
                if (writer.BaseStream.Position > maxBytecodes + 1)
                {
                    throw new InvalidOperationException($"Direct commands cannot exceed {maxBytecodes} bytes");
                }
                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }

        /// <summary>
        /// Parses the bytecode data returned from a device as a reply to this command.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
