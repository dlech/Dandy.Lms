﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Devices
{
    /// <summary>
    /// Indicates the kind of a device.
    /// </summary>
    public enum DeviceKind
    {
        /// <summary>
        /// The kind of device is not known.
        /// </summary>
        Unknown,

        /// <summary>
        /// The device is a LEGO MINDSTORMS RCX intelligent brick.
        /// </summary>
        RCX,

        /// <summary>
        /// The device is a LEGO MINDSTORMS NXT intelligent brick.
        /// </summary>
        NXT,

        /// <summary>
        /// The device is a LEGO MINDSTORMS NXT intelligent brick in firmware update mode.
        /// </summary>
        NXTFirmwareUpdate,

        /// <summary>
        /// The device is a LEGO MINDSTORMS EV3 intelligent brick.
        /// </summary>
        EV3,

        /// <summary>
        /// The device is a LEGO MINDSTORMS EV3 intelligent brick in firmware update mode.
        /// </summary>
        EV3FirmwareUpdate,

        /// <summary>
        /// The device is a LEGO WeDo USB Hub.
        /// </summary>
        WeDoUsbHub,

        /// <summary>
        /// The device is a LEGO WeDo 2.0 Smart Hub.
        /// </summary>
        WeDo2SmartHub,

        /// <summary>
        /// The device is a LEGO Boost Move Hub.
        /// </summary>
        BoostMoveHub,
    }
}
