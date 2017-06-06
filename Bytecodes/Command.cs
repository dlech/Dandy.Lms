using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes
{
    public abstract class Command<TReply>
    {
        public abstract DeviceKind DeviceKind { get; }

        public abstract CommandTypeFlags CommandType { get; }

        public abstract byte[] ToBytes(bool expectReply = true);

        public abstract TReply ParseReply(byte[] data);
    }
}
