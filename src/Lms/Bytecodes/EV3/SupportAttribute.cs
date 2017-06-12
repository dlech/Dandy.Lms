using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Indicates if an opcode, enum member, etc. is supported by a VM/firmware vendor.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Field)]
    public sealed class SupportAttribute : Attribute
    {
        /// <summary>
        /// Indicates that the target is supported on the official LEGO VM.
        /// </summary>
        public bool Official;

        /// <summary>
        /// Indicates that the target is supported on the RoboMatter/National Instruments eXtended VM.
        /// </summary>
        public bool Xtended;

        /// <summary>
        /// Indicates that the target is supported on the ev3dev lms2012-compat VM".
        /// </summary>
        public bool Compat;
    }
}
