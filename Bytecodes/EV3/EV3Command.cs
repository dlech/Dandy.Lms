using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3
{
    public abstract class EV3Command<TReply> : Command<TReply>
    {
        internal EV3Command()
        {
        }

        public sealed override DeviceKind DeviceKind => DeviceKind.EV3;
    }
}
