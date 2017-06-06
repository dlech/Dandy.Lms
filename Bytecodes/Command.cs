using System;

namespace Dandy.Lms.Bytecodes
{
    /// <summary>
    /// Base class for all commands. Commands represent a single communication transaction with a Device.
    /// </summary>
    /// <typeparam name="TReply">
    /// The data type for values returned by the command. By conventions, <see cref="DBNull"/> is used
    /// when no values are returned and <see cref="ValueTuple"/> is used when more than one value is
    /// returned.
    /// </typeparam>
    public abstract class Command<TReply>
    {
        /// <summary>
        /// The kind of device that this command is compatible with (e.g. EV3 or NXT).
        /// </summary>
        public abstract DeviceKind DeviceKind { get; }

        /// <summary>
        /// The type of command (e.g. <see cref="CommandTypeFlags.Direct"/> or <see cref="CommandTypeFlags.System"/>).
        /// </summary>
        public abstract CommandTypeFlags CommandType { get; }

        /// <summary>
        /// Converts the command to a sequence of bytes suitable for sending to a device.
        /// </summary>
        /// <param name="expectReply"></param>
        /// <returns></returns>
        public abstract byte[] ToBytes(bool expectReply = true);


        /// <summary>
        /// Parse the reply returned by the device.
        /// </summary>
        /// <param name="data">The bytes received from a device in response to this command.</param>
        /// <returns>The values decoded from the reply.</returns>
        public abstract TReply ParseReply(byte[] data);
    }
}
