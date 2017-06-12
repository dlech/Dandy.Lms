using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3.System
{
    enum SystemCommandValue
    {
        BeginDownload = 0x92,
        ContinueDownload = 0x93,
        BeginUpload = 0x94,
        ContinueUpload = 0x95,
        BeginGetFile = 0x96,
        ContinueGetFile = 0x97,
        CloseFileHandle = 0x98,
        BeginListFiles = 0x99,
        ContinueListFiles = 0x9A,
        CreateDirectory = 0x9B,
        DeleteFile = 0x9C,
        ListOpenHandles = 0x9D,
        WriteMailbox = 0x9E,
        SendBluetoothPin = 0x9F,
        EnterFimrwareUpdateMode = 0xA0,
        SetBundleID = 0xA1,
        SetBundleSeedID = 0xA2,
    }
}
