using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3
{
    enum ReplyStatus : byte
    {
        Success = 0x00,
        UnknownHandle = 0x01,
        HandleNotReady = 0x02,
        CorruptFile = 0x03,
        NoHandleAvailable = 0x04,
        NoPermission = 0x05,
        IllegalPath = 0x06,
        FileExists = 0x07,
        EndOfFile = 0x08,
        SizeError = 0x09,
        UnknownError = 0x0A,
        IllegalFilename = 0x0B,
        IllegalConnection = 0x0C,
    }
}
