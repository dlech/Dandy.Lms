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

    [Flags]
    public enum CommandTypeFlags
    {
        Direct = 0x00,
        System = 0x01,
        Reply = 0x02,
        Error = 0x04,
        NoReply = 0x80,
    }
}
