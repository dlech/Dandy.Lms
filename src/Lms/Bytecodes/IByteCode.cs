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
        /// <param name="writer">Writer used to write the bytecode.</param>
        void Write(BinaryWriter writer);
    }
}
