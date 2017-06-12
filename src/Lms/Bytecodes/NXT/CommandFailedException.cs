using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes.NXT
{
    /// <summary>
    /// Represents an error that is returned when a NXT command failed.
    /// </summary>
    public class CommandFailedException : Exception
    {
        /// <summary>
        /// Creates a new instance of <see cref="CommandFailedException"/>
        /// </summary>
        /// <param name="status">The status returned by the NXT.</param>
        public CommandFailedException(ReplyStatus status)
        {
            Status = status;
        }

        /// <summary>
        /// Gets the status value returned by the NXT.
        /// </summary>
        public ReplyStatus Status { get; }
    }
}
