using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes
{
    /// <summary>
    /// Indicates the absence of a value.
    /// </summary>
    /// <remarks>
    /// Using <see cref="Void"/> as a type parameter is not allowed in C#,
    /// so we use this instead.
    /// </remarks>
    public struct Unit
    {
        /// <summary>
        /// The only possible value of <see cref="Unit"/>.
        /// </summary>
        public static Unit Value => new Unit();
    }
}
