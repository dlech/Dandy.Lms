using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Devices
{
    /// <summary>
    /// Get information about device capabilities.
    /// </summary>
    public sealed class DeviceInfo
    {
        /// <summary>
        /// Creates a new instance containing device information for the specified <paramref name="kind"/>.
        /// </summary>
        /// <param name="kind">The kind of device.</param>
        public DeviceInfo(DeviceKind kind)
        {
            switch (kind)
            {
                case DeviceKind.RCX:
                    break;
                case DeviceKind.NXT:
                    HasUSB = true;
                    HasBluetooth = true;
                    break;
                case DeviceKind.NXTFirmwareUpdate:
                    HasUSB = true;
                    break;
                case DeviceKind.EV3:
                    HasUSB = true;
                    HasBluetooth = true;
                    HasWiFi = true;
                    break;
                case DeviceKind.EV3FirmwareUpdate:
                    HasUSB = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Unknown kind of device", nameof(kind));
            }
        }

        /// <summary>
        /// Gets a value indicating that the device has USB communication capabilites.
        /// </summary>
        public bool HasUSB { get; }

        /// <summary>
        /// Gets a value indicating that the device has Bluetooth communication capabilites.
        /// </summary>
        public bool HasBluetooth { get; }

        /// <summary>
        /// Gets a value indicating that the device has Wi-Fi communication capabilites.
        /// </summary>
        public bool HasWiFi { get; }
    }
}
