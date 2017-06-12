using Dandy.Lms.Devices;
using System;

namespace Dandy.Lms.Bytecodes
{
    /// <summary>
    /// Base class for all commands. A command represents a sequence of bytecodes that can be sent
    /// to a device over a communication channel.
    /// </summary>
    /// <typeparam name="TReply">
    /// The data type for values returned by the command. By convention, <see cref="Dandy.Core.Unit"/> is used
    /// when no values are returned and <see cref="ValueTuple"/> is used when more than one value is
    /// returned.
    /// </typeparam>
    public interface ICommand<TReply>
    {
        /// <summary>
        /// The kind of device that this command is compatible with (e.g. EV3 or NXT).
        /// </summary>
        /// <value>The kind of device.</value>
        DeviceKind DeviceKind { get; }
        

        /// <summary>
        /// Converts the command to a sequence of bytes suitable for sending to a device.
        /// </summary>
        /// <param name="expectReply"></param>
        /// <returns>The bytes.</returns>
        byte[] ToBytes(bool expectReply = true);


        /// <summary>
        /// Parse the reply returned by the device.
        /// </summary>
        /// <param name="data">The bytes received from a device in response to this command.</param>
        /// <returns>The values decoded from the reply.</returns>
       TReply ParseReply(byte[] data);
    }
}
