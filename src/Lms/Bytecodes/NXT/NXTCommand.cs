
using Dandy.Lms.Devices;

namespace Dandy.Lms.Bytecodes.NXT
{
    /// <summary>
    /// Object that represents an NXT compatible command.
    /// </summary>
    /// <typeparam name="TReply">The type returned by a reply to this command.</typeparam>
    /// <seealso cref="Command{TReply}"/>
    public abstract class NXTCommand<TReply> : Command<TReply>
    {
        internal NXTCommand()
        {
        }

        /// <summary>
        /// Always returns <see cref="DeviceKind.NXT"/>
        /// </summary>
        public sealed override DeviceKind DeviceKind => DeviceKind.NXT;
    }
}
