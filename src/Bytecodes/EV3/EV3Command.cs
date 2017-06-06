
namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Object that represents an EV3 compatible command.
    /// </summary>
    /// <typeparam name="TReply">The type returned by a reply to this command.</typeparam>
    /// <seealso cref="Command{TReply}"/>
    public abstract class EV3Command<TReply> : Command<TReply>
    {
        internal EV3Command()
        {
        }

        /// <summary>
        /// Always returns <see cref="DeviceKind.EV3"/>
        /// </summary>
        public sealed override DeviceKind DeviceKind => DeviceKind.EV3;
    }
}
