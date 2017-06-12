using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes.NXT
{
    enum CommandValue
    {
        // direct commands

        StartProgram = 0x00,
        StopProgram = 0x01,
        PlaySoundFile = 0x02,
        PlayTone = 0x03,
        SetOutputState = 0x04,
        SetInputMode = 0x05,
        GetOutputState = 0x06,
        GetInputValues = 0x07,
        ResetInputScaledValue = 0x08,
        WriteMessage = 0x09,
        ResetMotorPosition = 0x0A,
        GetBatteryLevel = 0x0B,
        StopSoundPlayback = 0x0C,
        KeepAlive = 0x0D,
        LowSpeedGetStatus = 0x0E,
        LowSpeedWrite = 0x0F,
        LowSpeedRead = 0x10,
        GetCurrentProgramName = 0x11,
        ReadMessage = 0x013,

        // system commands

        OpenRead = 0x80,
        OpenWrite = 0x81,
        Read = 0x82,
        Write = 0x83,
        Close = 0x84,
        Delete = 0x85,
        FindFirst = 0x86,
        FindNext = 0x87,
        GetFirmwareVersion = 0x88,
        OpenWriteLinear = 0x89,
        OpenReadLinear = 0x8A,
        OpenWriteData = 0x8B,
        OpenAppendData = 0x8C,
        Boot = 0x97,
        SetBrickName = 0x98,
        GetDeviceInfo = 0x9B,
        DeleteUserFlash = 0xA0,
        PollLength = 0xA1,
        Poll = 0xA2,
        BluetoothFactoryReset = 0xA4,
    }
}
