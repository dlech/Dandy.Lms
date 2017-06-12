using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dandy.Lms.Bytecodes
{
    /// <summary>
    /// Common interface of all bytecodes.
    /// </summary>
    public interface IByteCode
    {
        /// <summary>
        /// Writes the binary representation of the bytecode.
        /// </summary>
        /// <param name="writer">Writer to write to bytecodes to.</param>
        void Write(BinaryWriter writer);
    }
}
