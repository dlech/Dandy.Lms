using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes
{
    enum CommandType : byte
    {
        DirectCommandReply = 0x00,
        DriectCommandNoReply = 0x80,
        DirectReply = 0x02,
        DirectReplyError = 0x04,
        SystemCommandReply = 0x01,
        SystemCommandNoReply = 0x81,
        SystemReply = 0x03,
        SystemReplyError = 0x05,
    }

    /// <summary>
    /// Flags indicating the type of a command.
    /// </summary>
    [Flags]
    enum CommandTypeFlags
    {
        /// <summary>
        /// The command is a direct command.
        /// </summary>
        /// <remarks>
        /// This is not an actual flag (value is 0), so it can't be used with <see cref="Enum.HasFlag(Enum)"/>.
        /// </remarks>
        Direct = 0x00,

        /// <summary>
        /// The command is a system command.
        /// </summary>
        System = 0x01,

        /// <summary>
        /// This is a reply to a command.
        /// </summary>
        Reply = 0x02,

        /// <summary>
        /// The command was not successful. (Only present in replies).
        /// </summary>
        Error = 0x04,

        /// <summary>
        /// The device should not send a reply to this command.
        /// </summary>
        NoReply = 0x80,
    }
}
