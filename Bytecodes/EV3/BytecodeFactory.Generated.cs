

using System;
using System.Collections.Generic;
using System.Diagnostics;

#pragma warning disable IDE0028 // Collection Initalization
#pragma warning disable IDE1006 // Naming Styles

namespace Dandy.Lms.Bytecodes.EV3
{
	[DebuggerDisplay("{code}")]
	public class cmdPROGRAM_INFO : AbstractOpcode
	{
		cmdPROGRAM_INFOValue code;

		internal cmdPROGRAM_INFO(cmdPROGRAM_INFOValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdINFO : AbstractOpcode
	{
		cmdINFOValue code;

		internal cmdINFO(cmdINFOValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdSTRINGS : AbstractOpcode
	{
		cmdSTRINGSValue code;

		internal cmdSTRINGS(cmdSTRINGSValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdUI_READ : AbstractOpcode
	{
		cmdUI_READValue code;

		internal cmdUI_READ(cmdUI_READValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdUI_WRITE : AbstractOpcode
	{
		cmdUI_WRITEValue code;

		internal cmdUI_WRITE(cmdUI_WRITEValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdUI_BUTTON : AbstractOpcode
	{
		cmdUI_BUTTONValue code;

		internal cmdUI_BUTTON(cmdUI_BUTTONValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdUI_DRAW : AbstractOpcode
	{
		cmdUI_DRAWValue code;

		internal cmdUI_DRAW(cmdUI_DRAWValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdMATH : AbstractOpcode
	{
		cmdMATHValue code;

		internal cmdMATH(cmdMATHValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdCOM_READ : AbstractOpcode
	{
		cmdCOM_READValue code;

		internal cmdCOM_READ(cmdCOM_READValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdCOM_WRITE : AbstractOpcode
	{
		cmdCOM_WRITEValue code;

		internal cmdCOM_WRITE(cmdCOM_WRITEValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdSOUND : AbstractOpcode
	{
		cmdSOUNDValue code;

		internal cmdSOUND(cmdSOUNDValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdINPUT_DEVICE : AbstractOpcode
	{
		cmdINPUT_DEVICEValue code;

		internal cmdINPUT_DEVICE(cmdINPUT_DEVICEValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdFILE : AbstractOpcode
	{
		cmdFILEValue code;

		internal cmdFILE(cmdFILEValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdARRAY : AbstractOpcode
	{
		cmdARRAYValue code;

		internal cmdARRAY(cmdARRAYValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdFILENAME : AbstractOpcode
	{
		cmdFILENAMEValue code;

		internal cmdFILENAME(cmdFILENAMEValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdCOM_GET : AbstractOpcode
	{
		cmdCOM_GETValue code;

		internal cmdCOM_GET(cmdCOM_GETValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdCOM_SET : AbstractOpcode
	{
		cmdCOM_SETValue code;

		internal cmdCOM_SET(cmdCOM_SETValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	[DebuggerDisplay("{code}")]
	public class cmdTST : AbstractOpcode
	{
		cmdTSTValue code;

		internal cmdTST(cmdTSTValue code, params IByteCode[] parameters) : base((byte)code, parameters)
		{
			this.code = code;
		}
	}

	partial class BytecodeFactory
	{
		public static class Constant
		{
			/// <summary>
			/// Number of output ports in the system
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int OUTPUTS = 4;

			/// <summary>
			/// Number of input  ports in the system
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int INPUTS = 4;

			/// <summary>
			/// Number of buttons in the system
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int BUTTONS = 6;

			/// <summary>
			/// Number of LEDs in the system
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int LEDS = 4;

			/// <summary>
			/// LCD horizontal pixels
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int LCD_WIDTH = 178;

			/// <summary>
			/// LCD vertical pixels
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int LCD_HEIGHT = 128;

			/// <summary>
			/// Top line vertical pixels
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int TOPLINE_HEIGHT = 10;

			/// <summary>
			/// Store levels
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int LCD_STORE_LEVELS = 3;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DEFAULT_VOLUME = 100;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DEFAULT_SLEEPMINUTES = 30;

			/// <summary>
			/// Forground color
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int FG_COLOR = 1;

			/// <summary>
			/// Background color
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int BG_COLOR = 0;

			/// <summary>
			/// Number of bricks in the USB daisy chain (master + slaves)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int CHAIN_DEPT = 4;

			/// <summary>
			/// Max path size excluding trailing forward slash including zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int PATHSIZE = 84;

			/// <summary>
			/// Max name size including zero termination (must be divideable by 4)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int NAMESIZE = 32;

			/// <summary>
			/// Max extension size including dot and zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int EXTSIZE = 5;

			/// <summary>
			/// Max filename size including path, name, extension and termination (must be divideable by 4)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int FILENAMESIZE = 120;

			/// <summary>
			/// Max WIFI MAC size including zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int MACSIZE = 18;

			/// <summary>
			/// Max WIFI IP size including zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int IPSIZE = 16;

			/// <summary>
			/// Max bluetooth address size including zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int BTADRSIZE = 13;

			/// <summary>
			/// Inclusive zero termination
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int ERR_STRING_SIZE = 32;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int EVENT_NONE = 0;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int EVENT_BT_PIN = 1;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int EVENT_BT_REQ_CONF = 2;

			/// <summary>
			/// Highest valid device type
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int MAX_VALID_TYPE = 101;

			/// <summary>
			/// Folder for non volatile user programs/data
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string MEMORY_FOLDER = "/mnt/ramdisk";

			/// <summary>
			/// Folder for On Brick Programming programs
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string PROGRAM_FOLDER = "../prjs/BrkProg_SAVE";

			/// <summary>
			/// Folder for On Brick Data log files
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string DATALOG_FOLDER = "../prjs/BrkDL_SAVE";

			/// <summary>
			/// Folder for SD card mount
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string SDCARD_FOLDER = "../prjs/SD_Card";

			/// <summary>
			/// Folder for USB stick mount
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string USBSTICK_FOLDER = "../prjs/USB_Stick";

			/// <summary>
			/// Project folder
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string PRJS_DIR = "../prjs";

			/// <summary>
			/// Apps folder
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string APPS_DIR = "../apps";

			/// <summary>
			/// Tools folder
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string TOOLS_DIR = "../tools";

			/// <summary>
			/// Temporary folder
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string TMP_DIR = "../tmp";

			/// <summary>
			/// Folder for non volatile settings
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string SETTINGS_DIR = "../sys/settings";

			/// <summary>
			/// Max directory items allocated including "." and ".."
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DIR_DEEPT = 127;

			/// <summary>
			/// Last run filename
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string LASTRUN_FILE_NAME = "lastrun";

			/// <summary>
			/// Calibration data filename
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string CALDATA_FILE_NAME = "caldata";

			/// <summary>
			/// File used in "Sleep" app to save status
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string SLEEP_FILE_NAME = "Sleep";

			/// <summary>
			/// File used in "Volume" app to save status
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string VOLUME_FILE_NAME = "Volume";

			/// <summary>
			/// File used in "WiFi" app to save status
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string WIFI_FILE_NAME = "WiFi";

			/// <summary>
			/// File used in "Bluetooth" app to save status
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string BLUETOOTH_FILE_NAME = "Bluetooth";

			/// <summary>
			/// Robot Sound File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_SOUND = ".rsf";

			/// <summary>
			/// Robot Graphics File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_GRAPHICS = ".rgf";

			/// <summary>
			/// Robot Byte code File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_BYTECODE = ".rbf";

			/// <summary>
			/// Robot Text File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_TEXT = ".rtf";

			/// <summary>
			/// Robot Datalog File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_DATALOG = ".rdf";

			/// <summary>
			/// Robot Program File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_PROGRAM = ".rpf";

			/// <summary>
			/// Robot Configuration File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_CONFIG = ".rcf";

			/// <summary>
			/// Robot Archive File
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const string EXT_ARCHIVE = ".raf";

			/// <summary>
			/// Brick name maximal size (including zero termination)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int BRICKNAMESIZE = 120;

			/// <summary>
			/// Bluetooth pass key size (including zero termination)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int BTPASSKEYSIZE = 7;

			/// <summary>
			/// WiFi pass key size (including zero termination)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int WIFIPASSKEYSIZE = 33;

			/// <summary>
			/// Character set allowed in brick name and raw filenames
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint CHARSET_NAME = 0x01;

			/// <summary>
			/// Character set allowed in file names
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint CHARSET_FILENAME = 0x02;

			/// <summary>
			/// Character set allowed in bluetooth pass key
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint CHARSET_BTPASSKEY = 0x04;

			/// <summary>
			/// Character set allowed in WiFi pass key
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint CHARSET_WIFIPASSKEY = 0x08;

			/// <summary>
			/// Character set allowed in WiFi ssid
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint CHARSET_WIFISSID = 0x10;

			/// <summary>
			/// DATA8  negative limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA8_MIN = -127;

			/// <summary>
			/// DATA8  positive limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA8_MAX = 127;

			/// <summary>
			/// DATA16 negative limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA16_MIN = -32767;

			/// <summary>
			/// DATA16 positive limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA16_MAX = 32767;

			/// <summary>
			/// DATA32 negative limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA32_MIN = -2147483647;

			/// <summary>
			/// DATA32 positive limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATA32_MAX = 2147483647;

			/// <summary>
			/// DATAF  negative limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATAF_MIN = -2147483647;

			/// <summary>
			/// DATAF  positive limit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			public const int DATAF_MAX = 2147483647;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint DATA8_NAN = 0x80;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint DATA16_NAN = 0x8000;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint DATA32_NAN = 0x80000000;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint DATAF_NAN = 0x7FC00000;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint PULSE_GUI_BACKGROUND = 0x01;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint PULSE_BROWSER = 0x02;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const uint PULSE_KEY = 0x04;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_X = 16;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_Y = 50;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_ICON_X = 64;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_ICON_X1 = 40;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_ICON_X2 = 72;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_ICON_X3 = 104;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_ICON_Y = 60;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_SPEC_ICON_X = 88;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_SPEC_ICON_Y = 60;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_TEXT_X = 80;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_TEXT_Y = 68;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_YES_X = 72;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_YES_Y = 90;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_LINE_X = 21;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_LINE_Y = 89;

			[Support(Official = true, Xtended = true, Compat = true)]
			public const int POP3_ABS_WARN_LINE_ENDX = 155;

		}

		/// <summary>
		/// Type values for byte codes
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum TYPE
		{
			/// <summary>
			/// Mode value that won't change mode in byte codes (convenient place to define)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			MODE_KEEP = -1,

			/// <summary>
			/// Type value that won't change type in byte codes
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_KEEP = 0,

			/// <summary>
			/// Device is NXT touch sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_TOUCH = 1,

			/// <summary>
			/// Device is NXT light sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_LIGHT = 2,

			/// <summary>
			/// Device is NXT sound sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_SOUND = 3,

			/// <summary>
			/// Device is NXT color sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_COLOR = 4,

			/// <summary>
			/// Device is NXT ultra sonic sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_ULTRASONIC = 5,

			/// <summary>
			/// Device is NXT temperature sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_TEMPERATURE = 6,

			/// <summary>
			/// Device is EV3/NXT tacho motor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_TACHO = 7,

			/// <summary>
			/// Device is EV3 mini tacho motor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_MINITACHO = 8,

			/// <summary>
			/// Device is EV3 new tacho motor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NEWTACHO = 9,

			/// <summary>
			/// Device is EV3 touch sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_TOUCH = 16,

			/// <summary>
			/// Device is EV3 color sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_COLOR = 29,

			/// <summary>
			/// Device is EV3 ultra sonic sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_ULTRASONIC = 30,

			/// <summary>
			/// Device is EV3 gyro sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_GYRO = 32,

			/// <summary>
			/// Device is EV3 IR sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_IR = 33,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_THIRD_PARTY_START = 50,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_THIRD_PARTY_END = 98,

			/// <summary>
			/// Device is energy meter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_ENERGYMETER = 99,

			/// <summary>
			/// Device type is not known yet
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_IIC_UNKNOWN = 100,

			/// <summary>
			/// Device is a NXT ADC test sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_TEST = 101,

			/// <summary>
			/// Device is NXT IIC sensor
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NXT_IIC = 123,

			/// <summary>
			/// Port is connected to a terminal
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_TERMINAL = 124,

			/// <summary>
			/// Port not empty but type has not been determined
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_UNKNOWN = 125,

			/// <summary>
			/// Port empty or not available
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_NONE = 126,

			/// <summary>
			/// Port not empty and type is invalid
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_ERROR = 127,

		}

		/// <summary>
		/// Program ID's (Slots)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum SLOT
		{
			/// <summary>
			/// Program slot reserved for executing the user interface
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			GUI_SLOT = 0,

			/// <summary>
			/// Program slot used to execute user projects, apps and tools
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			USER_SLOT = 1,

			/// <summary>
			/// Program slot used for direct commands coming from c_com
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			CMD_SLOT = 2,

			/// <summary>
			/// Program slot used for direct commands coming from c_ui
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			TERM_SLOT = 3,

			/// <summary>
			/// Program slot used to run the debug ui
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEBUG_SLOT = 4,

			/// <summary>
			/// Maximum slots supported by the VM
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			SLOTS = 5,

				/// <remarks>
				/// ONLY VALID IN opPROGRAM_STOP
				/// </remarks>
			[Support(Official = true, Xtended = true, Compat = true)]
			CURRENT_SLOT = -1,

		}

		/// <summary>
		/// Button
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum BUTTONTYPE
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			NO_BUTTON = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			UP_BUTTON = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ENTER_BUTTON = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			DOWN_BUTTON = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			RIGHT_BUTTON = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			LEFT_BUTTON = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			BACK_BUTTON = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			ANY_BUTTON = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			BUTTONTYPES = 8,

		}

		/// <summary>
		/// Browser Types Avaliable
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum BROWSERTYPE
		{
			/// <summary>
			/// Browser for folders
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BROWSE_FOLDERS = 0,

			/// <summary>
			/// Browser for folders and files
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BROWSE_FOLDS_FILES = 1,

			/// <summary>
			/// Browser for cached / recent files
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BROWSE_CACHE = 2,

			/// <summary>
			/// Browser for files
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BROWSE_FILES = 3,

			/// <summary>
			/// Maximum browser types supported by the VM
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BROWSERTYPES = 4,

		}

		/// <summary>
		/// Font Types Avaliable
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum FONTTYPE
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			NORMAL_FONT = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			SMALL_FONT = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			LARGE_FONT = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			TINY_FONT = 3,

			/// <summary>
			/// Maximum font types supported by the VM
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			FONTTYPES = 4,

		}

		/// <summary>
		/// Icon Types Avaliable
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum ICONTYPE
		{
			/// <summary>
			/// 24x12_Files_Folders_Settings.bmp
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			NORMAL_ICON = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			SMALL_ICON = 1,

			/// <summary>
			/// 24x22_Yes_No_OFF_FILEOps.bmp
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LARGE_ICON = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			MENU_ICON = 3,

			/// <summary>
			/// 8x12_miniArrows.bmp
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ARROW_ICON = 4,

			/// <summary>
			/// Maximum icon types supported by the VM
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ICONTYPES = 5,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum S_ICON_NO
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_CHARGING = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BATT_4 = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BATT_3 = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BATT_2 = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BATT_1 = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BATT_0 = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WAIT1 = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WAIT2 = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BT_ON = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BT_VISIBLE = 9,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BT_CONNECTED = 10,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_BT_CONNVISIB = 11,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WIFI_3 = 12,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WIFI_2 = 13,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WIFI_1 = 14,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_WIFI_CONNECTED = 15,

			[Support(Official = true, Xtended = true, Compat = true)]
			SICON_USB = 21,

			[Support(Official = true, Xtended = true, Compat = true)]
			S_ICON_NOS = 22,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum N_ICON_NO
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_NONE = -1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_RUN = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_FOLDER = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_FOLDER2 = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_USB = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_SD = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_SOUND = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_IMAGE = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_SETTINGS = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_ONOFF = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_SEARCH = 9,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_WIFI = 10,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_CONNECTIONS = 11,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_ADD_HIDDEN = 12,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_TRASHBIN = 13,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_VISIBILITY = 14,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_KEY = 15,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_CONNECT = 16,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_DISCONNECT = 17,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_UP = 18,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_DOWN = 19,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_WAIT1 = 20,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_WAIT2 = 21,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_BLUETOOTH = 22,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_INFO = 23,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_TEXT = 24,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_QUESTIONMARK = 27,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_INFO_FILE = 28,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_DISC = 29,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_CONNECTED = 30,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_OBP = 31,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_OBD = 32,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_OPENFOLDER = 33,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_BRICK1 = 34,

			[Support(Official = true, Xtended = true, Compat = true)]
			N_ICON_NOS = 35,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum L_ICON_NO
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			YES_NOTSEL = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			YES_SEL = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			NO_NOTSEL = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			NO_SEL = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			OFF = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			WAIT_VERT = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			WAIT_HORZ = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_MANUAL = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNSIGN = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARN_BATT = 9,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARN_POWER = 10,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARN_TEMP = 11,

			[Support(Official = true, Xtended = true, Compat = true)]
			NO_USBSTICK = 12,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_EXECUTE = 13,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_BRICK = 14,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_SDCARD = 15,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_USBSTICK = 16,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_BLUETOOTH = 17,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_WIFI = 18,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_TRASH = 19,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_COPY = 20,

			[Support(Official = true, Xtended = true, Compat = true)]
			TO_FILE = 21,

			[Support(Official = true, Xtended = true, Compat = true)]
			CHAR_ERROR = 22,

			[Support(Official = true, Xtended = true, Compat = true)]
			COPY_ERROR = 23,

			[Support(Official = true, Xtended = true, Compat = true)]
			PROGRAM_ERROR = 24,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARN_MEMORY = 27,

			[Support(Official = true, Xtended = true, Compat = true)]
			L_ICON_NOS = 28,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum M_ICON_NO
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_STAR = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_LOCKSTAR = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_LOCK = 2,

			/// <summary>
			/// Bluetooth type PC
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_PC = 3,

			/// <summary>
			/// Bluetooth type PHONE
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_PHONE = 4,

			/// <summary>
			/// Bluetooth type BRICK
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_BRICK = 5,

			/// <summary>
			/// Bluetooth type UNKNOWN
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_UNKNOWN = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_FROM_FOLDER = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_CHECKBOX = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_CHECKED = 9,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_XED = 10,

			[Support(Official = true, Xtended = true, Compat = true)]
			M_ICON_NOS = 11,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum A_ICON_NO
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_LEFT = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ICON_RIGHT = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			A_ICON_NOS = 3,

		}

		/// <summary>
		/// Bluetooth Device Types
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum BTTYPE
		{
			/// <summary>
			/// Bluetooth type PC
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BTTYPE_PC = 3,

			/// <summary>
			/// Bluetooth type PHONE
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BTTYPE_PHONE = 4,

			/// <summary>
			/// Bluetooth type BRICK
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BTTYPE_BRICK = 5,

			/// <summary>
			/// Bluetooth type UNKNOWN
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BTTYPE_UNKNOWN = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			BTTYPES = 7,

		}

		/// <summary>
		/// LED Pattern
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum LEDPATTERN
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_BLACK = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_GREEN = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_RED = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_ORANGE = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_GREEN_FLASH = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_RED_FLASH = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_ORANGE_FLASH = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_GREEN_PULSE = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_RED_PULSE = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			LED_ORANGE_PULSE = 9,

			[Support(Official = true, Xtended = true, Compat = true)]
			LEDPATTERNS = 10,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum LEDTYPE
		{
			/// <summary>
			/// All LEDs
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_ALL = 0,

			/// <summary>
			/// Right red
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_RR = 1,

			/// <summary>
			/// Right green
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_RG = 2,

			/// <summary>
			/// Left red
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_LR = 3,

			/// <summary>
			/// Left green
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			LED_LG = 4,

		}

		/// <summary>
		/// File Types Avaliable
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum FILETYPE
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			FILETYPE_UNKNOWN = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_FOLDER = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_SOUND = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_BYTECODE = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_GRAPHICS = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_DATALOG = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_PROGRAM = 6,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_TEXT = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_SDCARD = 16,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_USBSTICK = 32,

			[Support(Official = true, Xtended = true, Compat = true)]
			FILETYPES = 33,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_RESTART_BROWSER = -1,

			[Support(Official = true, Xtended = true, Compat = true)]
			TYPE_REFRESH_BROWSER = -2,

		}

		/// <summary>
		/// Describes result from executing functions
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum RESULT
		{
			/// <summary>
			/// No errors to report
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			OK = 0,

			/// <summary>
			/// Busy - try again
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			BUSY = 1,

			/// <summary>
			/// Something failed
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			FAIL = 2,

			/// <summary>
			/// Stopped
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			STOP = 4,

			/// <summary>
			/// Start
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			START = 8,

		}

		/// <summary>
		/// Data formats used in device type formats
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum DATA_FORMAT
		{
			/// <summary>
			/// DATA8
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_8 = 0,

			/// <summary>
			/// DATA16
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_16 = 1,

			/// <summary>
			/// DATA32
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_32 = 2,

			/// <summary>
			/// DATAF
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_F = 3,

			/// <summary>
			/// Zero terminated string
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_S = 4,

			/// <summary>
			/// Array handle
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_A = 5,

			/// <summary>
			/// Variable type
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_V = 7,

			/// <summary>
			/// Percent
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_PCT = 16,

			/// <summary>
			/// Raw
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_RAW = 18,

			/// <summary>
			/// SI unit
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_SI = 19,

			[Support(Official = true, Xtended = true, Compat = true)]
			DATA_FORMATS = 20,

		}

		/// <summary>
		/// Delimiter codes used to define how data is separated in files
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum DEL
		{
			/// <summary>
			/// No delimiter at all
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_NONE = 0,

			/// <summary>
			/// Use tab as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_TAB = 1,

			/// <summary>
			/// Use space as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_SPACE = 2,

			/// <summary>
			/// Use return as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_RETURN = 3,

			/// <summary>
			/// Use colon as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_COLON = 4,

			/// <summary>
			/// Use comma as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_COMMA = 5,

			/// <summary>
			/// Use line feed as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_LINEFEED = 6,

			/// <summary>
			/// Use return+line feed as delimiter
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEL_CRLF = 7,

			[Support(Official = true, Xtended = true, Compat = true)]
			DELS = 8,

		}

		/// <summary>
		/// Hardware Transport Layer
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum HWTYPE
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			HW_USB = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			HW_BT = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			HW_WIFI = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			HWTYPES = 4,

		}

		/// <summary>
		/// Encryption Types
		/// </summary>
		[Support(Official = true, Xtended = false, Compat = true)]
		public enum ENCRYPT
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			ENCRYPT_NONE = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			ENCRYPT_WPA2 = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			ENCRYPTS = 2,

		}

		/// <summary>
		/// Encryption Types
		/// </summary>
			/// <remarks>
			/// renamed from ENCRYPT
			/// </remarks>
		[Support(Official = false, Xtended = true, Compat = false)]
		public enum LMS_ENCRYPT
		{
				/// <remarks>
				/// renamed from ENCRYPT_NONE
				/// </remarks>
			[Support(Official = true, Xtended = true, Compat = true)]
			LMS_ENCRYPT_NONE = 0,

				/// <remarks>
				/// renamed from ENCRYPT_WPA2
				/// </remarks>
			[Support(Official = true, Xtended = true, Compat = true)]
			LMS_ENCRYPT_WPA2 = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			LMS_ENCRYPTS = 2,

		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public enum COLOR
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			RED = 0,

			[Support(Official = true, Xtended = true, Compat = true)]
			GREEN = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			BLUE = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			BLANK = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			COLORS = 4,

		}

		/// <summary>
		/// Constants related to color sensor value using Color sensor as color detector
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum NXTCOLOR
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			BLACKCOLOR = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			BLUECOLOR = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			GREENCOLOR = 3,

			[Support(Official = true, Xtended = true, Compat = true)]
			YELLOWCOLOR = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			REDCOLOR = 5,

			[Support(Official = true, Xtended = true, Compat = true)]
			WHITECOLOR = 6,

		}

		/// <summary>
		/// Warnings
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum WARNING
		{
			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_TEMP = 1,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_CURRENT = 2,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_VOLTAGE = 4,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_MEMORY = 8,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_DSPSTAT = 16,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_RAM = 32,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_BATTLOW = 64,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNING_BUSY = 128,

			[Support(Official = true, Xtended = true, Compat = true)]
			WARNINGS = 63,

		}

		/// <summary>
		/// Values used to describe an object's status
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum OBJSTAT
		{
			/// <summary>
			/// Object code is running
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			RUNNING = 16,

			/// <summary>
			/// Object is waiting for final trigger
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			WAITING = 32,

			/// <summary>
			/// Object is stopped or not triggered yet
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			STOPPED = 64,

			/// <summary>
			/// Object is halted because a call is in progress
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			HALTED = 128,

		}

		/// <summary>
		/// Device commands used to control (UART sensors) devices
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public enum DEVCMD
		{
			/// <summary>
			/// UART device reset
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEVCMD_RESET = 17,

			/// <summary>
			/// UART device fire   (ultrasonic)
			/// </summary>
				/// <remarks>
				/// Value is duplicate of DEVCMD_RESET.
				/// </remarks>
			[Support(Official = true, Xtended = true, Compat = false)]
			DEVCMD_FIRE = 17,

			/// <summary>
			/// UART device channel (IR seeker)
			/// </summary>
			[Support(Official = true, Xtended = true, Compat = true)]
			DEVCMD_CHANNEL = 18,

			[Support(Official = true, Xtended = true, Compat = true)]
			DEVCMDS = 19,

		}

		/// <summary>
		/// This code does not exist in normal program
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to INSTRBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opERROR()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.ERROR, parameterList.ToArray());
		}

		/// <summary>
		/// This code does absolutely nothing
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opNOP()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.NOP, parameterList.ToArray());
		}

		/// <summary>
		/// Stops specific program id slot
		/// </summary>
		/// <param name="PRGID">Program id (GUI_SLOT = all, CURRENT_SLOT = current)</param>
		/// <remarks>
		/// Dispatch status changes to PRGBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPROGRAM_STOP(IExpression<Data16> PRGID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			return new Opcode(OpcodeValue.PROGRAM_STOP, parameterList.ToArray());
		}

		/// <summary>
		/// Start program id slot
		/// </summary>
		/// <param name="PRGID">Program id</param>
		/// <param name="SIZE">Size of image</param>
		/// <param name="IP">Address of image (value from opFILE(LOAD_IMAGE,..) )</param>
		/// <param name="DEBUG">Debug mode (0=normal, 1=debug, 2=don't execute)</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPROGRAM_START(IExpression<Data16> PRGID, IExpression<Data32> SIZE, IExpression<Data32> IP, IExpression<Data8> DEBUG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			parameterList.Add(DEBUG ?? throw new ArgumentNullException(nameof(DEBUG)));
			return new Opcode(OpcodeValue.PROGRAM_START, parameterList.ToArray());
		}

		/// <summary>
		/// Stops specific object
		/// </summary>
		/// <param name="OBJID">Object id</param>
		/// <remarks>
		/// Dispatch status changes to STOPBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOBJECT_STOP(IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new Opcode(OpcodeValue.OBJECT_STOP, parameterList.ToArray());
		}

		/// <summary>
		/// Start specific object
		/// </summary>
		/// <param name="OBJID">Object id</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOBJECT_START(IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new Opcode(OpcodeValue.OBJECT_START, parameterList.ToArray());
		}

		/// <summary>
		/// Triggers object and run the object if fully triggered
		/// </summary>
		/// <param name="OBJID">Object id</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOBJECT_TRIG(IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new Opcode(OpcodeValue.OBJECT_TRIG, parameterList.ToArray());
		}

		/// <summary>
		/// Wait until object has run
		/// </summary>
		/// <param name="OBJID">Object id</param>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOBJECT_WAIT(IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new Opcode(OpcodeValue.OBJECT_WAIT, parameterList.ToArray());
		}

		/// <summary>
		/// Return from byte code subroutine
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to STOPBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opRETURN()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.RETURN, parameterList.ToArray());
		}

		/// <summary>
		/// Calls byte code subroutine
		/// </summary>
		/// <param name="OBJID">Object id</param>
		/// <param name="PARAMETERS">Number of parameters</param>
		/// <param name="PARAMETERS_">variable arguments</param>
		/// <remarks>
		/// Dispatch status changes to STOPBREAK or BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCALL(IExpression<Data16> OBJID, IExpression<Data8> PARAMETERS, params IExpression[] PARAMETERS_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			parameterList.Add(PARAMETERS ?? throw new ArgumentNullException(nameof(PARAMETERS)));
			parameterList.AddRange(PARAMETERS_ ?? throw new ArgumentNullException(nameof(PARAMETERS_)));
			return new Opcode(OpcodeValue.CALL, parameterList.ToArray());
		}

		/// <summary>
		/// Stops current object
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to STOPBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOBJECT_END()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.OBJECT_END, parameterList.ToArray());
		}

		/// <summary>
		/// Breaks execution of current VMTHREAD
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to INSTRBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSLEEP()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.SLEEP, parameterList.ToArray());
		}

		/// <summary>
		/// Get program data
		/// </summary>
		/// <param name="CMD">Specific command parameter</param>
		/// <remarks>
		/// Dispatch status can change to FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPROGRAM_INFO(cmdPROGRAM_INFO CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.PROGRAM_INFO, parameterList.ToArray());
		}

		/// <summary>
		/// This code does nothing besides marking an address to a label
		/// </summary>
		/// <param name="NO">Label number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opLABEL(IExpression<DataLabel> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new Opcode(OpcodeValue.LABEL, parameterList.ToArray());
		}

		/// <summary>
		/// Display globals or object locals on terminal
		/// </summary>
		/// <param name="PRGID">Program slot number</param>
		/// <param name="OBJID">Object id (zero means globals)</param>
		/// <param name="OFFSET">Offset (start from)</param>
		/// <param name="SIZE">Size (length of dump) zero means all (max 1024)</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPROBE(IExpression<Data16> PRGID, IExpression<Data16> OBJID, IExpression<Data32> OFFSET, IExpression<Data32> SIZE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			return new Opcode(OpcodeValue.PROBE, parameterList.ToArray());
		}

		/// <summary>
		/// Run byte code snippet
		/// </summary>
		/// <param name="PRGID">Program slot number</param>
		/// <param name="IMAGE">Address of image</param>
		/// <param name="GLOBAL">Address of global variables</param>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opDO(IExpression<Data16> PRGID, IExpression<Data32> IMAGE, IExpression<Data32> GLOBAL)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(IMAGE ?? throw new ArgumentNullException(nameof(IMAGE)));
			parameterList.Add(GLOBAL ?? throw new ArgumentNullException(nameof(GLOBAL)));
			return new Opcode(OpcodeValue.DO, parameterList.ToArray());
		}

		/// <summary>
		/// Add two 8-bit values DESTINATION = SOURCE1 + SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opADD8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.ADD8, parameterList.ToArray());
		}

		/// <summary>
		/// Add two 16-bit values DESTINATION = SOURCE1 + SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opADD16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.ADD16, parameterList.ToArray());
		}

		/// <summary>
		/// Add two 32-bit values DESTINATION = SOURCE1 + SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opADD32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.ADD32, parameterList.ToArray());
		}

		/// <summary>
		/// Add two floating point values DESTINATION = SOURCE1 + SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opADDF(IExpression<DataFloat> SOURCE1, IExpression<DataFloat> SOURCE2, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.ADDF, parameterList.ToArray());
		}

		/// <summary>
		/// Subtract two 8 bit values DESTINATION = SOURCE1 - SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSUB8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.SUB8, parameterList.ToArray());
		}

		/// <summary>
		/// Subtract two 16 bit values DESTINATION = SOURCE1 - SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSUB16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.SUB16, parameterList.ToArray());
		}

		/// <summary>
		/// Subtract two 32 bit values DESTINATION = SOURCE1 - SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSUB32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.SUB32, parameterList.ToArray());
		}

		/// <summary>
		/// Subtract two floating point values DESTINATION = SOURCE1 - SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSUBF(IExpression<DataFloat> SOURCE1, IExpression<DataFloat> SOURCE2, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.SUBF, parameterList.ToArray());
		}

		/// <summary>
		/// Multiply two 8 bit values DESTINATION = SOURCE1 * SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMUL8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MUL8, parameterList.ToArray());
		}

		/// <summary>
		/// Multiply two 16 bit values DESTINATION = SOURCE1 * SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMUL16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MUL16, parameterList.ToArray());
		}

		/// <summary>
		/// Multiply two 32 bit values DESTINATION = SOURCE1 * SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMUL32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MUL32, parameterList.ToArray());
		}

		/// <summary>
		/// Multiply two floating point values DESTINATION = SOURCE1 * SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMULF(IExpression<DataFloat> SOURCE1, IExpression<DataFloat> SOURCE2, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MULF, parameterList.ToArray());
		}

		/// <summary>
		/// Divide two 8 bit values DESTINATION = SOURCE1 / SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opDIV8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.DIV8, parameterList.ToArray());
		}

		/// <summary>
		/// Divide two 16 bit values DESTINATION = SOURCE1 / SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opDIV16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.DIV16, parameterList.ToArray());
		}

		/// <summary>
		/// Divide two 32 bit values DESTINATION = SOURCE1 / SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opDIV32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.DIV32, parameterList.ToArray());
		}

		/// <summary>
		/// Divide two floating point values DESTINATION = SOURCE1 / SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opDIVF(IExpression<DataFloat> SOURCE1, IExpression<DataFloat> SOURCE2, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.DIVF, parameterList.ToArray());
		}

		/// <summary>
		/// Or two 8 bit values DESTINATION = SOURCE1 | SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOR8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.OR8, parameterList.ToArray());
		}

		/// <summary>
		/// Or two 16 bit values DESTINATION = SOURCE1 | SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOR16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.OR16, parameterList.ToArray());
		}

		/// <summary>
		/// Or two 32 bit values DESTINATION = SOURCE1 | SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOR32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.OR32, parameterList.ToArray());
		}

		/// <summary>
		/// And two 8 bit values DESTINATION = SOURCE1 & SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opAND8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.AND8, parameterList.ToArray());
		}

		/// <summary>
		/// And two 16 bit values DESTINATION = SOURCE1 & SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opAND16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.AND16, parameterList.ToArray());
		}

		/// <summary>
		/// And two 32 bit values DESTINATION = SOURCE1 & SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opAND32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.AND32, parameterList.ToArray());
		}

		/// <summary>
		/// Exclusive or two 8 bit values DESTINATION = SOURCE1 ^ SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opXOR8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.XOR8, parameterList.ToArray());
		}

		/// <summary>
		/// Exclusive or two 16 bit values DESTINATION = SOURCE1 ^ SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opXOR16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.XOR16, parameterList.ToArray());
		}

		/// <summary>
		/// Exclusive or two 32 bit values DESTINATION = SOURCE1 ^ SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opXOR32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.XOR32, parameterList.ToArray());
		}

		/// <summary>
		/// Rotate left 8 bit value DESTINATION = SOURCE1 << SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opRL8(IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.RL8, parameterList.ToArray());
		}

		/// <summary>
		/// Rotate left 16 bit value DESTINATION = SOURCE1 << SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opRL16(IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.RL16, parameterList.ToArray());
		}

		/// <summary>
		/// Rotate left 32 bit value DESTINATION = SOURCE1 << SOURCE2
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opRL32(IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.RL32, parameterList.ToArray());
		}

		/// <summary>
		/// Move LENGTH number of DATA8 from BYTE STREAM to memory DESTINATION START
		/// </summary>
		/// <param name="DESTINATION">First element in DATA8 array to be initiated</param>
		/// <param name="LENGTH">Number of elements to initiate</param>
		/// <param name="SOURCE">First element to initiate DATA8 array with</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINIT_BYTES(IExpression<Data8> DESTINATION, IExpression<Data32> LENGTH, params IExpression<Data8>[] SOURCE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.AddRange(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			return new Opcode(OpcodeValue.INIT_BYTES, parameterList.ToArray());
		}

		/// <summary>
		/// Move 8 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE8_8(IExpression<Data8> SOURCE, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE8_8, parameterList.ToArray());
		}

		/// <summary>
		/// Move 8 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE8_16(IExpression<Data8> SOURCE, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE8_16, parameterList.ToArray());
		}

		/// <summary>
		/// Move 8 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE8_32(IExpression<Data8> SOURCE, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE8_32, parameterList.ToArray());
		}

		/// <summary>
		/// Move 8 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE8_F(IExpression<Data8> SOURCE, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE8_F, parameterList.ToArray());
		}

		/// <summary>
		/// Move 16 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE16_8(IExpression<Data16> SOURCE, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE16_8, parameterList.ToArray());
		}

		/// <summary>
		/// Move 16 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE16_16(IExpression<Data16> SOURCE, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE16_16, parameterList.ToArray());
		}

		/// <summary>
		/// Move 16 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE16_32(IExpression<Data16> SOURCE, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE16_32, parameterList.ToArray());
		}

		/// <summary>
		/// Move 16 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE16_F(IExpression<Data16> SOURCE, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE16_F, parameterList.ToArray());
		}

		/// <summary>
		/// Move 32 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE32_8(IExpression<Data32> SOURCE, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE32_8, parameterList.ToArray());
		}

		/// <summary>
		/// Move 32 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE32_16(IExpression<Data32> SOURCE, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE32_16, parameterList.ToArray());
		}

		/// <summary>
		/// Move 32 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE32_32(IExpression<Data32> SOURCE, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE32_32, parameterList.ToArray());
		}

		/// <summary>
		/// Move 32 bit value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVE32_F(IExpression<Data32> SOURCE, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVE32_F, parameterList.ToArray());
		}

		/// <summary>
		/// Move floating point value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVEF_8(IExpression<DataFloat> SOURCE, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVEF_8, parameterList.ToArray());
		}

		/// <summary>
		/// Move floating point value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVEF_16(IExpression<DataFloat> SOURCE, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVEF_16, parameterList.ToArray());
		}

		/// <summary>
		/// Move floating point value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVEF_32(IExpression<DataFloat> SOURCE, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVEF_32, parameterList.ToArray());
		}

		/// <summary>
		/// Move floating point value from SOURCE to DESTINATION
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMOVEF_F(IExpression<DataFloat> SOURCE, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.MOVEF_F, parameterList.ToArray());
		}

		/// <summary>
		/// Branch unconditionally relative
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR(IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative if FLAG is FALSE (zero)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_FALSE(IExpression<Data8> FLAG, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_FALSE, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative if FLAG is TRUE (non zero)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_TRUE(IExpression<Data8> FLAG, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_TRUE, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative if VALUE is NAN (not a number)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_NAN(IExpression<DataFloat> VALUE, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_NAN, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LT8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LT8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LT16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LT16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LT32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LT32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LTF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LTF, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GT8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GT8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GT16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GT16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GT32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GT32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GTF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GTF, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_EQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_EQ8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_EQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_EQ16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_EQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_EQ32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_EQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_EQF, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is not equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_NEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_NEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is not equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_NEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_NEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is not equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_NEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_NEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is not equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_NEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_NEQF, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LTEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LTEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LTEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LTEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LTEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LTEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is less than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_LTEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_LTEQF, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GTEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GTEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GTEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GTEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GTEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GTEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// If LEFT is greater than or equal to RIGTH - set FLAG
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCP_GTEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new Opcode(OpcodeValue.CP_GTEQF, parameterList.ToArray());
		}

		/// <summary>
		/// If FLAG is set move SOURCE1 to RESULT else move SOURCE2 to RESULT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSELECT8(IExpression<Data8> FLAG, IExpression<Data8> SOURCE1, IExpression<Data8> SOURCE2, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.SELECT8, parameterList.ToArray());
		}

		/// <summary>
		/// If FLAG is set move SOURCE1 to RESULT else move SOURCE2 to RESULT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSELECT16(IExpression<Data8> FLAG, IExpression<Data16> SOURCE1, IExpression<Data16> SOURCE2, IExpression<Data16> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.SELECT16, parameterList.ToArray());
		}

		/// <summary>
		/// If FLAG is set move SOURCE1 to RESULT else move SOURCE2 to RESULT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSELECT32(IExpression<Data8> FLAG, IExpression<Data32> SOURCE1, IExpression<Data32> SOURCE2, IExpression<Data32> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.SELECT32, parameterList.ToArray());
		}

		/// <summary>
		/// If FLAG is set move SOURCE1 to RESULT else move SOURCE2 to RESULT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSELECTF(IExpression<Data8> FLAG, IExpression<DataFloat> SOURCE1, IExpression<DataFloat> SOURCE2, IExpression<DataFloat> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.SELECTF, parameterList.ToArray());
		}

		/// <summary>
		/// Executes a system command
		/// </summary>
		/// <param name="COMMAND">Command string (HND)</param>
		/// <param name="STATUS">Return status of the command</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSYSTEM(IExpression<DataString> COMMAND, IExpression<Data32> STATUS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COMMAND ?? throw new ArgumentNullException(nameof(COMMAND)));
			parameterList.Add(STATUS ?? throw new ArgumentNullException(nameof(STATUS)));
			return new Opcode(OpcodeValue.SYSTEM, parameterList.ToArray());
		}

		/// <summary>
		/// Convert encoded port to Layer and Bitfield
		/// </summary>
		/// <param name="PortIn">EncodedPortNumber</param>
		/// <param name="Layer">Layer</param>
		/// <param name="Bitfield">Bitfield</param>
		/// <param name="Inverted">yes if left/right motor are inverted (ie, C&A)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPORT_CNV_OUTPUT(IExpression<Data32> PortIn, IExpression<Data8> Layer, IExpression<Data8> Bitfield, IExpression<Data8> Inverted)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PortIn ?? throw new ArgumentNullException(nameof(PortIn)));
			parameterList.Add(Layer ?? throw new ArgumentNullException(nameof(Layer)));
			parameterList.Add(Bitfield ?? throw new ArgumentNullException(nameof(Bitfield)));
			parameterList.Add(Inverted ?? throw new ArgumentNullException(nameof(Inverted)));
			return new Opcode(OpcodeValue.PORT_CNV_OUTPUT, parameterList.ToArray());
		}

		/// <summary>
		/// Convert encoded port to Layer and Port
		/// </summary>
		/// <param name="PortIn">EncodedPortNumber</param>
		/// <param name="Layer">Layer</param>
		/// <param name="PortOut">0-index port for use with VM commands</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opPORT_CNV_INPUT(IExpression<Data32> PortIn, IExpression<Data8> Layer, IExpression<Data8> PortOut)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PortIn ?? throw new ArgumentNullException(nameof(PortIn)));
			parameterList.Add(Layer ?? throw new ArgumentNullException(nameof(Layer)));
			parameterList.Add(PortOut ?? throw new ArgumentNullException(nameof(PortOut)));
			return new Opcode(OpcodeValue.PORT_CNV_INPUT, parameterList.ToArray());
		}

		/// <summary>
		/// Convert note to tone
		/// </summary>
		/// <param name="NOTE">Note string (HND) (e.c. "C#4")</param>
		/// <param name="FREQ">Frequency [Hz]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opNOTE_TO_FREQ(IExpression<DataString> NOTE, IExpression<Data16> FREQ)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NOTE ?? throw new ArgumentNullException(nameof(NOTE)));
			parameterList.Add(FREQ ?? throw new ArgumentNullException(nameof(FREQ)));
			return new Opcode(OpcodeValue.NOTE_TO_FREQ, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LT8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LT8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LT16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LT16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LT32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LT32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LTF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LTF, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GT8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GT8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GT16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GT16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GT32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GT32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GTF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GTF, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_EQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_EQ8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_EQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_EQ16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_EQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_EQ32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_EQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_EQF, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is not equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_NEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_NEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is not equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_NEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_NEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is not equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_NEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_NEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is not equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_NEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_NEQF, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LTEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LTEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LTEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LTEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LTEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LTEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is less than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_LTEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_LTEQF, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GTEQ8(IExpression<Data8> LEFT, IExpression<Data8> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GTEQ8, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GTEQ16(IExpression<Data16> LEFT, IExpression<Data16> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GTEQ16, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GTEQ32(IExpression<Data32> LEFT, IExpression<Data32> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GTEQ32, parameterList.ToArray());
		}

		/// <summary>
		/// Branch relative OFFSET if LEFT is greater than or equal to RIGHT
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opJR_GTEQF(IExpression<DataFloat> LEFT, IExpression<DataFloat> RIGHT, IExpression<DataLabel> OFFSET)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LEFT ?? throw new ArgumentNullException(nameof(LEFT)));
			parameterList.Add(RIGHT ?? throw new ArgumentNullException(nameof(RIGHT)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			return new Opcode(OpcodeValue.JR_GTEQF, parameterList.ToArray());
		}

		/// <summary>
		/// Info functions entry
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINFO(cmdINFO CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.INFO, parameterList.ToArray());
		}

		/// <summary>
		/// String function entry
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSTRINGS(cmdSTRINGS CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.STRINGS, parameterList.ToArray());
		}

		/// <summary>
		/// Write VM memory
		/// </summary>
		/// <param name="PRGID">Program slot number (must be running)</param>
		/// <param name="OBJID">Object id (zero means globals)</param>
		/// <param name="OFFSET">Offset (start from)</param>
		/// <param name="SIZE">Size (length of array to write)</param>
		/// <param name="ARRAY">First element of DATA8 array to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMEMORY_WRITE(IExpression<Data16> PRGID, IExpression<Data16> OBJID, IExpression<Data32> OFFSET, IExpression<Data32> SIZE, IExpression<Data8> ARRAY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			return new Opcode(OpcodeValue.MEMORY_WRITE, parameterList.ToArray());
		}

		/// <summary>
		/// Read VM memory
		/// </summary>
		/// <param name="PRGID">Program slot number (must be running)</param>
		/// <param name="OBJID">Object id (zero means globals)</param>
		/// <param name="OFFSET">Offset (start from)</param>
		/// <param name="SIZE">Size (length of array to read)</param>
		/// <param name="ARRAY">First element of DATA8 array to receive data</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMEMORY_READ(IExpression<Data16> PRGID, IExpression<Data16> OBJID, IExpression<Data32> OFFSET, IExpression<Data32> SIZE, IExpression<Data8> ARRAY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			return new Opcode(OpcodeValue.MEMORY_READ, parameterList.ToArray());
		}

		/// <summary>
		/// User Interface flush buffers
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opUI_FLUSH()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.UI_FLUSH, parameterList.ToArray());
		}

		/// <summary>
		/// User Interface read
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opUI_READ(cmdUI_READ CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.UI_READ, parameterList.ToArray());
		}

		/// <remarks>
		/// Dispatch status can change to BUSYBREAK and FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opUI_WRITE(cmdUI_WRITE CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.UI_WRITE, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opUI_BUTTON(cmdUI_BUTTON CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.UI_BUTTON, parameterList.ToArray());
		}

		/// <summary>
		/// UI draw
		/// </summary>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opUI_DRAW(cmdUI_DRAW CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.UI_DRAW, parameterList.ToArray());
		}

		/// <summary>
		/// Setup timer to wait TIME mS
		/// </summary>
		/// <param name="TIME">Time to wait [mS]</param>
		/// <param name="TIMER">Variable used for timing</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opTIMER_WAIT(IExpression<Data32> TIME, IExpression<Data32> TIMER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(TIMER ?? throw new ArgumentNullException(nameof(TIMER)));
			return new Opcode(OpcodeValue.TIMER_WAIT, parameterList.ToArray());
		}

		/// <summary>
		/// Wait for timer ready (wait for timeout)
		/// </summary>
		/// <param name="TIMER">Variable used for timing</param>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opTIMER_READY(IExpression<Data32> TIMER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIMER ?? throw new ArgumentNullException(nameof(TIMER)));
			return new Opcode(OpcodeValue.TIMER_READY, parameterList.ToArray());
		}

		/// <summary>
		/// Read free running timer [mS]
		/// </summary>
		/// <param name="TIME">Value</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opTIMER_READ(IExpression<Data32> TIME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			return new Opcode(OpcodeValue.TIMER_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Display globals or object locals on terminal
		/// </summary>
		/// <remarks>
		/// Removes it self when done
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opBP0()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.BP0, parameterList.ToArray());
		}

		/// <summary>
		/// Display globals or object locals on terminal
		/// </summary>
		/// <remarks>
		/// Removes it self when done
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opBP1()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.BP1, parameterList.ToArray());
		}

		/// <summary>
		/// Display globals or object locals on terminal
		/// </summary>
		/// <remarks>
		/// Removes it self when done
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opBP2()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.BP2, parameterList.ToArray());
		}

		/// <summary>
		/// Display globals or object locals on terminal
		/// </summary>
		/// <remarks>
		/// Removes it self when done
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opBP3()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.BP3, parameterList.ToArray());
		}

		/// <summary>
		/// Set break point in byte code program
		/// </summary>
		/// <param name="PRGID">Program slot number</param>
		/// <param name="NO">Breakpoint number [0..2] (3 = trigger out on TP4)</param>
		/// <param name="ADDRESS">Address (Offset from start of image) (0 = remove breakpoint)</param>
		/// <remarks>
		/// TP4 is only present on pre-release EV3 hardware
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opBP_SET(IExpression<Data16> PRGID, IExpression<Data8> NO, IExpression<Data32> ADDRESS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(ADDRESS ?? throw new ArgumentNullException(nameof(ADDRESS)));
			return new Opcode(OpcodeValue.BP_SET, parameterList.ToArray());
		}

		/// <summary>
		/// Math function entry
		/// </summary>
		/// <param name="CMD">Specific command parameter</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMATH(cmdMATH CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.MATH, parameterList.ToArray());
		}

		/// <summary>
		/// Get random value
		/// </summary>
		/// <param name="MIN">Minimum value</param>
		/// <param name="MAX">Maximum value</param>
		/// <param name="VALUE">value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opRANDOM(IExpression<Data16> MIN, IExpression<Data16> MAX, IExpression<Data16> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(MIN ?? throw new ArgumentNullException(nameof(MIN)));
			parameterList.Add(MAX ?? throw new ArgumentNullException(nameof(MAX)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.RANDOM, parameterList.ToArray());
		}

		/// <summary>
		/// Read free running timer [uS]
		/// </summary>
		/// <param name="TIME">Value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opTIMER_READ_US(IExpression<Data32> TIME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			return new Opcode(OpcodeValue.TIMER_READ_US, parameterList.ToArray());
		}

		/// <summary>
		/// Keep alive
		/// </summary>
		/// <param name="MINUTES">Number of minutes before sleep</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opKEEP_ALIVE(IExpression<Data8> MINUTES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(MINUTES ?? throw new ArgumentNullException(nameof(MINUTES)));
			return new Opcode(OpcodeValue.KEEP_ALIVE, parameterList.ToArray());
		}

		/// <summary>
		/// Communication read
		/// </summary>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_READ(cmdCOM_READ CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.COM_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Communication write
		/// </summary>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_WRITE(cmdCOM_WRITE CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.COM_WRITE, parameterList.ToArray());
		}

		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSOUND(cmdSOUND CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.SOUND, parameterList.ToArray());
		}

		/// <summary>
		/// Test if sound busy (playing file or tone
		/// </summary>
		/// <param name="BUSY">Sound busy flag (0 = ready, 1 = busy)</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSOUND_TEST(IExpression<Data8> BUSY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUSY ?? throw new ArgumentNullException(nameof(BUSY)));
			return new Opcode(OpcodeValue.SOUND_TEST, parameterList.ToArray());
		}

		/// <summary>
		/// Wait for sound ready (wait until sound finished)
		/// </summary>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opSOUND_READY()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.SOUND_READY, parameterList.ToArray());
		}

		/// <summary>
		/// Sample devices
		/// </summary>
		/// <param name="TIME">Sample time [mS]</param>
		/// <param name="SAMPLES">Number of samples</param>
		/// <param name="INIT">DATA16 array (handle) - to start/reset buffer -> fill array with -1 otherwise don't change</param>
		/// <param name="DEVICES">DATA8 array (handle) with devices to sample</param>
		/// <param name="TYPES">DATA8 array (handle) with types</param>
		/// <param name="MODES">DATA8 array (handle) with modes</param>
		/// <param name="DATASETS">DATA8 array (handle) with data sets</param>
		/// <param name="VALUES">DATAF array (handle) with values</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_SAMPLE(IExpression<Data32> TIME, IExpression<Data16> SAMPLES, IExpression<Data16> INIT, IExpression<Data8> DEVICES, IExpression<Data8> TYPES, IExpression<Data8> MODES, IExpression<Data8> DATASETS, IExpression<DataFloat> VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(SAMPLES ?? throw new ArgumentNullException(nameof(SAMPLES)));
			parameterList.Add(INIT ?? throw new ArgumentNullException(nameof(INIT)));
			parameterList.Add(DEVICES ?? throw new ArgumentNullException(nameof(DEVICES)));
			parameterList.Add(TYPES ?? throw new ArgumentNullException(nameof(TYPES)));
			parameterList.Add(MODES ?? throw new ArgumentNullException(nameof(MODES)));
			parameterList.Add(DATASETS ?? throw new ArgumentNullException(nameof(DATASETS)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new Opcode(OpcodeValue.INPUT_SAMPLE, parameterList.ToArray());
		}

		/// <summary>
		/// Read all available devices on input and output(chain)
		/// </summary>
		/// <param name="LENGTH">Maximum number of device types (normally 32)</param>
		/// <param name="ARRAY">First element of DATA8 array of types (normally 32)</param>
		/// <param name="CHANGED">Changed status</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_DEVICE_LIST(IExpression<Data8> LENGTH, IExpression<Data8> ARRAY, IExpression<Data8> CHANGED)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			parameterList.Add(CHANGED ?? throw new ArgumentNullException(nameof(CHANGED)));
			return new Opcode(OpcodeValue.INPUT_DEVICE_LIST, parameterList.ToArray());
		}

		/// <summary>
		/// Read information about device
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_DEVICE(cmdINPUT_DEVICE CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.INPUT_DEVICE, parameterList.ToArray());
		}

		/// <summary>
		/// Read device value in Percent
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="PCT">Percent value from device</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_READ(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> PCT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(PCT ?? throw new ArgumentNullException(nameof(PCT)));
			return new Opcode(OpcodeValue.INPUT_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Test if device busy (changing type or mode)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="BUSY">Device busy flag (0 = ready, 1 = busy)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_TEST(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> BUSY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(BUSY ?? throw new ArgumentNullException(nameof(BUSY)));
			return new Opcode(OpcodeValue.INPUT_TEST, parameterList.ToArray());
		}

		/// <summary>
		/// Wait for device ready (wait for valid data)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_READY(IExpression<Data8> LAYER, IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new Opcode(OpcodeValue.INPUT_READY, parameterList.ToArray());
		}

		/// <summary>
		/// Read device value in SI units
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="SI">SI unit value from device</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_READSI(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<DataFloat> SI)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(SI ?? throw new ArgumentNullException(nameof(SI)));
			return new Opcode(OpcodeValue.INPUT_READSI, parameterList.ToArray());
		}

		/// <summary>
		/// Read device value
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="FORMAT">Format (PCT, RAW, SI ...)</param>
		/// <param name="VALUES">Number of return values</param>
		/// <param name="VALUES_">variable arguments</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_READEXT(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> FORMAT, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(FORMAT ?? throw new ArgumentNullException(nameof(FORMAT)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new Opcode(OpcodeValue.INPUT_READEXT, parameterList.ToArray());
		}

		/// <summary>
		/// Write data to device (only UART devices)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="BYTES">No of bytes to write [1..32]</param>
		/// <param name="DATA">First byte in DATA8 array to write</param>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opINPUT_WRITE(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> BYTES, IExpression<Data8> DATA)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			parameterList.Add(DATA ?? throw new ArgumentNullException(nameof(DATA)));
			return new Opcode(OpcodeValue.INPUT_WRITE, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE"></param>
		/// <remarks>
		/// This bytecode is defined but not implemented
		/// </remarks>
		[Support(Official = false, Xtended = false, Compat = false)]
		public static Opcode opOUTPUT_GET_TYPE(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new Opcode(OpcodeValue.OUTPUT_GET_TYPE, parameterList.ToArray());
		}

		/// <summary>
		/// Set output type
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Output no [0..3]</param>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_SET_TYPE(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new Opcode(OpcodeValue.OUTPUT_SET_TYPE, parameterList.ToArray());
		}

		/// <summary>
		/// Resets the Tacho counts
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_RESET(IExpression<Data8> LAYER, IExpression<Data8> NOS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			return new Opcode(OpcodeValue.OUTPUT_RESET, parameterList.ToArray());
		}

		/// <summary>
		/// Stops the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_STOP(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_STOP, parameterList.ToArray());
		}

		/// <summary>
		/// Set power of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="POWER">Power [-100..100%]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_POWER(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> POWER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(POWER ?? throw new ArgumentNullException(nameof(POWER)));
			return new Opcode(OpcodeValue.OUTPUT_POWER, parameterList.ToArray());
		}

		/// <summary>
		/// Set speed of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_SPEED(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> SPEED)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			return new Opcode(OpcodeValue.OUTPUT_SPEED, parameterList.ToArray());
		}

		/// <summary>
		/// Starts the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_START(IExpression<Data8> LAYER, IExpression<Data8> NOS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			return new Opcode(OpcodeValue.OUTPUT_START, parameterList.ToArray());
		}

		/// <summary>
		/// Set polarity of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="POL">Polarity [-1,0,1]</param>
		/// <remarks>
		/// Polarity:
		///   * -1 makes the motor run backward
		///   * 1 makes the motor run forward
		///   * 0 makes the motor run the opposite direction
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_POLARITY(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> POL)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(POL ?? throw new ArgumentNullException(nameof(POL)));
			return new Opcode(OpcodeValue.OUTPUT_POLARITY, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">NO - Output no [0..3]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		/// <param name="TACHO">Tacho pulses [-MAX .. +MAX]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_READ(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> SPEED, IExpression<Data32> TACHO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			parameterList.Add(TACHO ?? throw new ArgumentNullException(nameof(TACHO)));
			return new Opcode(OpcodeValue.OUTPUT_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Testing if output is not used
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="BUSY">Output busy flag (0 = ready, 1 = Busy)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_TEST(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> BUSY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(BUSY ?? throw new ArgumentNullException(nameof(BUSY)));
			return new Opcode(OpcodeValue.OUTPUT_TEST, parameterList.ToArray());
		}

		/// <summary>
		/// Wait for output ready (wait for completion)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <remarks>
		/// cOUTPUT_START command has no effect on this command. Dispatch status can change to BUSYBREAK.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_READY(IExpression<Data8> LAYER, IExpression<Data8> NOS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			return new Opcode(OpcodeValue.OUTPUT_READY, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="POS"></param>
		/// <remarks>
		/// This bytecode is defined but not implemented
		/// </remarks>
		[Support(Official = false, Xtended = false, Compat = false)]
		public static Opcode opOUTPUT_POSITION(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data32> POS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(POS ?? throw new ArgumentNullException(nameof(POS)));
			return new Opcode(OpcodeValue.OUTPUT_POSITION, parameterList.ToArray());
		}

		/// <summary>
		/// Set Ramp up, constant and rampdown steps and power of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="POWER">Power [-100..100%]</param>
		/// <param name="STEP1">Tacho pulses [0..MAX]</param>
		/// <param name="STEP2">Tacho pulses [0..MAX]</param>
		/// <param name="STEP3">Tacho pulses [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_STEP_POWER(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> POWER, IExpression<Data32> STEP1, IExpression<Data32> STEP2, IExpression<Data32> STEP3, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(POWER ?? throw new ArgumentNullException(nameof(POWER)));
			parameterList.Add(STEP1 ?? throw new ArgumentNullException(nameof(STEP1)));
			parameterList.Add(STEP2 ?? throw new ArgumentNullException(nameof(STEP2)));
			parameterList.Add(STEP3 ?? throw new ArgumentNullException(nameof(STEP3)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_STEP_POWER, parameterList.ToArray());
		}

		/// <summary>
		/// Set Ramp up, constant and rampdown steps and power of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="POWER">Power [-100..100%]</param>
		/// <param name="TIME1">Time in Ms [0..MAX]</param>
		/// <param name="TIME2">Time in Ms [0..MAX]</param>
		/// <param name="TIME3">Time in Ms [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_TIME_POWER(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> POWER, IExpression<Data32> TIME1, IExpression<Data32> TIME2, IExpression<Data32> TIME3, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(POWER ?? throw new ArgumentNullException(nameof(POWER)));
			parameterList.Add(TIME1 ?? throw new ArgumentNullException(nameof(TIME1)));
			parameterList.Add(TIME2 ?? throw new ArgumentNullException(nameof(TIME2)));
			parameterList.Add(TIME3 ?? throw new ArgumentNullException(nameof(TIME3)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_TIME_POWER, parameterList.ToArray());
		}

		/// <summary>
		/// Set Ramp up, constant and rampdown steps and power of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		/// <param name="STEP1">Tacho pulses [0..MAX]</param>
		/// <param name="STEP2">Tacho pulses [0..MAX]</param>
		/// <param name="STEP3">Tacho pulses [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_STEP_SPEED(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> SPEED, IExpression<Data32> STEP1, IExpression<Data32> STEP2, IExpression<Data32> STEP3, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			parameterList.Add(STEP1 ?? throw new ArgumentNullException(nameof(STEP1)));
			parameterList.Add(STEP2 ?? throw new ArgumentNullException(nameof(STEP2)));
			parameterList.Add(STEP3 ?? throw new ArgumentNullException(nameof(STEP3)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_STEP_SPEED, parameterList.ToArray());
		}

		/// <summary>
		/// Set Ramp up, constant and rampdown steps and power of the outputs
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		/// <param name="TIME1">Time in Ms [0..MAX]</param>
		/// <param name="TIME2">Time in Ms [0..MAX]</param>
		/// <param name="TIME3">Time in Ms [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_TIME_SPEED(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> SPEED, IExpression<Data32> TIME1, IExpression<Data32> TIME2, IExpression<Data32> TIME3, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			parameterList.Add(TIME1 ?? throw new ArgumentNullException(nameof(TIME1)));
			parameterList.Add(TIME2 ?? throw new ArgumentNullException(nameof(TIME2)));
			parameterList.Add(TIME3 ?? throw new ArgumentNullException(nameof(TIME3)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_TIME_SPEED, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		/// <param name="TURN">Turn Ratio [-200..200]</param>
		/// <param name="STEP">Tacho Pulses [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_STEP_SYNC(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> SPEED, IExpression<Data16> TURN, IExpression<Data32> STEP, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			parameterList.Add(TURN ?? throw new ArgumentNullException(nameof(TURN)));
			parameterList.Add(STEP ?? throw new ArgumentNullException(nameof(STEP)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_STEP_SYNC, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="SPEED">Speed [-100..100%]</param>
		/// <param name="TURN">Turn Ratio [-200..200]</param>
		/// <param name="TIME">Time in ms [0..MAX]</param>
		/// <param name="BRAKE">0 = Coast, 1 = BRAKE</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_TIME_SYNC(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data8> SPEED, IExpression<Data16> TURN, IExpression<Data32> TIME, IExpression<Data8> BRAKE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(SPEED ?? throw new ArgumentNullException(nameof(SPEED)));
			parameterList.Add(TURN ?? throw new ArgumentNullException(nameof(TURN)));
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(BRAKE ?? throw new ArgumentNullException(nameof(BRAKE)));
			return new Opcode(OpcodeValue.OUTPUT_TIME_SYNC, parameterList.ToArray());
		}

		/// <summary>
		/// Clearing tacho count when used as sensor
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_CLR_COUNT(IExpression<Data8> LAYER, IExpression<Data8> NOS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			return new Opcode(OpcodeValue.OUTPUT_CLR_COUNT, parameterList.ToArray());
		}

		/// <summary>
		/// Getting tacho count when used as sensor - values are in shared memory
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NOS">Output bit field [0x00..0x0F]</param>
		/// <param name="TACHO">Tacho pulses [-MAX .. +MAX]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_GET_COUNT(IExpression<Data8> LAYER, IExpression<Data8> NOS, IExpression<Data32> TACHO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NOS ?? throw new ArgumentNullException(nameof(NOS)));
			parameterList.Add(TACHO ?? throw new ArgumentNullException(nameof(TACHO)));
			return new Opcode(OpcodeValue.OUTPUT_GET_COUNT, parameterList.ToArray());
		}

		/// <summary>
		/// Program stop
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opOUTPUT_PRG_STOP()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.OUTPUT_PRG_STOP, parameterList.ToArray());
		}

		/// <summary>
		/// Memory file entry
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opFILE(cmdFILE CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.FILE, parameterList.ToArray());
		}

		/// <summary>
		/// Array entry
		/// </summary>
		/// <remarks>
		/// Dispatch status can change to BUSYBREAK or FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opARRAY(cmdARRAY CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.ARRAY, parameterList.ToArray());
		}

		/// <summary>
		/// Array element write
		/// </summary>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to first byte to write</param>
		/// <param name="VALUE">Value to write - type depends on type of array</param>
		/// <remarks>
		/// Dispatch status can change to FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opARRAY_WRITE(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.ARRAY_WRITE, parameterList.ToArray());
		}

		/// <summary>
		/// Array element read
		/// </summary>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to first byte to write</param>
		/// <param name="VALUE">Value to read - type depends on type of array</param>
		/// <remarks>
		/// Dispatch status can change to FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opARRAY_READ(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.ARRAY_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Array element append
		/// </summary>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="VALUE">Value (new element) to append - type depends on type of array</param>
		/// <remarks>
		/// Dispatch status can change to FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opARRAY_APPEND(IExpression<Data16> HANDLE, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.ARRAY_APPEND, parameterList.ToArray());
		}

		/// <summary>
		/// Get memory usage
		/// </summary>
		/// <param name="TOTAL">Total memory [KB]</param>
		/// <param name="FREE">Free memory [KB]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMEMORY_USAGE(IExpression<Data32> TOTAL, IExpression<Data32> FREE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TOTAL ?? throw new ArgumentNullException(nameof(TOTAL)));
			parameterList.Add(FREE ?? throw new ArgumentNullException(nameof(FREE)));
			return new Opcode(OpcodeValue.MEMORY_USAGE, parameterList.ToArray());
		}

		/// <summary>
		/// Memory filename entry
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opFILENAME(cmdFILENAME CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.FILENAME, parameterList.ToArray());
		}

		/// <summary>
		/// Read 8 bit value from SOURCE[INDEX] to DESTINATION
		/// </summary>
		/// <param name="SOURCE">First value in array of values</param>
		/// <param name="INDEX">Index to array member to read</param>
		/// <param name="DESTINATION">Variable to receive read value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opREAD8(IExpression<Data8> SOURCE, IExpression<Data8> INDEX, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.READ8, parameterList.ToArray());
		}

		/// <summary>
		/// Read 16 bit value from SOURCE[INDEX] to DESTINATION
		/// </summary>
		/// <param name="SOURCE">First value in array of values</param>
		/// <param name="INDEX">Index to array member to read</param>
		/// <param name="DESTINATION">Variable to receive read value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opREAD16(IExpression<Data16> SOURCE, IExpression<Data8> INDEX, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.READ16, parameterList.ToArray());
		}

		/// <summary>
		/// Read 32 bit value from SOURCE[INDEX] to DESTINATION
		/// </summary>
		/// <param name="SOURCE">First value in array of values</param>
		/// <param name="INDEX">Index to array member to read</param>
		/// <param name="DESTINATION">Variable to receive read value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opREAD32(IExpression<Data32> SOURCE, IExpression<Data8> INDEX, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.READ32, parameterList.ToArray());
		}

		/// <summary>
		/// Read floating point value from SOURCE[INDEX] to DESTINATION
		/// </summary>
		/// <param name="SOURCE">First value in array of values</param>
		/// <param name="INDEX">Index to array member to read</param>
		/// <param name="DESTINATION">Variable to receive read value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opREADF(IExpression<DataFloat> SOURCE, IExpression<Data8> INDEX, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.READF, parameterList.ToArray());
		}

		/// <summary>
		/// Write 8 bit value from SOURCE to DESTINATION[INDEX]
		/// </summary>
		/// <param name="SOURCE">Variable to write</param>
		/// <param name="INDEX">Index to array member to write</param>
		/// <param name="DESTINATION">Array to receive write value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opWRITE8(IExpression<Data8> SOURCE, IExpression<Data8> INDEX, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.WRITE8, parameterList.ToArray());
		}

		/// <summary>
		/// Write 16 bit value from SOURCE to DESTINATION[INDEX]
		/// </summary>
		/// <param name="SOURCE">Variable to write</param>
		/// <param name="INDEX">Index to array member to write</param>
		/// <param name="DESTINATION">Array to receive write value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opWRITE16(IExpression<Data16> SOURCE, IExpression<Data8> INDEX, IExpression<Data16> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.WRITE16, parameterList.ToArray());
		}

		/// <summary>
		/// Write 32 bit value from SOURCE to DESTINATION[INDEX]
		/// </summary>
		/// <param name="SOURCE">Variable to write</param>
		/// <param name="INDEX">Index to array member to write</param>
		/// <param name="DESTINATION">Array to receive write value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opWRITE32(IExpression<Data32> SOURCE, IExpression<Data8> INDEX, IExpression<Data32> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.WRITE32, parameterList.ToArray());
		}

		/// <summary>
		/// Write floating point value from SOURCE to DESTINATION[INDEX]
		/// </summary>
		/// <param name="SOURCE">Variable to write</param>
		/// <param name="INDEX">Index to array member to write</param>
		/// <param name="DESTINATION">Array to receive write value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opWRITEF(IExpression<DataFloat> SOURCE, IExpression<Data8> INDEX, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new Opcode(OpcodeValue.WRITEF, parameterList.ToArray());
		}

		/// <summary>
		/// Test if communication is busy
		/// </summary>
		/// <param name="HARDWARE">Hardware transport layer</param>
		/// <param name="NAME">Name of the remote/own device</param>
		/// <remarks>
		/// Dispatch status may be set to BUSYBREAK. If name is 0 then own adapter status is evaluated.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_READY(IExpression<Data8> HARDWARE, IExpression<Data8> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new Opcode(OpcodeValue.COM_READY, parameterList.ToArray());
		}

		/// <summary>
		/// This code does not exist in normal program
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to INSTRBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_READDATA(IExpression<Data8> VALUE1, IExpression<Data8> VALUE2, IExpression<Data16> VALUE3, IExpression<Data8> VALUE4)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE1 ?? throw new ArgumentNullException(nameof(VALUE1)));
			parameterList.Add(VALUE2 ?? throw new ArgumentNullException(nameof(VALUE2)));
			parameterList.Add(VALUE3 ?? throw new ArgumentNullException(nameof(VALUE3)));
			parameterList.Add(VALUE4 ?? throw new ArgumentNullException(nameof(VALUE4)));
			return new Opcode(OpcodeValue.COM_READDATA, parameterList.ToArray());
		}

		/// <summary>
		/// This code does not exist in normal program
		/// </summary>
		/// <remarks>
		/// Dispatch status changes to INSTRBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_WRITEDATA(IExpression<Data8> VALUE1, IExpression<Data8> VALUE2, IExpression<Data16> VALUE3, IExpression<Data8> VALUE4)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE1 ?? throw new ArgumentNullException(nameof(VALUE1)));
			parameterList.Add(VALUE2 ?? throw new ArgumentNullException(nameof(VALUE2)));
			parameterList.Add(VALUE3 ?? throw new ArgumentNullException(nameof(VALUE3)));
			parameterList.Add(VALUE4 ?? throw new ArgumentNullException(nameof(VALUE4)));
			return new Opcode(OpcodeValue.COM_WRITEDATA, parameterList.ToArray());
		}

		/// <summary>
		/// Communication get entry
		/// </summary>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_GET(cmdCOM_GET CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.COM_GET, parameterList.ToArray());
		}

		/// <summary>
		/// Communication set entry
		/// </summary>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_SET(cmdCOM_SET CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.COM_SET, parameterList.ToArray());
		}

		/// <summary>
		/// Test if communication is busy
		/// </summary>
		/// <param name="HARDWARE">Hardware transport layer</param>
		/// <param name="NAME">Name of the remote/own device</param>
		/// <param name="BUSY">Busy flag</param>
		/// <remarks>
		/// Dispatch status is set to NOBREAK. If name is 0 then own adapter busy status is returned.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_TEST(IExpression<Data8> HARDWARE, IExpression<Data8> NAME, IExpression<Data8> BUSY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(BUSY ?? throw new ArgumentNullException(nameof(BUSY)));
			return new Opcode(OpcodeValue.COM_TEST, parameterList.ToArray());
		}

		/// <summary>
		/// Removes a know remote device from the brick
		/// </summary>
		/// <param name="HARDWARE"></param>
		/// <param name="REMOTE_NAME">Pointer to remote brick name</param>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_REMOVE(IExpression<Data8> HARDWARE, IExpression<Data8> REMOTE_NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(REMOTE_NAME ?? throw new ArgumentNullException(nameof(REMOTE_NAME)));
			return new Opcode(OpcodeValue.COM_REMOVE, parameterList.ToArray());
		}

		/// <summary>
		/// Sends a file or folder to remote brick.
		/// </summary>
		/// <param name="HARDWARE"></param>
		/// <param name="REMOTE_NAME">Pointer to remote brick name</param>
		/// <param name="FILE_NAME">File/folder name to send</param>
		/// <param name="FILE_TYPE">File or folder type to send</param>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opCOM_WRITEFILE(IExpression<Data8> HARDWARE, IExpression<Data8> REMOTE_NAME, IExpression<Data8> FILE_NAME, IExpression<Data8> FILE_TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(REMOTE_NAME ?? throw new ArgumentNullException(nameof(REMOTE_NAME)));
			parameterList.Add(FILE_NAME ?? throw new ArgumentNullException(nameof(FILE_NAME)));
			parameterList.Add(FILE_TYPE ?? throw new ArgumentNullException(nameof(FILE_TYPE)));
			return new Opcode(OpcodeValue.COM_WRITEFILE, parameterList.ToArray());
		}

		/// <summary>
		/// Open a mail box on the brick
		/// </summary>
		/// <param name="NO">Reference ID for the mailbox. Maximum number of mailboxes is 30</param>
		/// <param name="BOXNAME">Zero terminated string with the mailbox name</param>
		/// <param name="TYPES">Data type of the content of the mailbox</param>
		/// <param name="FIFOSIZE">Not used</param>
		/// <param name="VALUES">Number of values of the type (specified by TYPE).</param>
		/// <remarks>
		/// If data type DATA_S is selected then it requires that a zero terminated string is sent. Maximum mailbox size is 250 bytes. I.e. if type is string (DATA_S) then there can only be 1 string of maximum 250 bytes (incl. zero termination), or if array (DATA_A), then array size cannot be larger than 250 bytes.
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_OPEN(IExpression<Data8> NO, IExpression<Data8> BOXNAME, IExpression<Data8> TYPES, IExpression<Data8> FIFOSIZE, IExpression<Data8> VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(BOXNAME ?? throw new ArgumentNullException(nameof(BOXNAME)));
			parameterList.Add(TYPES ?? throw new ArgumentNullException(nameof(TYPES)));
			parameterList.Add(FIFOSIZE ?? throw new ArgumentNullException(nameof(FIFOSIZE)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new Opcode(OpcodeValue.MAILBOX_OPEN, parameterList.ToArray());
		}

		/// <summary>
		/// Write to mailbox in remote brick
		/// </summary>
		/// <param name="BRICKNAME">Zero terminated string name of the receiving brick</param>
		/// <param name="HARDWARE">Transportation media</param>
		/// <param name="BOXNAME">Zero terminated string name of the receiving mailbox</param>
		/// <param name="TYPE">Data type of the values</param>
		/// <param name="VALUES">Number of values of the specified type to send</param>
		/// <param name="VALUES_">variable arguments</param>
		/// <remarks>
		/// If Brick name is left empty (0) then all connected devices will receive the mailbox message. If string type (DATA_S) data is to be transmitted then a zero terminated string is expected. If array type data (DATA_A) is to be transmitted then the number of bytes to be sent is equal to the array size.
		/// Dispatch status can return FAILBREAK.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_WRITE(IExpression<Data8> BRICKNAME, IExpression<Data8> HARDWARE, IExpression<Data8> BOXNAME, IExpression<Data8> TYPE, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BRICKNAME ?? throw new ArgumentNullException(nameof(BRICKNAME)));
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(BOXNAME ?? throw new ArgumentNullException(nameof(BOXNAME)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new Opcode(OpcodeValue.MAILBOX_WRITE, parameterList.ToArray());
		}

		/// <summary>
		/// Read data from mailbox specified by NO
		/// </summary>
		/// <param name="NO">Messagebox ID of the message box you want to read</param>
		/// <param name="LENGTH">Maximum bytes to be read</param>
		/// <param name="VALUES">Number of value to read</param>
		/// <param name="VALUES_">variable arguments</param>
		/// <remarks>
		/// Returns (Type specified in open) VALUE - Data from the message box The type of Value is specified by mailbox open byte code.
		/// Dispatch status can return FAILBREAK.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_READ(IExpression<Data8> NO, IExpression<Data8> LENGTH, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new Opcode(OpcodeValue.MAILBOX_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Tests if new message has been read
		/// </summary>
		/// <param name="NO">Reference ID mailbox number</param>
		/// <param name="BUSY">If Busy = TRUE then no new messages are received</param>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_TEST(IExpression<Data8> NO, IExpression<Data8> BUSY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(BUSY ?? throw new ArgumentNullException(nameof(BUSY)));
			return new Opcode(OpcodeValue.MAILBOX_TEST, parameterList.ToArray());
		}

		/// <summary>
		/// Waiting from message to be read
		/// </summary>
		/// <param name="NO">Reference ID mailbox number</param>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_READY(IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new Opcode(OpcodeValue.MAILBOX_READY, parameterList.ToArray());
		}

		/// <summary>
		/// Closes mailbox indicated by NO
		/// </summary>
		/// <param name="NO">Reference ID mailbox number</param>
		/// <remarks>
		/// Dispatch status can return FAILBREAK
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_CLOSE(IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new Opcode(OpcodeValue.MAILBOX_CLOSE, parameterList.ToArray());
		}

		/// <summary>
		/// Set the connection type for a specific port
		/// </summary>
		/// <param name="LAYER">Chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="CONN">Connection type (CONN_NXT_IIC, CONN_NXT_DUMB or CONN_INPUT_DUMB)</param>
		/// <remarks>
		/// Note that this won't do much if the auto-id has not been disabled
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opINPUT_SET_CONN(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> CONN)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(CONN ?? throw new ArgumentNullException(nameof(CONN)));
			return new Opcode(OpcodeValue.INPUT_SET_CONN, parameterList.ToArray());
		}

		/// <summary>
		/// Read I2C data from specified port
		/// </summary>
		/// <param name="LAYER">Chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="RDLNG">No of bytes to read</param>
		/// <param name="RDDATA">DATA8 array (handle) to read into</param>
		/// <param name="RESULT">Write/read result (OK, FAIL, BUSY, STOP)</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opINPUT_IIC_READ(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> RDLNG, IExpression<Data8> RDDATA, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(RDLNG ?? throw new ArgumentNullException(nameof(RDLNG)));
			parameterList.Add(RDDATA ?? throw new ArgumentNullException(nameof(RDDATA)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.INPUT_IIC_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Read I2C status of specified port
		/// </summary>
		/// <param name="LAYER">Chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="RESULT">Current I2C bus status (OK, FAIL, BUSY, STOP)</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opINPUT_IIC_STATUS(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.INPUT_IIC_STATUS, parameterList.ToArray());
		}

		/// <summary>
		/// Write I2C data to specified port
		/// </summary>
		/// <param name="LAYER">Chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="WRLNG">No of bytes to write</param>
		/// <param name="WRDATA">DATA8 array (handle) of data to write</param>
		/// <param name="RDLNG">No of bytes to read</param>
		/// <param name="RESULT">Write/read result (OK, FAIL, BUSY, STOP)</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opINPUT_IIC_WRITE(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> WRLNG, IExpression<Data8> WRDATA, IExpression<Data8> RDLNG, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(WRLNG ?? throw new ArgumentNullException(nameof(WRLNG)));
			parameterList.Add(WRDATA ?? throw new ArgumentNullException(nameof(WRDATA)));
			parameterList.Add(RDLNG ?? throw new ArgumentNullException(nameof(RDLNG)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.INPUT_IIC_WRITE, parameterList.ToArray());
		}

		/// <summary>
		/// Enabled or disable auto-id for a specific sensor port
		/// </summary>
		/// <param name="LAYER">Chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="ENABLE">Boolean (0 disabled, 1 enable)</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opINPUT_SET_AUTOID(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> ENABLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(ENABLE ?? throw new ArgumentNullException(nameof(ENABLE)));
			return new Opcode(OpcodeValue.INPUT_SET_AUTOID, parameterList.ToArray());
		}

		/// <summary>
		/// Returns the size of the mailbox.
		/// </summary>
		/// <param name="NO">Reference ID mailbox number</param>
		/// <param name="SIZE">Size in bytes of the contents of mailbox NO</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opMAILBOX_SIZE(IExpression<Data8> NO, IExpression<Data8> SIZE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			return new Opcode(OpcodeValue.MAILBOX_SIZE, parameterList.ToArray());
		}

		/// <summary>
		/// Get md5 sum of a file
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="MD5SUM">First byte in md5 sum (byte array)</param>
		/// <param name="SUCCESS">Success flag (0 = no, 1 = yes)</param>
		/// <remarks>
		/// Dispatch status unchanged
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opFILE_MD5SUM(IExpression<DataString> NAME, IExpression<Data8> MD5SUM, IExpression<Data8> SUCCESS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(MD5SUM ?? throw new ArgumentNullException(nameof(MD5SUM)));
			parameterList.Add(SUCCESS ?? throw new ArgumentNullException(nameof(SUCCESS)));
			return new Opcode(OpcodeValue.FILE_MD5SUM, parameterList.ToArray());
		}

		/// <summary>
		/// Load the selected VM
		/// </summary>
		/// <param name="VMINDEX">VM Index, Robotc = 0, Labview = 1</param>
		/// <param name="RESULT">OK if VM loaded ok FAIL if it did not.</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_VMLOAD(IExpression<Data8> VMINDEX, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VMINDEX ?? throw new ArgumentNullException(nameof(VMINDEX)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.DYNLOAD_VMLOAD, parameterList.ToArray());
		}

		/// <summary>
		/// Clean up the dynamic VM loading system
		/// </summary>
		/// <remarks>
		/// Calls the VM's exit_vm() function to tidy up
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_VMEXIT()
		{
			var parameterList = new List<IByteCode>();
			return new Opcode(OpcodeValue.DYNLOAD_VMEXIT, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 0 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_0(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_0, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 1 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_1(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_1, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 2 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_2(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_2, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 3 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_3(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_3, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 4 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_4(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_4, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 5 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_5(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_5, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 6 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_6(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_6, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 7 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_7(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_7, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 8 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_8(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_8, parameterList.ToArray());
		}

		/// <summary>
		/// Execute Entry Point function 9 in Third Party VM
		/// </summary>
		/// <param name="CMD">Sub command to be executed</param>
		/// <param name="LENGTH_IN">Amount of data passed to this opcode</param>
		/// <param name="LENGTH_OUT">Amount of data returned</param>
		/// <param name="VALUE">Data from opcode</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_ENTRY_9(IExpression<Data8> CMD, IExpression<Data8> LENGTH_IN, IExpression<Data16> LENGTH_OUT, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			parameterList.Add(LENGTH_IN ?? throw new ArgumentNullException(nameof(LENGTH_IN)));
			parameterList.Add(LENGTH_OUT ?? throw new ArgumentNullException(nameof(LENGTH_OUT)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new Opcode(OpcodeValue.DYNLOAD_ENTRY_9, parameterList.ToArray());
		}

		/// <summary>
		/// Get the index of the currently loaded VM
		/// </summary>
		/// <param name="RESULT">VM Index, Robotc = 0, Labview = 1, -1 for no loaded VM</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static Opcode opDYNLOAD_GET_VM(IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new Opcode(OpcodeValue.DYNLOAD_GET_VM, parameterList.ToArray());
		}

		/// <summary>
		/// System test functions entry
		/// </summary>
		/// <remarks>
		/// This set of commands are for test only as they change behaviour in some driver modules. When test is open every command keeps the test byte codes enabled for 10 seconds.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static Opcode opTST(cmdTST CMD)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CMD ?? throw new ArgumentNullException(nameof(CMD)));
			return new Opcode(OpcodeValue.TST, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="OBJID">Object id</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdOBJ_STOP(IExpression<Data16> PRGID, IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.OBJ_STOP, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="OBJID">Object id</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdOBJ_START(IExpression<Data16> PRGID, IExpression<Data16> OBJID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(OBJID ?? throw new ArgumentNullException(nameof(OBJID)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.OBJ_START, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="DATA">Program status</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdGET_STATUS(IExpression<Data16> PRGID, IExpression<Data8> DATA)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(DATA ?? throw new ArgumentNullException(nameof(DATA)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.GET_STATUS, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="DATA">Program speed [instr/S]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdGET_SPEED(IExpression<Data16> PRGID, IExpression<Data32> DATA)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(DATA ?? throw new ArgumentNullException(nameof(DATA)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.GET_SPEED, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="DATA">Program result [OK, BUSY, FAIL]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdGET_PRGRESULT(IExpression<Data16> PRGID, IExpression<Data8> DATA)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(DATA ?? throw new ArgumentNullException(nameof(DATA)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.GET_PRGRESULT, parameterList.ToArray());
		}

		/// <summary>
		/// Set number of instructions before VMThread change
		/// </summary>
		/// <param name="PRGID">Program slot number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdSET_INSTR(IExpression<Data16> PRGID)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.SET_INSTR, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number</param>
		/// <param name="NAME">Program name</param>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static cmdPROGRAM_INFO cmdGET_PRGNAME(IExpression<Data16> PRGID, IExpression<Data8> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdPROGRAM_INFO(cmdPROGRAM_INFOValue.GET_PRGNAME, parameterList.ToArray());
		}

		/// <param name="NUMBER">Error number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdSET_ERROR(IExpression<Data8> NUMBER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NUMBER ?? throw new ArgumentNullException(nameof(NUMBER)));
			return new cmdINFO(cmdINFOValue.SET_ERROR, parameterList.ToArray());
		}

		/// <param name="NUMBER">Error number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdGET_ERROR(IExpression<Data8> NUMBER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NUMBER ?? throw new ArgumentNullException(nameof(NUMBER)));
			return new cmdINFO(cmdINFOValue.GET_ERROR, parameterList.ToArray());
		}

		/// <summary>
		/// Convert error number to text string
		/// </summary>
		/// <param name="NUMBER">Error number</param>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">Message</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdERRORTEXT(IExpression<Data8> NUMBER, IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NUMBER ?? throw new ArgumentNullException(nameof(NUMBER)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdINFO(cmdINFOValue.ERRORTEXT, parameterList.ToArray());
		}

		/// <param name="VALUE">Volume [0..100%]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdGET_VOLUME(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINFO(cmdINFOValue.GET_VOLUME, parameterList.ToArray());
		}

		/// <param name="VALUE">Volume [0..100%]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdSET_VOLUME(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINFO(cmdINFOValue.SET_VOLUME, parameterList.ToArray());
		}

		/// <param name="VALUE">Minutes to sleep [0..120min] (0 = never)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdGET_MINUTES(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINFO(cmdINFOValue.GET_MINUTES, parameterList.ToArray());
		}

		/// <param name="VALUE">Minutes to sleep [0..120min] (0 = never)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINFO cmdSET_MINUTES(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINFO(cmdINFOValue.SET_MINUTES, parameterList.ToArray());
		}

		/// <summary>
		/// Get size of string (not including zero termination)
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="SIZE">Size</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdGET_SIZE(IExpression<DataString> SOURCE1, IExpression<Data16> SIZE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			return new cmdSTRINGS(cmdSTRINGSValue.GET_SIZE, parameterList.ToArray());
		}

		/// <summary>
		/// Add two strings (SOURCE1 + SOURCE2 -> DESTINATION)
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="SOURCE2">String variable or handle to string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdADD(IExpression<DataString> SOURCE1, IExpression<DataString> SOURCE2, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.ADD, parameterList.ToArray());
		}

		/// <summary>
		/// Compare two strings
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="SOURCE2">String variable or handle to string</param>
		/// <param name="RESULT">Result (0 = not equal, 1 = equal)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdCOMPARE(IExpression<DataString> SOURCE1, IExpression<DataString> SOURCE2, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new cmdSTRINGS(cmdSTRINGSValue.COMPARE, parameterList.ToArray());
		}

		/// <summary>
		/// Duplicate a string (SOURCE1 -> DESTINATION)
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdDUPLICATE(IExpression<DataString> SOURCE1, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.DUPLICATE, parameterList.ToArray());
		}

		/// <summary>
		/// Convert floating point value to a string (strips trailing zeroes)
		/// </summary>
		/// <param name="VALUE">Value to write (if "nan" op to 4 dashes is returned: "----")</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point (FIGURES < 0 -> Left adjusted)</param>
		/// <param name="DECIMALS">Number of decimals</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdVALUE_TO_STRING(IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.VALUE_TO_STRING, parameterList.ToArray());
		}

		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="DESTINATION">Value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdSTRING_TO_VALUE(IExpression<DataString> SOURCE1, IExpression<DataFloat> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.STRING_TO_VALUE, parameterList.ToArray());
		}

		/// <summary>
		/// Strip a string for spaces (SOURCE1 -> DESTINATION)
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdSTRIP(IExpression<DataString> SOURCE1, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.STRIP, parameterList.ToArray());
		}

		/// <summary>
		/// Convert integer value to a string
		/// </summary>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdNUMBER_TO_STRING(IExpression<Data16> VALUE, IExpression<Data8> FIGURES, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.NUMBER_TO_STRING, parameterList.ToArray());
		}

		/// <summary>
		/// Return DESTINATION: a substring from SOURCE1 that starts were SOURCE2 ends
		/// </summary>
		/// <param name="SOURCE1">String variable or handle to string</param>
		/// <param name="SOURCE2">String variable or handle to string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdSUB(IExpression<DataString> SOURCE1, IExpression<DataString> SOURCE2, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE1 ?? throw new ArgumentNullException(nameof(SOURCE1)));
			parameterList.Add(SOURCE2 ?? throw new ArgumentNullException(nameof(SOURCE2)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.SUB, parameterList.ToArray());
		}

		/// <summary>
		/// Convert floating point value to a formatted string
		/// </summary>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FORMAT">Format string variable or handle to string</param>
		/// <param name="SIZE">Total size of destination string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdVALUE_FORMATTED(IExpression<DataFloat> VALUE, IExpression<DataString> FORMAT, IExpression<Data8> SIZE, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FORMAT ?? throw new ArgumentNullException(nameof(FORMAT)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.VALUE_FORMATTED, parameterList.ToArray());
		}

		/// <summary>
		/// Convert integer number to a formatted string
		/// </summary>
		/// <param name="VALUE">Number to write</param>
		/// <param name="FORMAT">Format string variable or handle to string</param>
		/// <param name="SIZE">Total size of destination string</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSTRINGS cmdNUMBER_FORMATTED(IExpression<Data32> VALUE, IExpression<DataString> FORMAT, IExpression<Data8> SIZE, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FORMAT ?? throw new ArgumentNullException(nameof(FORMAT)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdSTRINGS(cmdSTRINGSValue.NUMBER_FORMATTED, parameterList.ToArray());
		}

		/// <param name="VALUE">Battery voltage [V]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_VBATT(IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.GET_VBATT, parameterList.ToArray());
		}

		/// <param name="VALUE">Battery current [A]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_IBATT(IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.GET_IBATT, parameterList.ToArray());
		}

		/// <summary>
		/// Get os version string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_OS_VERS(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_OS_VERS, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_EVENT(IExpression<Data8> EVENT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(EVENT ?? throw new ArgumentNullException(nameof(EVENT)));
			return new cmdUI_READ(cmdUI_READValue.GET_EVENT, parameterList.ToArray());
		}

		/// <param name="VALUE">Battery temperature rise [C]</param>
		/// <remarks>
		/// This returns 0 on all known hardware. The EV3 has code to estimate battery temperature, but it is disabled.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_TBATT(IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.GET_TBATT, parameterList.ToArray());
		}

		/// <param name="IINT">Integrated battery current [A]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_IINT(IExpression<DataFloat> IINT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(IINT ?? throw new ArgumentNullException(nameof(IINT)));
			return new cmdUI_READ(cmdUI_READValue.GET_IINT, parameterList.ToArray());
		}

		/// <param name="VALUE">Motor current [A]</param>
		/// <remarks>
		/// Only pre-release EV3 hardware returns a real value. Returns 0 on all known devices (they lack the necessary hardware).
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_IMOTOR(IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.GET_IMOTOR, parameterList.ToArray());
		}

		/// <summary>
		/// Get string from terminal
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_STRING(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_STRING, parameterList.ToArray());
		}

		/// <summary>
		/// Get hardware version string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_HW_VERS(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_HW_VERS, parameterList.ToArray());
		}

		/// <summary>
		/// Get firmware version string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_FW_VERS(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_FW_VERS, parameterList.ToArray());
		}

		/// <summary>
		/// Get firmware build string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_FW_BUILD(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_FW_BUILD, parameterList.ToArray());
		}

		/// <summary>
		/// Get os build string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_OS_BUILD(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_OS_BUILD, parameterList.ToArray());
		}

		/// <param name="VALUE">Address from lms_cmdin</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_ADDRESS(IExpression<Data32> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.GET_ADDRESS, parameterList.ToArray());
		}

		/// <param name="LENGTH">Maximal code stream length</param>
		/// <param name="IMAGE">Address of image</param>
		/// <param name="GLOBAL">Address of global variables</param>
		/// <param name="FLAG">Flag tells if image is ready</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_CODE(IExpression<Data32> LENGTH, IExpression<Data32> IMAGE, IExpression<Data32> GLOBAL, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(IMAGE ?? throw new ArgumentNullException(nameof(IMAGE)));
			parameterList.Add(GLOBAL ?? throw new ArgumentNullException(nameof(GLOBAL)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new cmdUI_READ(cmdUI_READValue.GET_CODE, parameterList.ToArray());
		}

		/// <param name="VALUE">Key value from lms_cmdin (0 = no key)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdKEY(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_READ(cmdUI_READValue.KEY, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_SHUTDOWN(IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new cmdUI_READ(cmdUI_READValue.GET_SHUTDOWN, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_WARNING(IExpression<Data8> WARNINGS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(WARNINGS ?? throw new ArgumentNullException(nameof(WARNINGS)));
			return new cmdUI_READ(cmdUI_READValue.GET_WARNING, parameterList.ToArray());
		}

		/// <summary>
		/// Get battery level in %
		/// </summary>
		/// <param name="PCT">Battery level [0..100]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_LBATT(IExpression<Data8> PCT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PCT ?? throw new ArgumentNullException(nameof(PCT)));
			return new cmdUI_READ(cmdUI_READValue.GET_LBATT, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdTEXTBOX_READ(IExpression<Data8> TEXT, IExpression<Data32> SIZE, IExpression<Data8> DEL, IExpression<Data8> LENGTH, IExpression<Data16> LINE, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TEXT ?? throw new ArgumentNullException(nameof(TEXT)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(LINE ?? throw new ArgumentNullException(nameof(LINE)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.TEXTBOX_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Get version string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_VERSION(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_VERSION, parameterList.ToArray());
		}

		/// <summary>
		/// Get IP address string
		/// </summary>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_IP(IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdUI_READ(cmdUI_READValue.GET_IP, parameterList.ToArray());
		}

		/// <param name="VBATT">Battery voltage [V]</param>
		/// <param name="IBATT">Battery current [A]</param>
		/// <param name="IINT">Integrated battery current [A]</param>
		/// <param name="IMOTOR">Motor current [A]</param>
		/// <remarks>
		/// All known hardware returns 0 for IMOTOR.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_POWER(IExpression<DataFloat> VBATT, IExpression<DataFloat> IBATT, IExpression<DataFloat> IINT, IExpression<DataFloat> IMOTOR)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VBATT ?? throw new ArgumentNullException(nameof(VBATT)));
			parameterList.Add(IBATT ?? throw new ArgumentNullException(nameof(IBATT)));
			parameterList.Add(IINT ?? throw new ArgumentNullException(nameof(IINT)));
			parameterList.Add(IMOTOR ?? throw new ArgumentNullException(nameof(IMOTOR)));
			return new cmdUI_READ(cmdUI_READValue.GET_POWER, parameterList.ToArray());
		}

		/// <param name="STATE">SD card present [0..1]</param>
		/// <param name="TOTAL">Kbytes in total</param>
		/// <param name="FREE">Kbytes free</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_SDCARD(IExpression<Data8> STATE, IExpression<Data32> TOTAL, IExpression<Data32> FREE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			parameterList.Add(TOTAL ?? throw new ArgumentNullException(nameof(TOTAL)));
			parameterList.Add(FREE ?? throw new ArgumentNullException(nameof(FREE)));
			return new cmdUI_READ(cmdUI_READValue.GET_SDCARD, parameterList.ToArray());
		}

		/// <param name="STATE">USB stick present [0..1]</param>
		/// <param name="TOTAL">Kbytes in total</param>
		/// <param name="FREE">Kbytes free</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_READ cmdGET_USBSTICK(IExpression<Data8> STATE, IExpression<Data32> TOTAL, IExpression<Data32> FREE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			parameterList.Add(TOTAL ?? throw new ArgumentNullException(nameof(TOTAL)));
			parameterList.Add(FREE ?? throw new ArgumentNullException(nameof(FREE)));
			return new cmdUI_READ(cmdUI_READValue.GET_USBSTICK, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdWRITE_FLUSH()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_WRITE(cmdUI_WRITEValue.WRITE_FLUSH, parameterList.ToArray());
		}

		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point</param>
		/// <param name="DECIMALS">Number of decimals</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdFLOATVALUE(IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.FLOATVALUE, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdSTAMP(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.STAMP, parameterList.ToArray());
		}

		/// <param name="STRING">String</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdPUT_STRING(IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.PUT_STRING, parameterList.ToArray());
		}

		/// <param name="VALUE">Value to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdVALUE8(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.VALUE8, parameterList.ToArray());
		}

		/// <param name="VALUE">Value to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdVALUE16(IExpression<Data16> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.VALUE16, parameterList.ToArray());
		}

		/// <param name="VALUE">Value to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdVALUE32(IExpression<Data32> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.VALUE32, parameterList.ToArray());
		}

		/// <param name="VALUE">Value to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdVALUEF(IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.VALUEF, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdADDRESS(IExpression<Data32> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.ADDRESS, parameterList.ToArray());
		}

		/// <param name="ARRAY">First byte in byte array to write</param>
		/// <param name="LENGTH">Length of array</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdCODE(IExpression<Data8> ARRAY, IExpression<Data32> LENGTH)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.CODE, parameterList.ToArray());
		}

		/// <summary>
		/// Send to brick when file down load is completed (plays sound and updates the UI browser)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdDOWNLOAD_END()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_WRITE(cmdUI_WRITEValue.DOWNLOAD_END, parameterList.ToArray());
		}

		/// <summary>
		/// Set or clear screen block status (if screen blocked - all graphical screen action are disabled)
		/// </summary>
		/// <param name="STATUS">Value [0 = normal,1 = blocked]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdSCREEN_BLOCK(IExpression<Data8> STATUS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATUS ?? throw new ArgumentNullException(nameof(STATUS)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.SCREEN_BLOCK, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdALLOW_PULSE(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.ALLOW_PULSE, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdSET_PULSE(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.SET_PULSE, parameterList.ToArray());
		}

		/// <summary>
		/// Append line of text at the bottom of a text box
		/// </summary>
		/// <param name="TEXT">Text box text (must be zero terminated)</param>
		/// <param name="SIZE">Maximal text size (including zero termination)</param>
		/// <param name="DEL">Delimiter code</param>
		/// <param name="SOURCE">String variable or handle to string to append</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdTEXTBOX_APPEND(IExpression<DataString> TEXT, IExpression<Data32> SIZE, IExpression<Data8> DEL, IExpression<DataString> SOURCE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TEXT ?? throw new ArgumentNullException(nameof(TEXT)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.TEXTBOX_APPEND, parameterList.ToArray());
		}

		/// <param name="VALUE">Value [0,1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdSET_BUSY(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.SET_BUSY, parameterList.ToArray());
		}

		/// <param name="STATE">Value [0 = low,1 = high]</param>
		/// <remarks>
		/// This was only available on pre-release EV3 hardware.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdSET_TESTPIN(IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.SET_TESTPIN, parameterList.ToArray());
		}

		/// <summary>
		/// Start the "Mindstorms" "run" screen
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdINIT_RUN()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_WRITE(cmdUI_WRITEValue.INIT_RUN, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdUPDATE_RUN()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_WRITE(cmdUI_WRITEValue.UPDATE_RUN, parameterList.ToArray());
		}

		/// <param name="PATTERN">LED Pattern</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdLED(IExpression<Data8> PATTERN)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PATTERN ?? throw new ArgumentNullException(nameof(PATTERN)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.LED, parameterList.ToArray());
		}

		/// <param name="VALUE">Value [0,1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdPOWER(IExpression<Data8> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.POWER, parameterList.ToArray());
		}

		/// <summary>
		/// Update tick to scroll graph horizontally in memory when drawing graph in "scope" mode
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdGRAPH_SAMPLE()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_WRITE(cmdUI_WRITEValue.GRAPH_SAMPLE, parameterList.ToArray());
		}

		/// <param name="STATE">Value [0 = Off,1 = On]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_WRITE cmdTERMINAL(IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_WRITE(cmdUI_WRITEValue.TERMINAL, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been pressed (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdSHORTPRESS(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.SHORTPRESS, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been pressed (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdLONGPRESS(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.LONGPRESS, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdWAIT_FOR_PRESS()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.WAIT_FOR_PRESS, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdFLUSH()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.FLUSH, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdPRESS(IExpression<Data8> BUTTON)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.PRESS, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdRELEASE(IExpression<Data8> BUTTON)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.RELEASE, parameterList.ToArray());
		}

		/// <param name="VALUE">Horizontal arrows data (-1 = left, +1 = right, 0 = not pressed)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdGET_HORZ(IExpression<Data16> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_HORZ, parameterList.ToArray());
		}

		/// <param name="VALUE">Vertical arrows data (-1 = up, +1 = down, 0 = not pressed)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdGET_VERT(IExpression<Data16> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_VERT, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button is pressed (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdPRESSED(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.PRESSED, parameterList.ToArray());
		}

		/// <param name="BLOCKED">Set UI back button blocked flag (0 = not blocked, 1 = blocked)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdSET_BACK_BLOCK(IExpression<Data8> BLOCKED)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BLOCKED ?? throw new ArgumentNullException(nameof(BLOCKED)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.SET_BACK_BLOCK, parameterList.ToArray());
		}

		/// <param name="BLOCKED">Get UI back button blocked flag (0 = not blocked, 1 = blocked)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdGET_BACK_BLOCK(IExpression<Data8> BLOCKED)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BLOCKED ?? throw new ArgumentNullException(nameof(BLOCKED)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_BACK_BLOCK, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been hold down(0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdTESTSHORTPRESS(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.TESTSHORTPRESS, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been hold down(0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdTESTLONGPRESS(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.TESTLONGPRESS, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been pressed (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = false)]
		public static cmdUI_BUTTON cmdGET_BUMBED(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_BUMBED, parameterList.ToArray());
		}

		/// <param name="BUTTON"></param>
		/// <param name="STATE">Button has been pressed (0 = no, 1 = yes)</param>
		/// <remarks>
		/// Renamed from GET_BUMBED
		/// </remarks>
		[Support(Official = false, Xtended = false, Compat = true)]
		public static cmdUI_BUTTON cmdGET_BUMPED(IExpression<Data8> BUTTON, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BUTTON ?? throw new ArgumentNullException(nameof(BUTTON)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_BUMPED, parameterList.ToArray());
		}

		/// <summary>
		/// Get and clear click sound request (internal use only)
		/// </summary>
		/// <param name="CLICK">Click sound request (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_BUTTON cmdGET_CLICK(IExpression<Data8> CLICK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(CLICK ?? throw new ArgumentNullException(nameof(CLICK)));
			return new cmdUI_BUTTON(cmdUI_BUTTONValue.GET_CLICK, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdUPDATE()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_DRAW(cmdUI_DRAWValue.UPDATE, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdCLEAN()
		{
			var parameterList = new List<IByteCode>();
			return new cmdUI_DRAW(cmdUI_DRAWValue.CLEAN, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdPIXEL(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.PIXEL, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X end [0..LCD_WIDTH]</param>
		/// <param name="Y1 ">Y end [0..LCD_HEIGHT]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdLINE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.LINE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="R">Radius</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdCIRCLE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.CIRCLE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="STRING">Text to draw</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdTEXT(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.TEXT, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="TYPE">Icon type (pool)</param>
		/// <param name="NO">Icon number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdICON(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data8> TYPE, IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.ICON, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="IP">Address of picture</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdPICTURE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data32> IP)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.PICTURE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point</param>
		/// <param name="DECIMALS">Number of decimals</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdVALUE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.VALUE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH - X0]</param>
		/// <param name="Y1 ">Y size [0..LCD_HEIGHT - Y0]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdFILLRECT(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.FILLRECT, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH - X0]</param>
		/// <param name="Y1 ">Y size [0..LCD_HEIGHT - Y0]</param>
		[Support(Official = true, Xtended = false, Compat = false)]
		public static cmdUI_DRAW cmdRECT(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.RECT, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH - X0]</param>
		/// <param name="Y1 ">Y size [0..LCD_HEIGHT - Y0]</param>
		/// <remarks>
		/// renamed from RECT
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdRECTANGLE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.RECTANGLE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="ICON1">First icon</param>
		/// <param name="ICON2">Second icon</param>
		/// <param name="ICON3">Third icon</param>
		/// <param name="STRING">Notification text</param>
		/// <param name="STATE">State 0 = INIT</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdNOTIFICATION(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data8> ICON1, IExpression<Data8> ICON2, IExpression<Data8> ICON3, IExpression<DataString> STRING, IExpression<Data8> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(ICON1 ?? throw new ArgumentNullException(nameof(ICON1)));
			parameterList.Add(ICON2 ?? throw new ArgumentNullException(nameof(ICON2)));
			parameterList.Add(ICON3 ?? throw new ArgumentNullException(nameof(ICON3)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.NOTIFICATION, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="ICON1">First icon</param>
		/// <param name="ICON2">Second icon</param>
		/// <param name="STRING">Question text</param>
		/// <param name="STATE">State 0 = NO, 1 = OK</param>
		/// <param name="OK">Answer 0 = NO, 1 = OK, -1 = SKIP</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdQUESTION(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data8> ICON1, IExpression<Data8> ICON2, IExpression<DataString> STRING, IExpression<Data8> STATE, IExpression<Data8> OK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(ICON1 ?? throw new ArgumentNullException(nameof(ICON1)));
			parameterList.Add(ICON2 ?? throw new ArgumentNullException(nameof(ICON2)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			parameterList.Add(OK ?? throw new ArgumentNullException(nameof(OK)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.QUESTION, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="ICON"></param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="DEFAULT">Default string (0 = none)</param>
		/// <param name="CHARSET">Internal use (must be a variable initialised by a "valid character set")</param>
		/// <param name="STRING">Keyboard input</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdKEYBOARD(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data8> ICON, IExpression<Data8> LENGTH, IExpression<DataString> DEFAULT, IExpression<Data8> CHARSET, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(ICON ?? throw new ArgumentNullException(nameof(ICON)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DEFAULT ?? throw new ArgumentNullException(nameof(DEFAULT)));
			parameterList.Add(CHARSET ?? throw new ArgumentNullException(nameof(CHARSET)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.KEYBOARD, parameterList.ToArray());
		}

		/// <param name="TYPE">Browser Types Avaliable</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH]</param>
		/// <param name="Y1">Y size [0..LCD_HEIGHT]</param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="ITEM_TYPE">Item type (folder, byte code file, sound file, ...)(must be a zero initialised variable)</param>
		/// <param name="STRING">Selected item name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdBROWSE(IExpression<Data8> TYPE, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1, IExpression<Data8> LENGTH, IExpression<Data8> ITEM_TYPE, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1 ?? throw new ArgumentNullException(nameof(Y1)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(ITEM_TYPE ?? throw new ArgumentNullException(nameof(ITEM_TYPE)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.BROWSE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH]</param>
		/// <param name="Y1">Y size [0..LCD_HEIGHT]</param>
		/// <param name="MIN">Minimum value</param>
		/// <param name="MAX">Maximum value</param>
		/// <param name="ACT">Actual value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdVERTBAR(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1, IExpression<Data16> MIN, IExpression<Data16> MAX, IExpression<Data16> ACT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1 ?? throw new ArgumentNullException(nameof(Y1)));
			parameterList.Add(MIN ?? throw new ArgumentNullException(nameof(MIN)));
			parameterList.Add(MAX ?? throw new ArgumentNullException(nameof(MAX)));
			parameterList.Add(ACT ?? throw new ArgumentNullException(nameof(ACT)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.VERTBAR, parameterList.ToArray());
		}

		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X size [0..LCD_WIDTH]</param>
		/// <param name="Y1 ">Y size [0..LCD_HEIGHT]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdINVERSERECT(IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.INVERSERECT, parameterList.ToArray());
		}

		/// <param name="TYPE">Font type [0..2] font will change to 0 when UPDATE is called</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdSELECT_FONT(IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.SELECT_FONT, parameterList.ToArray());
		}

		/// <param name="ENABLE">Enable top status line (0 = disabled, 1 = enabled)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdTOPLINE(IExpression<Data8> ENABLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ENABLE ?? throw new ArgumentNullException(nameof(ENABLE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.TOPLINE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR] (Color != BG_COLOR and FG_COLOR -> test pattern)</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="Y1">X size [0..LCD_HEIGHT]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdFILLWINDOW(IExpression<Data8> COLOR, IExpression<Data16> Y0, IExpression<Data16> Y1)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(Y1 ?? throw new ArgumentNullException(nameof(Y1)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.FILLWINDOW, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdSCROLL(IExpression<Data16> Y)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.SCROLL, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="X1">X end [0..LCD_WIDTH]</param>
		/// <param name="Y1 ">Y end [0..LCD_HEIGHT]</param>
		/// <param name="ON ">On pixels</param>
		/// <param name="OFF ">Off pixels</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdDOTLINE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1 , IExpression<Data16> ON , IExpression<Data16> OFF )
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1  ?? throw new ArgumentNullException(nameof(Y1 )));
			parameterList.Add(ON  ?? throw new ArgumentNullException(nameof(ON )));
			parameterList.Add(OFF  ?? throw new ArgumentNullException(nameof(OFF )));
			return new cmdUI_DRAW(cmdUI_DRAWValue.DOTLINE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point</param>
		/// <param name="DECIMALS">Number of decimals</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdVIEW_VALUE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.VIEW_VALUE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point</param>
		/// <param name="DECIMALS">Number of decimals</param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="STRING">Text to draw</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdVIEW_UNIT(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS, IExpression<Data8> LENGTH, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.VIEW_UNIT, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="R">Radius</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdFILLCIRCLE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.FILLCIRCLE, parameterList.ToArray());
		}

		/// <param name="NO">Level number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdSTORE(IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.STORE, parameterList.ToArray());
		}

		/// <param name="NO">Level number (N=0 -> Saved screen just before run)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdRESTORE(IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.RESTORE, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="STATE">State 0 = INIT</param>
		/// <param name="ICONS">bitfield with icons</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdICON_QUESTION(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data8> STATE, IExpression<Data32> ICONS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			parameterList.Add(ICONS ?? throw new ArgumentNullException(nameof(ICONS)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.ICON_QUESTION, parameterList.ToArray());
		}

		/// <param name="COLOR">Color [BG_COLOR..FG_COLOR]</param>
		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="Y0">Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="NAME">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdBMPFILE(IExpression<Data8> COLOR, IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(COLOR ?? throw new ArgumentNullException(nameof(COLOR)));
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.BMPFILE, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdPOPUP(IExpression<Data8> OPEN)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(OPEN ?? throw new ArgumentNullException(nameof(OPEN)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.POPUP, parameterList.ToArray());
		}

		/// <param name="X0">X start cord [0..LCD_WIDTH]</param>
		/// <param name="X1">X size [0..LCD_WIDTH - X0]</param>
		/// <param name="ITEMS">Number of datasets in arrays</param>
		/// <param name="OFFSET">DATA16 array (handle) containing Y start cord [0..LCD_HEIGHT]</param>
		/// <param name="SPAN">DATA16 array (handle) containing Y size [0..(LCD_HEIGHT - hOFFSET[])]</param>
		/// <param name="MIN">DATAF array (handle) containing min values</param>
		/// <param name="MAX">DATAF array (handle) containing max values</param>
		/// <param name="SAMPLE">DATAF array (handle) containing sample values</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdGRAPH_SETUP(IExpression<Data16> X0, IExpression<Data16> X1, IExpression<Data16> ITEMS, IExpression<Data16> OFFSET, IExpression<Data8> SPAN, IExpression<Data16> MIN, IExpression<Data16> MAX, IExpression<Data16> SAMPLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			parameterList.Add(OFFSET ?? throw new ArgumentNullException(nameof(OFFSET)));
			parameterList.Add(SPAN ?? throw new ArgumentNullException(nameof(SPAN)));
			parameterList.Add(MIN ?? throw new ArgumentNullException(nameof(MIN)));
			parameterList.Add(MAX ?? throw new ArgumentNullException(nameof(MAX)));
			parameterList.Add(SAMPLE ?? throw new ArgumentNullException(nameof(SAMPLE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.GRAPH_SETUP, parameterList.ToArray());
		}

		/// <param name="VIEW">Dataset number to view (0=all)</param>
		/// <param name="ACTUAL"></param>
		/// <param name="LOWEST"></param>
		/// <param name="HIGHEST"></param>
		/// <param name="AVERAGE"></param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdGRAPH_DRAW(IExpression<Data8> VIEW, IExpression<DataFloat> ACTUAL, IExpression<DataFloat> LOWEST, IExpression<DataFloat> HIGHEST, IExpression<DataFloat> AVERAGE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VIEW ?? throw new ArgumentNullException(nameof(VIEW)));
			parameterList.Add(ACTUAL ?? throw new ArgumentNullException(nameof(ACTUAL)));
			parameterList.Add(LOWEST ?? throw new ArgumentNullException(nameof(LOWEST)));
			parameterList.Add(HIGHEST ?? throw new ArgumentNullException(nameof(HIGHEST)));
			parameterList.Add(AVERAGE ?? throw new ArgumentNullException(nameof(AVERAGE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.GRAPH_DRAW, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdUI_DRAW cmdTEXTBOX(IExpression<Data16> X0, IExpression<Data16> Y0, IExpression<Data16> X1, IExpression<Data16> Y1, IExpression<Data8> TEXT, IExpression<Data32> SIZE, IExpression<Data8> DEL, IExpression<Data8> LINE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X0 ?? throw new ArgumentNullException(nameof(X0)));
			parameterList.Add(Y0 ?? throw new ArgumentNullException(nameof(Y0)));
			parameterList.Add(X1 ?? throw new ArgumentNullException(nameof(X1)));
			parameterList.Add(Y1 ?? throw new ArgumentNullException(nameof(Y1)));
			parameterList.Add(TEXT ?? throw new ArgumentNullException(nameof(TEXT)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(LINE ?? throw new ArgumentNullException(nameof(LINE)));
			return new cmdUI_DRAW(cmdUI_DRAWValue.TEXTBOX, parameterList.ToArray());
		}

		/// <summary>
		/// e^x            r = expf(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdEXP(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.EXP, parameterList.ToArray());
		}

		/// <summary>
		/// Modulo         r = fmod(x,y)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdMOD(IExpression<DataFloat> X, IExpression<DataFloat> Y, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.MOD, parameterList.ToArray());
		}

		/// <summary>
		/// Floor          r = floor(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdFLOOR(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.FLOOR, parameterList.ToArray());
		}

		/// <summary>
		/// Ceiling        r = ceil(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdCEIL(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.CEIL, parameterList.ToArray());
		}

		/// <summary>
		/// Round          r = round(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdROUND(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.ROUND, parameterList.ToArray());
		}

		/// <summary>
		/// Absolute       r = fabs(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdABS(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.ABS, parameterList.ToArray());
		}

		/// <summary>
		/// Negate         r = 0.0 - x
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdNEGATE(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.NEGATE, parameterList.ToArray());
		}

		/// <summary>
		/// Squareroot     r = sqrt(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdSQRT(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.SQRT, parameterList.ToArray());
		}

		/// <summary>
		/// Log            r = log10(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdLOG(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.LOG, parameterList.ToArray());
		}

		/// <summary>
		/// Ln             r = log(x)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdLN(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.LN, parameterList.ToArray());
		}

		/// <summary>
		/// Sin (R = sinf(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdSIN(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.SIN, parameterList.ToArray());
		}

		/// <summary>
		/// Cos (R = cos(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdCOS(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.COS, parameterList.ToArray());
		}

		/// <summary>
		/// Tan (R = tanf(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdTAN(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.TAN, parameterList.ToArray());
		}

		/// <summary>
		/// ASin (R = asinf(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdASIN(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.ASIN, parameterList.ToArray());
		}

		/// <summary>
		/// ACos (R = acos(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdACOS(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.ACOS, parameterList.ToArray());
		}

		/// <summary>
		/// ATan (R = atanf(X))
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdATAN(IExpression<DataFloat> X, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.ATAN, parameterList.ToArray());
		}

		/// <summary>
		/// Modulo DATA8   r = x % y
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdMOD8(IExpression<Data8> X, IExpression<Data8> Y, IExpression<Data8> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.MOD8, parameterList.ToArray());
		}

		/// <summary>
		/// Modulo DATA16  r = x % y
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdMOD16(IExpression<Data16> X, IExpression<Data16> Y, IExpression<Data16> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.MOD16, parameterList.ToArray());
		}

		/// <summary>
		/// Modulo DATA32  r = x % y
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdMOD32(IExpression<Data32> X, IExpression<Data32> Y, IExpression<Data32> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.MOD32, parameterList.ToArray());
		}

		/// <summary>
		/// Exponent       r = powf(x,y)
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdPOW(IExpression<DataFloat> X, IExpression<DataFloat> Y, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(Y ?? throw new ArgumentNullException(nameof(Y)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.POW, parameterList.ToArray());
		}

		/// <summary>
		/// Truncate       r = (float)((int)(x * pow(y))) / pow(y)
		/// </summary>
		/// <param name="X">Value</param>
		/// <param name="P">Precision [0..9]</param>
		/// <param name="R">Result</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdMATH cmdTRUNC(IExpression<DataFloat> X, IExpression<Data8> P, IExpression<DataFloat> R)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(X ?? throw new ArgumentNullException(nameof(X)));
			parameterList.Add(P ?? throw new ArgumentNullException(nameof(P)));
			parameterList.Add(R ?? throw new ArgumentNullException(nameof(R)));
			return new cmdMATH(cmdMATHValue.TRUNC, parameterList.ToArray());
		}

		/// <param name="LENGTH">Maximal code stream length</param>
		/// <param name="IMAGE">Address of image</param>
		/// <param name="GLOBAL">Address of global variables</param>
		/// <param name="FLAG">Flag that tells if image is ready</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_READ cmdCOMMAND(IExpression<Data32> LENGTH, IExpression<Data32> IMAGE, IExpression<Data32> GLOBAL, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(IMAGE ?? throw new ArgumentNullException(nameof(IMAGE)));
			parameterList.Add(GLOBAL ?? throw new ArgumentNullException(nameof(GLOBAL)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new cmdCOM_READ(cmdCOM_READValue.COMMAND, parameterList.ToArray());
		}

		/// <param name="IMAGE">Address of image</param>
		/// <param name="GLOBAL">Address of global variables</param>
		/// <param name="STATUS">Status</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_WRITE cmdREPLY(IExpression<Data32> IMAGE, IExpression<Data32> GLOBAL, IExpression<Data8> STATUS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(IMAGE ?? throw new ArgumentNullException(nameof(IMAGE)));
			parameterList.Add(GLOBAL ?? throw new ArgumentNullException(nameof(GLOBAL)));
			parameterList.Add(STATUS ?? throw new ArgumentNullException(nameof(STATUS)));
			return new cmdCOM_WRITE(cmdCOM_WRITEValue.REPLY, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSOUND cmdBREAK()
		{
			var parameterList = new List<IByteCode>();
			return new cmdSOUND(cmdSOUNDValue.BREAK, parameterList.ToArray());
		}

		/// <param name="VOLUME">Volume [0..100]</param>
		/// <param name="FREQUENCY">Frequency [Hz]</param>
		/// <param name="DURATION">Duration [mS]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSOUND cmdTONE(IExpression<Data8> VOLUME, IExpression<Data16> FREQUENCY, IExpression<Data16> DURATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VOLUME ?? throw new ArgumentNullException(nameof(VOLUME)));
			parameterList.Add(FREQUENCY ?? throw new ArgumentNullException(nameof(FREQUENCY)));
			parameterList.Add(DURATION ?? throw new ArgumentNullException(nameof(DURATION)));
			return new cmdSOUND(cmdSOUNDValue.TONE, parameterList.ToArray());
		}

		/// <param name="VOLUME">Volume [0..100]</param>
		/// <param name="NAME">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSOUND cmdPLAY(IExpression<Data8> VOLUME, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VOLUME ?? throw new ArgumentNullException(nameof(VOLUME)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdSOUND(cmdSOUNDValue.PLAY, parameterList.ToArray());
		}

		/// <param name="VOLUME">Volume [0..100]</param>
		/// <param name="NAME">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSOUND cmdREPEAT(IExpression<Data8> VOLUME, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(VOLUME ?? throw new ArgumentNullException(nameof(VOLUME)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdSOUND(cmdSOUNDValue.REPEAT, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdSOUND cmdSERVICE()
		{
			var parameterList = new List<IByteCode>();
			return new cmdSOUND(cmdSOUNDValue.SERVICE, parameterList.ToArray());
		}

		/// <summary>
		/// Insert type in table
		/// </summary>
		/// <param name="TYPEDATA">String variable or handle to string containing type data</param>
		/// <param name="FORCE">Force type insert even if present (0 = don't force, 1 = force)</param>
		/// <param name="ERROR">Error if not Third Party type (0 = no error, 1 = error or known)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdINSERT_TYPE(IExpression<DataString> TYPEDATA, IExpression<Data8> FORCE, IExpression<Data8> ERROR)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPEDATA ?? throw new ArgumentNullException(nameof(TYPEDATA)));
			parameterList.Add(FORCE ?? throw new ArgumentNullException(nameof(FORCE)));
			parameterList.Add(ERROR ?? throw new ArgumentNullException(nameof(ERROR)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.INSERT_TYPE, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="DATASETS">Number of data sets</param>
		/// <param name="FORMAT">Format [0..3]</param>
		/// <param name="MODES">Number of modes [1..8]</param>
		/// <param name="VIEWS">Number of views [1..8]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_FORMAT(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> DATASETS, IExpression<Data8> FORMAT, IExpression<Data8> MODES, IExpression<Data8> VIEWS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(DATASETS ?? throw new ArgumentNullException(nameof(DATASETS)));
			parameterList.Add(FORMAT ?? throw new ArgumentNullException(nameof(FORMAT)));
			parameterList.Add(MODES ?? throw new ArgumentNullException(nameof(MODES)));
			parameterList.Add(VIEWS ?? throw new ArgumentNullException(nameof(VIEWS)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_FORMAT, parameterList.ToArray());
		}

		/// <summary>
		/// Apply new minimum and maximum raw value for device type to be used in scaling PCT and SI
		/// </summary>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		/// <param name="MODE">Device mode [0..7]</param>
		/// <param name="CAL_MIN">32 bit raw minimum value (Zero)</param>
		/// <param name="CAL_MAX">32 bit raw maximum value (Full scale)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCAL_MINMAX(IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data32> CAL_MIN, IExpression<Data32> CAL_MAX)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(CAL_MIN ?? throw new ArgumentNullException(nameof(CAL_MIN)));
			parameterList.Add(CAL_MAX ?? throw new ArgumentNullException(nameof(CAL_MAX)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CAL_MINMAX, parameterList.ToArray());
		}

		/// <summary>
		/// Apply the default minimum and maximum raw value for device type to be used in scaling PCT and SI
		/// </summary>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		/// <param name="MODE">Device mode [0..7]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCAL_DEFAULT(IExpression<Data8> TYPE, IExpression<Data8> MODE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CAL_DEFAULT, parameterList.ToArray());
		}

		/// <summary>
		/// Get device type and mode
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		/// <param name="MODE">Device mode [0..7]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_TYPEMODE(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_TYPEMODE, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_SYMBOL(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_SYMBOL, parameterList.ToArray());
		}

		/// <summary>
		/// Apply new minimum raw value for device type to be used in scaling PCT and SI
		/// </summary>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		/// <param name="MODE">Device mode [0..7]</param>
		/// <param name="CAL_MIN">32 bit raw minimum value (Zero)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCAL_MIN(IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data32> CAL_MIN)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(CAL_MIN ?? throw new ArgumentNullException(nameof(CAL_MIN)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CAL_MIN, parameterList.ToArray());
		}

		/// <summary>
		/// Apply new maximum raw value for device type to be used in scaling PCT and SI
		/// </summary>
		/// <param name="TYPE">Device type id from typedata.rcf</param>
		/// <param name="MODE">Device mode [0..7]</param>
		/// <param name="CAL_MAX">32 bit SI maximum value (Full scale)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCAL_MAX(IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data32> CAL_MAX)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(CAL_MAX ?? throw new ArgumentNullException(nameof(CAL_MAX)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CAL_MAX, parameterList.ToArray());
		}

		/// <summary>
		/// Generic setup/read IIC sensors
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="REPEAT">Repeat setup/read "REPEAT" times (0 = infinite)</param>
		/// <param name="TIME">Time between repeats [10..1000mS] (0 = 10)</param>
		/// <param name="WRITE_LEN">No of bytes to write</param>
		/// <param name="WRITE_DATA">DATA8 array (handle) of data to write</param>
		/// <param name="READ_LEN">No of bytes to read</param>
		/// <param name="READ_DATA">DATA8 array (handle) to read into</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdSETUP(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> REPEAT, IExpression<Data16> TIME, IExpression<Data8> WRITE_LEN, IExpression<Data8> WRITE_DATA, IExpression<Data8> READ_LEN, IExpression<Data8> READ_DATA)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(REPEAT ?? throw new ArgumentNullException(nameof(REPEAT)));
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(WRITE_LEN ?? throw new ArgumentNullException(nameof(WRITE_LEN)));
			parameterList.Add(WRITE_DATA ?? throw new ArgumentNullException(nameof(WRITE_DATA)));
			parameterList.Add(READ_LEN ?? throw new ArgumentNullException(nameof(READ_LEN)));
			parameterList.Add(READ_DATA ?? throw new ArgumentNullException(nameof(READ_DATA)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.SETUP, parameterList.ToArray());
		}

		/// <summary>
		/// Clear all devices (e.c. counters, angle, ...)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCLR_ALL(IExpression<Data8> LAYER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CLR_ALL, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="VALUE">32 bit raw value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_RAW(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data32> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_RAW, parameterList.ToArray());
		}

		/// <summary>
		/// Get device connection type (for test)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="CONN">Connection type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_CONNECTION(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> CONN)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(CONN ?? throw new ArgumentNullException(nameof(CONN)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_CONNECTION, parameterList.ToArray());
		}

		/// <summary>
		/// Stop all devices (e.c. motors, ...)
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdSTOP_ALL(IExpression<Data8> LAYER)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.STOP_ALL, parameterList.ToArray());
		}

		/// <summary>
		/// Set new type and mode on existing devices
		/// </summary>
		/// <param name="TYPE">Existing type</param>
		/// <param name="MODE">Existing mode</param>
		/// <param name="NEWTYPE">New type</param>
		/// <param name="NEWMODE">New mode</param>
		/// <param name="ERROR">Error if not Third Party type (0 = no error, 1 = error or not found)</param>
		/// <remarks>
		/// if TYPE==NEWTYPE and MODE==NEWMODE -> ERROR will be 0 if exists and nothing is changed
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdSET_TYPEMODE(IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> NEWTYPE, IExpression<Data8> NEWMODE, IExpression<Data8> ERROR)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(NEWTYPE ?? throw new ArgumentNullException(nameof(NEWTYPE)));
			parameterList.Add(NEWMODE ?? throw new ArgumentNullException(nameof(NEWMODE)));
			parameterList.Add(ERROR ?? throw new ArgumentNullException(nameof(ERROR)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.SET_TYPEMODE, parameterList.ToArray());
		}

		/// <summary>
		/// Generic setup/read IIC sensors with result
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="WRLNG">No of bytes to write</param>
		/// <param name="WRDATA">DATA8 array  (handle) of data to write</param>
		/// <param name="RDLNG">No of bytes to read (if negative -> byte order is reversed)</param>
		/// <param name="RDDATA">DATA8 array  (handle) to read into</param>
		/// <param name="RESULT">Write/read result (OK, FAIL)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdREADY_IIC(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> WRLNG, IExpression<Data8> WRDATA, IExpression<Data8> RDLNG, IExpression<Data8> RDDATA, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(WRLNG ?? throw new ArgumentNullException(nameof(WRLNG)));
			parameterList.Add(WRDATA ?? throw new ArgumentNullException(nameof(WRDATA)));
			parameterList.Add(RDLNG ?? throw new ArgumentNullException(nameof(RDLNG)));
			parameterList.Add(RDDATA ?? throw new ArgumentNullException(nameof(RDDATA)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.READY_IIC, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_NAME(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_NAME, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="MODE">Mode</param>
		/// <param name="LENGTH">Maximal length of string returned (-1 = no check)</param>
		/// <param name="DESTINATION">String variable or handle to string</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_MODENAME(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> MODE, IExpression<Data8> LENGTH, IExpression<DataString> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_MODENAME, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="VALUE"></param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdSET_RAW(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data32> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.SET_RAW, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="FIGURES">Total number of figures (inclusive decimal point and decimals)</param>
		/// <param name="DECIMALS">Number of decimals</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_FIGURES(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_FIGURES, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="VALUE">Positive changes since last clear</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_CHANGES(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_CHANGES, parameterList.ToArray());
		}

		/// <summary>
		/// Clear changes and bumps
		/// </summary>
		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdCLR_CHANGES(IExpression<Data8> LAYER, IExpression<Data8> NO)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.CLR_CHANGES, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="VALUES">Number of return values</param>
		/// <param name="VALUES_">variable arguments</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdREADY_PCT(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.READY_PCT, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="VALUES">Number of return values</param>
		/// <param name="VALUES_">variable arguments</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdREADY_RAW(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.READY_RAW, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="TYPE">Device type id (0 = don't change type)</param>
		/// <param name="MODE">Device mode [0..7] (-1 = don't change mode)</param>
		/// <param name="VALUES">Number of return values</param>
		/// <param name="VALUES_">variable arguments</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdREADY_SI(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<Data8> TYPE, IExpression<Data8> MODE, IExpression<Data8> VALUES, params IExpression[] VALUES_)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(MODE ?? throw new ArgumentNullException(nameof(MODE)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			parameterList.AddRange(VALUES_ ?? throw new ArgumentNullException(nameof(VALUES_)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.READY_SI, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="MIN">Min SI value</param>
		/// <param name="MAX">Max SI value</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_MINMAX(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<DataFloat> MIN, IExpression<DataFloat> MAX)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(MIN ?? throw new ArgumentNullException(nameof(MIN)));
			parameterList.Add(MAX ?? throw new ArgumentNullException(nameof(MAX)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_MINMAX, parameterList.ToArray());
		}

		/// <param name="LAYER">Daisy chain layer number [0..3]</param>
		/// <param name="NO">Port number</param>
		/// <param name="VALUE">Negative changes since last clear</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdINPUT_DEVICE cmdGET_BUMPS(IExpression<Data8> LAYER, IExpression<Data8> NO, IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LAYER ?? throw new ArgumentNullException(nameof(LAYER)));
			parameterList.Add(NO ?? throw new ArgumentNullException(nameof(NO)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdINPUT_DEVICE(cmdINPUT_DEVICEValue.GET_BUMPS, parameterList.ToArray());
		}

		/// <summary>
		/// Create file or open for append
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdOPEN_APPEND(IExpression<DataString> NAME, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdFILE(cmdFILEValue.OPEN_APPEND, parameterList.ToArray());
		}

		/// <summary>
		/// Open file for read
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="SIZE">File size (0 = not found)</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdOPEN_READ(IExpression<DataString> NAME, IExpression<Data16> HANDLE, IExpression<Data32> SIZE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			return new cmdFILE(cmdFILEValue.OPEN_READ, parameterList.ToArray());
		}

		/// <summary>
		/// Create file for write
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdOPEN_WRITE(IExpression<DataString> NAME, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdFILE(cmdFILEValue.OPEN_WRITE, parameterList.ToArray());
		}

		/// <summary>
		/// Read floating point value from file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="DEL">Delimiter code</param>
		/// <param name="VALUE">Value read</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdREAD_VALUE(IExpression<Data16> HANDLE, IExpression<Data8> DEL, IExpression<DataFloat> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdFILE(cmdFILEValue.READ_VALUE, parameterList.ToArray());
		}

		/// <summary>
		/// Write floating point value to file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="DEL">Delimiter code</param>
		/// <param name="VALUE">Value to write</param>
		/// <param name="FIGURES">Total number of figures inclusive decimal point</param>
		/// <param name="DECIMALS">Number of decimals</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdWRITE_VALUE(IExpression<Data16> HANDLE, IExpression<Data8> DEL, IExpression<DataFloat> VALUE, IExpression<Data8> FIGURES, IExpression<Data8> DECIMALS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			parameterList.Add(FIGURES ?? throw new ArgumentNullException(nameof(FIGURES)));
			parameterList.Add(DECIMALS ?? throw new ArgumentNullException(nameof(DECIMALS)));
			return new cmdFILE(cmdFILEValue.WRITE_VALUE, parameterList.ToArray());
		}

		/// <summary>
		/// Read text from file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="DEL">Delimiter code</param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="TEXT">Text to read</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdREAD_TEXT(IExpression<Data16> HANDLE, IExpression<Data8> DEL, IExpression<Data16> LENGTH, IExpression<DataString> TEXT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(TEXT ?? throw new ArgumentNullException(nameof(TEXT)));
			return new cmdFILE(cmdFILEValue.READ_TEXT, parameterList.ToArray());
		}

		/// <summary>
		/// Write text to file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="DEL">Delimiter code</param>
		/// <param name="TEXT">Text to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdWRITE_TEXT(IExpression<Data16> HANDLE, IExpression<Data8> DEL, IExpression<DataString> TEXT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(DEL ?? throw new ArgumentNullException(nameof(DEL)));
			parameterList.Add(TEXT ?? throw new ArgumentNullException(nameof(TEXT)));
			return new cmdFILE(cmdFILEValue.WRITE_TEXT, parameterList.ToArray());
		}

		/// <summary>
		/// Close file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdCLOSE(IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdFILE(cmdFILEValue.CLOSE, parameterList.ToArray());
		}

		/// <param name="PRGID">Program id</param>
		/// <param name="NAME">Image name</param>
		/// <param name="SIZE">Size</param>
		/// <param name="IP">Address of image</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdLOAD_IMAGE(IExpression<Data16> PRGID, IExpression<DataString> NAME, IExpression<Data32> SIZE, IExpression<Data32> IP)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			return new cmdFILE(cmdFILEValue.LOAD_IMAGE, parameterList.ToArray());
		}

		/// <summary>
		/// Get handle from filename
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="WRITE">Open for write / append (0 = no, 1 = yes)</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_HANDLE(IExpression<DataString> NAME, IExpression<Data16> HANDLE, IExpression<Data8> WRITE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(WRITE ?? throw new ArgumentNullException(nameof(WRITE)));
			return new cmdFILE(cmdFILEValue.GET_HANDLE, parameterList.ToArray());
		}

		/// <summary>
		/// Make folder if not present
		/// </summary>
		/// <param name="NAME">Folder name</param>
		/// <param name="SUCCESS">Success (0 = no, 1 = yes)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdMAKE_FOLDER(IExpression<DataString> NAME, IExpression<Data8> SUCCESS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(SUCCESS ?? throw new ArgumentNullException(nameof(SUCCESS)));
			return new cmdFILE(cmdFILEValue.MAKE_FOLDER, parameterList.ToArray());
		}

		/// <param name="SIZE">Size of pool</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="IP">Address of image</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_POOL(IExpression<Data32> SIZE, IExpression<Data16> HANDLE, IExpression<Data32> IP)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			return new cmdFILE(cmdFILEValue.GET_POOL, parameterList.ToArray());
		}

		/// <param name="TIME">Sync time used in data log files</param>
		/// <param name="TICK">Sync tick used in data log files</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdSET_LOG_SYNC_TIME(IExpression<Data32> TIME, IExpression<Data32> TICK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(TICK ?? throw new ArgumentNullException(nameof(TICK)));
			return new cmdFILE(cmdFILEValue.SET_LOG_SYNC_TIME, parameterList.ToArray());
		}

		/// <param name="NAME">Folder name (ex "../prjs/")</param>
		/// <param name="ITEMS">No of sub folders</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_FOLDERS(IExpression<DataString> NAME, IExpression<Data8> ITEMS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			return new cmdFILE(cmdFILEValue.GET_FOLDERS, parameterList.ToArray());
		}

		/// <param name="TIME">Sync time used in data log files</param>
		/// <param name="TICK">Sync tick used in data log files</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_LOG_SYNC_TIME(IExpression<Data32> TIME, IExpression<Data32> TICK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(TICK ?? throw new ArgumentNullException(nameof(TICK)));
			return new cmdFILE(cmdFILEValue.GET_LOG_SYNC_TIME, parameterList.ToArray());
		}

		/// <param name="NAME">Folder name (ex "../prjs/")</param>
		/// <param name="ITEM">Sub folder index [1..ITEMS]</param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="STRING">Subfolder name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_SUBFOLDER_NAME(IExpression<DataString> NAME, IExpression<Data8> ITEM, IExpression<Data8> LENGTH, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdFILE(cmdFILEValue.GET_SUBFOLDER_NAME, parameterList.ToArray());
		}

		/// <summary>
		/// Write time slot samples to file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="TIME">Relative time in mS</param>
		/// <param name="ITEMS">Total number of values in this time slot</param>
		/// <param name="VALUES">DATAF array (handle) containing values</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdWRITE_LOG(IExpression<Data16> HANDLE, IExpression<Data32> TIME, IExpression<Data8> ITEMS, IExpression<DataFloat> VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(TIME ?? throw new ArgumentNullException(nameof(TIME)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			parameterList.Add(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new cmdFILE(cmdFILEValue.WRITE_LOG, parameterList.ToArray());
		}

		/// <summary>
		/// Close data log file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="NAME">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdCLOSE_LOG(IExpression<Data16> HANDLE, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdFILE(cmdFILEValue.CLOSE_LOG, parameterList.ToArray());
		}

		/// <param name="NAME">Image name</param>
		/// <param name="PRGID">Program id</param>
		/// <param name="ITEM">Sub folder index [1..ITEMS]</param>
		/// <param name="IP">Address of image</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_IMAGE(IExpression<DataString> NAME, IExpression<Data16> PRGID, IExpression<Data8> ITEM, IExpression<Data32> IP)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			return new cmdFILE(cmdFILEValue.GET_IMAGE, parameterList.ToArray());
		}

		/// <param name="NAME">Name</param>
		/// <param name="STRING">Item name</param>
		/// <param name="ITEM">Sub folder index [1..ITEMS]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_ITEM(IExpression<DataString> NAME, IExpression<DataString> STRING, IExpression<Data8> ITEM)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			return new cmdFILE(cmdFILEValue.GET_ITEM, parameterList.ToArray());
		}

		/// <param name="ITEMS">Number of files in cache</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_CACHE_FILES(IExpression<Data8> ITEMS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			return new cmdFILE(cmdFILEValue.GET_CACHE_FILES, parameterList.ToArray());
		}

		/// <param name="STRING">File Name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdPUT_CACHE_FILE(IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdFILE(cmdFILEValue.PUT_CACHE_FILE, parameterList.ToArray());
		}

		/// <param name="ITEM">Cache index [1..ITEMS]</param>
		/// <param name="LENGTH">Maximal string length</param>
		/// <param name="STRING">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_CACHE_FILE(IExpression<Data8> ITEM, IExpression<Data8> LENGTH, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdFILE(cmdFILEValue.GET_CACHE_FILE, parameterList.ToArray());
		}

		/// <param name="STRING">File name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdDEL_CACHE_FILE(IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdFILE(cmdFILEValue.DEL_CACHE_FILE, parameterList.ToArray());
		}

		/// <param name="NAME">Folder name (ex "../prjs/")</param>
		/// <param name="ITEM">Sub folder index [1..ITEMS]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdDEL_SUBFOLDER(IExpression<DataString> NAME, IExpression<Data8> ITEM)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			return new cmdFILE(cmdFILEValue.DEL_SUBFOLDER, parameterList.ToArray());
		}

		/// <summary>
		/// Get the current open log filename
		/// </summary>
		/// <param name="LENGTH">Max string length (don't care if NAME is a HND)</param>
		/// <param name="NAME">File name (character string or HND)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdGET_LOG_NAME(IExpression<Data8> LENGTH, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdFILE(cmdFILEValue.GET_LOG_NAME, parameterList.ToArray());
		}

		/// <summary>
		/// Create file for data logging
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="syncedTime"></param>
		/// <param name="syncedTick"></param>
		/// <param name="nowTick"></param>
		/// <param name="sample_interval_in_ms"></param>
		/// <param name="duration_in_ms"></param>
		/// <param name="SDATA">Sensor type data</param>
		/// <param name="HANDLE">Handle to file</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdOPEN_LOG(IExpression<DataString> NAME, IExpression<Data32> syncedTime, IExpression<Data32> syncedTick, IExpression<Data32> nowTick, IExpression<Data32> sample_interval_in_ms, IExpression<Data32> duration_in_ms, IExpression<DataString> SDATA, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(syncedTime ?? throw new ArgumentNullException(nameof(syncedTime)));
			parameterList.Add(syncedTick ?? throw new ArgumentNullException(nameof(syncedTick)));
			parameterList.Add(nowTick ?? throw new ArgumentNullException(nameof(nowTick)));
			parameterList.Add(sample_interval_in_ms ?? throw new ArgumentNullException(nameof(sample_interval_in_ms)));
			parameterList.Add(duration_in_ms ?? throw new ArgumentNullException(nameof(duration_in_ms)));
			parameterList.Add(SDATA ?? throw new ArgumentNullException(nameof(SDATA)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdFILE(cmdFILEValue.OPEN_LOG, parameterList.ToArray());
		}

		/// <summary>
		/// Read a number of bytes from file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="BYTES">Number of bytes to read</param>
		/// <param name="DESTINATION">First byte in byte stream</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdREAD_BYTES(IExpression<Data16> HANDLE, IExpression<Data16> BYTES, IExpression<Data8> DESTINATION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			parameterList.Add(DESTINATION ?? throw new ArgumentNullException(nameof(DESTINATION)));
			return new cmdFILE(cmdFILEValue.READ_BYTES, parameterList.ToArray());
		}

		/// <summary>
		/// Write a number of bytes to file
		/// </summary>
		/// <param name="HANDLE">Handle to file</param>
		/// <param name="BYTES">Number of bytes to write</param>
		/// <param name="SOURCE">First byte in byte stream to write</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdWRITE_BYTES(IExpression<Data16> HANDLE, IExpression<Data16> BYTES, IExpression<Data8> SOURCE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			return new cmdFILE(cmdFILEValue.WRITE_BYTES, parameterList.ToArray());
		}

		/// <summary>
		/// Delete file
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdREMOVE(IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdFILE(cmdFILEValue.REMOVE, parameterList.ToArray());
		}

		/// <summary>
		/// Move file SOURCE to DEST
		/// </summary>
		/// <param name="SOURCE">Source file name</param>
		/// <param name="DEST">Destination file name</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILE cmdMOVE(IExpression<DataString> SOURCE, IExpression<DataString> DEST)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(SOURCE ?? throw new ArgumentNullException(nameof(SOURCE)));
			parameterList.Add(DEST ?? throw new ArgumentNullException(nameof(DEST)));
			return new cmdFILE(cmdFILEValue.MOVE, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		[Support(Official = true, Xtended = false, Compat = false)]
		public static cmdARRAY cmdDELETE(IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.DELETE, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <remarks>
		/// renamed from DELETE
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static cmdARRAY cmdDESTROY(IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.DESTROY, parameterList.ToArray());
		}

		/// <param name="ELEMENTS">Number of elements</param>
		/// <param name="HANDLE">Array handle</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdCREATE8(IExpression<Data32> ELEMENTS, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.CREATE8, parameterList.ToArray());
		}

		/// <param name="ELEMENTS">Number of elements</param>
		/// <param name="HANDLE">Array handle</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdCREATE16(IExpression<Data32> ELEMENTS, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.CREATE16, parameterList.ToArray());
		}

		/// <param name="ELEMENTS">Number of elements</param>
		/// <param name="HANDLE">Array handle</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdCREATE32(IExpression<Data32> ELEMENTS, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.CREATE32, parameterList.ToArray());
		}

		/// <param name="ELEMENTS">Number of elements</param>
		/// <param name="HANDLE">Array handle</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdCREATEF(IExpression<Data32> ELEMENTS, IExpression<Data16> HANDLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			return new cmdARRAY(cmdARRAYValue.CREATEF, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="ELEMENTS">Total number of elements</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdRESIZE(IExpression<Data16> HANDLE, IExpression<Data32> ELEMENTS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			return new cmdARRAY(cmdARRAYValue.RESIZE, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="VALUE">Value to write - type depends on type of array</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdFILL(IExpression<Data16> HANDLE, IExpression VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdARRAY(cmdARRAYValue.FILL, parameterList.ToArray());
		}

		/// <param name="HSOURCE">Source array Handle</param>
		/// <param name="HDEST">Destination array handle</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdCOPY(IExpression<Data16> HSOURCE, IExpression<Data16> HDEST)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HSOURCE ?? throw new ArgumentNullException(nameof(HSOURCE)));
			parameterList.Add(HDEST ?? throw new ArgumentNullException(nameof(HDEST)));
			return new cmdARRAY(cmdARRAYValue.COPY, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to element to write</param>
		/// <param name="ELEMENTS">Number of elements to write</param>
		/// <param name="VALUES">First value to write - type must be equal to the array type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdINIT8(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> ELEMENTS, params IExpression<Data8>[] VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.AddRange(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new cmdARRAY(cmdARRAYValue.INIT8, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to element to write</param>
		/// <param name="ELEMENTS">Number of elements to write</param>
		/// <param name="VALUES">First value to write - type must be equal to the array type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdINIT16(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> ELEMENTS, params IExpression<Data16>[] VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.AddRange(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new cmdARRAY(cmdARRAYValue.INIT16, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to element to write</param>
		/// <param name="ELEMENTS">Number of elements to write</param>
		/// <param name="VALUES">First value to write - type must be equal to the array type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdINIT32(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> ELEMENTS, params IExpression<Data32>[] VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.AddRange(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new cmdARRAY(cmdARRAYValue.INIT32, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to element to write</param>
		/// <param name="ELEMENTS">Number of elements to write</param>
		/// <param name="VALUES">First value to write - type must be equal to the array type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdINITF(IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> ELEMENTS, params IExpression<DataFloat>[] VALUES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			parameterList.AddRange(VALUES ?? throw new ArgumentNullException(nameof(VALUES)));
			return new cmdARRAY(cmdARRAYValue.INITF, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="ELEMENTS">Total number of elements in array</param>
		[Support(Official = true, Xtended = false, Compat = false)]
		public static cmdARRAY cmdSIZE(IExpression<Data16> HANDLE, IExpression<Data32> ELEMENTS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			return new cmdARRAY(cmdARRAYValue.SIZE, parameterList.ToArray());
		}

		/// <param name="HANDLE">Array handle</param>
		/// <param name="ELEMENTS">Total number of elements in array</param>
		/// <remarks>
		/// Renamed from SIZE
		/// </remarks>
		[Support(Official = false, Xtended = true, Compat = true)]
		public static cmdARRAY cmdSET_SIZE(IExpression<Data16> HANDLE, IExpression<Data32> ELEMENTS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(ELEMENTS ?? throw new ArgumentNullException(nameof(ELEMENTS)));
			return new cmdARRAY(cmdARRAYValue.SET_SIZE, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number (must be running)</param>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to first byte to read</param>
		/// <param name="BYTES">Number of bytes to read</param>
		/// <param name="ARRAY">First byte of array to receive data</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdREAD_CONTENT(IExpression<Data16> PRGID, IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> BYTES, IExpression<Data8> ARRAY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			return new cmdARRAY(cmdARRAYValue.READ_CONTENT, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number (must be running)</param>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="INDEX">Index to first byte to write</param>
		/// <param name="BYTES">Number of bytes to write</param>
		/// <param name="ARRAY">First byte of array to deliver data</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdWRITE_CONTENT(IExpression<Data16> PRGID, IExpression<Data16> HANDLE, IExpression<Data32> INDEX, IExpression<Data32> BYTES, IExpression<Data8> ARRAY)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			parameterList.Add(ARRAY ?? throw new ArgumentNullException(nameof(ARRAY)));
			return new cmdARRAY(cmdARRAYValue.WRITE_CONTENT, parameterList.ToArray());
		}

		/// <param name="PRGID">Program slot number (must be running)</param>
		/// <param name="HANDLE">Array handle</param>
		/// <param name="BYTES">Number of bytes in array</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdARRAY cmdREAD_SIZE(IExpression<Data16> PRGID, IExpression<Data16> HANDLE, IExpression<Data32> BYTES)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PRGID ?? throw new ArgumentNullException(nameof(PRGID)));
			parameterList.Add(HANDLE ?? throw new ArgumentNullException(nameof(HANDLE)));
			parameterList.Add(BYTES ?? throw new ArgumentNullException(nameof(BYTES)));
			return new cmdARRAY(cmdARRAYValue.READ_SIZE, parameterList.ToArray());
		}

		/// <summary>
		/// Test if file exists
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="FLAG">Exist (0 = no, 1 = yes)</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdEXIST(IExpression<DataString> NAME, IExpression<Data8> FLAG)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(FLAG ?? throw new ArgumentNullException(nameof(FLAG)));
			return new cmdFILENAME(cmdFILENAMEValue.EXIST, parameterList.ToArray());
		}

		/// <summary>
		/// Calculate folder/file size
		/// </summary>
		/// <param name="NAME">File name</param>
		/// <param name="FILES">Total number of files</param>
		/// <param name="SIZE">Total folder size [KB]</param>
		/// <remarks>
		/// if name starts with '~','/' or '.' it is not from current folder
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdTOTALSIZE(IExpression<DataString> NAME, IExpression<Data32> FILES, IExpression<Data32> SIZE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(FILES ?? throw new ArgumentNullException(nameof(FILES)));
			parameterList.Add(SIZE ?? throw new ArgumentNullException(nameof(SIZE)));
			return new cmdFILENAME(cmdFILENAMEValue.TOTALSIZE, parameterList.ToArray());
		}

		/// <summary>
		/// Split filename into Folder, name, extension
		/// </summary>
		/// <param name="FILENAME">File name</param>
		/// <param name="LENGTH">Maximal length for each of the below parameters</param>
		/// <param name="FOLDER">Folder name</param>
		/// <param name="NAME">Name</param>
		/// <param name="EXT">Extension</param>
		/// <remarks>
		/// Example: passing "../folder/subfolder/name.ext" in FILENAME will return "../folder/subfolder" in FOLDER, "name" in NAME and ".ext" in EXT.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdSPLIT(IExpression<DataString> FILENAME, IExpression<Data8> LENGTH, IExpression<DataString> FOLDER, IExpression<DataString> NAME, IExpression<DataString> EXT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FILENAME ?? throw new ArgumentNullException(nameof(FILENAME)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(FOLDER ?? throw new ArgumentNullException(nameof(FOLDER)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(EXT ?? throw new ArgumentNullException(nameof(EXT)));
			return new cmdFILENAME(cmdFILENAMEValue.SPLIT, parameterList.ToArray());
		}

		/// <summary>
		/// Merge Folder, name, extension into filename
		/// </summary>
		/// <param name="FOLDER">Folder name</param>
		/// <param name="NAME">Name</param>
		/// <param name="EXT">Extension</param>
		/// <param name="LENGTH">Maximal length for the below parameter</param>
		/// <param name="FILENAME">File name</param>
		/// <remarks>
		/// Example: passing "../folder/subfolder" in FOLDER, "name" in NAME and ".ext" in EXT will return "../folder/subfolder/name.ext" in FILENAME.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdMERGE(IExpression<DataString> FOLDER, IExpression<DataString> NAME, IExpression<DataString> EXT, IExpression<Data8> LENGTH, IExpression<DataString> FILENAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FOLDER ?? throw new ArgumentNullException(nameof(FOLDER)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(EXT ?? throw new ArgumentNullException(nameof(EXT)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(FILENAME ?? throw new ArgumentNullException(nameof(FILENAME)));
			return new cmdFILENAME(cmdFILENAMEValue.MERGE, parameterList.ToArray());
		}

		/// <summary>
		/// Check filename
		/// </summary>
		/// <param name="FILENAME">File name</param>
		/// <param name="OK">Filename ok (0 = FAIL, 1 = OK)</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdCHECK(IExpression<DataString> FILENAME, IExpression<Data8> OK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FILENAME ?? throw new ArgumentNullException(nameof(FILENAME)));
			parameterList.Add(OK ?? throw new ArgumentNullException(nameof(OK)));
			return new cmdFILENAME(cmdFILENAMEValue.CHECK, parameterList.ToArray());
		}

		/// <summary>
		/// Pack file or folder into "raf" container
		/// </summary>
		/// <param name="FILENAME">File name</param>
		/// <remarks>
		/// .raf is the same as .tar.gz
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdPACK(IExpression<DataString> FILENAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FILENAME ?? throw new ArgumentNullException(nameof(FILENAME)));
			return new cmdFILENAME(cmdFILENAMEValue.PACK, parameterList.ToArray());
		}

		/// <summary>
		/// Unpack "raf" container
		/// </summary>
		/// <param name="FILENAME">File name</param>
		/// <remarks>
		/// .raf is the same as .tar.gz
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdUNPACK(IExpression<DataString> FILENAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(FILENAME ?? throw new ArgumentNullException(nameof(FILENAME)));
			return new cmdFILENAME(cmdFILENAMEValue.UNPACK, parameterList.ToArray());
		}

		/// <summary>
		/// Get current folder name
		/// </summary>
		/// <param name="LENGTH">Maximal length for the below parameter</param>
		/// <param name="FOLDERNAME">Folder name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdFILENAME cmdGET_FOLDERNAME(IExpression<Data8> LENGTH, IExpression<DataString> FOLDERNAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(FOLDERNAME ?? throw new ArgumentNullException(nameof(FOLDERNAME)));
			return new cmdFILENAME(cmdFILENAMEValue.GET_FOLDERNAME, parameterList.ToArray());
		}

		/// <summary>
		/// Get active state
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ACTIVE">Active [0,1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_ON_OFF(IExpression<Data8> HARDWARE, IExpression<Data8> ACTIVE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ACTIVE ?? throw new ArgumentNullException(nameof(ACTIVE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_ON_OFF, parameterList.ToArray());
		}

		/// <summary>
		/// Get visibility state
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="VISIBLE">Visible [0,1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_VISIBLE(IExpression<Data8> HARDWARE, IExpression<Data8> VISIBLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(VISIBLE ?? throw new ArgumentNullException(nameof(VISIBLE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_VISIBLE, parameterList.ToArray());
		}

		/// <summary>
		/// Get status.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Name index</param>
		/// <param name="RESULT">Results</param>
		/// <remarks>
		/// This command gets the result of the command that is being executed. This could be a search or a connection request.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_RESULT(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> RESULT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(RESULT ?? throw new ArgumentNullException(nameof(RESULT)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_RESULT, parameterList.ToArray());
		}

		/// <summary>
		/// Get pin code.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="NAME">Name</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="PINCODE">Pin code</param>
		/// <remarks>
		/// For now "1234" is returned
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_PIN(IExpression<Data8> HARDWARE, IExpression<DataString> NAME, IExpression<Data8> LENGTH, IExpression<DataString> PINCODE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(PINCODE ?? throw new ArgumentNullException(nameof(PINCODE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_PIN, parameterList.ToArray());
		}

		/// <summary>
		/// Gets a list state value. This can be compared to previous values to determine if items are added or removed from a list since the last call.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="STATE">Value that represents the current state</param>
		[Support(Official = false, Xtended = false, Compat = true)]
		public static cmdCOM_GET cmdLIST_STATE(IExpression<Data8> HARDWARE, IExpression<Data16> STATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(STATE ?? throw new ArgumentNullException(nameof(STATE)));
			return new cmdCOM_GET(cmdCOM_GETValue.LIST_STATE, parameterList.ToArray());
		}

		/// <summary>
		/// Get number of item from search.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEMS">No of items in seach list</param>
		/// <remarks>
		/// After a search has been completed, SEARCH ITEMS will return the number of remote devices found.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdSEARCH_ITEMS(IExpression<Data8> HARDWARE, IExpression<Data8> ITEMS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			return new cmdCOM_GET(cmdCOM_GETValue.SEARCH_ITEMS, parameterList.ToArray());
		}

		/// <summary>
		/// Get search item informations.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Item - index in search list</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="NAME">Name</param>
		/// <param name="PAIRED">Paired [0,1]</param>
		/// <param name="CONNECTED">Connected [0,1]</param>
		/// <param name="TYPE">Bluetooth Device Type</param>
		/// <param name="VISIBLE">Visible [0,1]</param>
		/// <remarks>
		/// Used to retrieve the item information in the search list
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdSEARCH_ITEM(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> LENGTH, IExpression<DataString> NAME, IExpression<Data8> PAIRED, IExpression<Data8> CONNECTED, IExpression<Data8> TYPE, IExpression<Data8> VISIBLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(PAIRED ?? throw new ArgumentNullException(nameof(PAIRED)));
			parameterList.Add(CONNECTED ?? throw new ArgumentNullException(nameof(CONNECTED)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			parameterList.Add(VISIBLE ?? throw new ArgumentNullException(nameof(VISIBLE)));
			return new cmdCOM_GET(cmdCOM_GETValue.SEARCH_ITEM, parameterList.ToArray());
		}

		/// <summary>
		/// Get no of item in favourite list.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEMS">No of items in seach list</param>
		/// <remarks>
		/// The number of paired devices, not necessarily visible or present devices
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdFAVOUR_ITEMS(IExpression<Data8> HARDWARE, IExpression<Data8> ITEMS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			return new cmdCOM_GET(cmdCOM_GETValue.FAVOUR_ITEMS, parameterList.ToArray());
		}

		/// <summary>
		/// Get favourite item information.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Item - index in favourite list</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="NAME">Name</param>
		/// <param name="PAIRED">Paired [0,1]</param>
		/// <param name="CONNECTED">Connected [0,1]</param>
		/// <param name="TYPE">Bluetooth Device Type</param>
		/// <remarks>
		/// Used to retrieve the item information in the favourite list. All items in the favourite list are paired devices.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdFAVOUR_ITEM(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> LENGTH, IExpression<DataString> NAME, IExpression<Data8> PAIRED, IExpression<Data8> CONNECTED, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(PAIRED ?? throw new ArgumentNullException(nameof(PAIRED)));
			parameterList.Add(CONNECTED ?? throw new ArgumentNullException(nameof(CONNECTED)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new cmdCOM_GET(cmdCOM_GETValue.FAVOUR_ITEM, parameterList.ToArray());
		}

		/// <summary>
		/// Get bluetooth address information
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="STRING">Bluetooth address</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_ID(IExpression<Data8> HARDWARE, IExpression<Data8> LENGTH, IExpression<DataString> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_ID, parameterList.ToArray());
		}

		/// <summary>
		/// Gets the name of the brick
		/// </summary>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="NAME">Brick name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_BRICKNAME(IExpression<Data8> LENGTH, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_BRICKNAME, parameterList.ToArray());
		}

		/// <summary>
		/// Gets the network information. WIFI only
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="NAME">Access point (AP) name</param>
		/// <param name="MAC">MAC address</param>
		/// <param name="IP">IP address</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_NETWORK(IExpression<Data8> HARDWARE, IExpression<Data8> LENGTH, IExpression<DataString> NAME, IExpression<DataString> MAC, IExpression<DataString> IP)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(MAC ?? throw new ArgumentNullException(nameof(MAC)));
			parameterList.Add(IP ?? throw new ArgumentNullException(nameof(IP)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_NETWORK, parameterList.ToArray());
		}

		/// <summary>
		/// Return if hardare is present. WIFI only
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="OK">Present [0,1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_PRESENT(IExpression<Data8> HARDWARE, IExpression<Data8> OK)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(OK ?? throw new ArgumentNullException(nameof(OK)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_PRESENT, parameterList.ToArray());
		}

		/// <summary>
		/// Returns the encryption mode of the hardware. WIFI only
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Item - index in favourite list</param>
		/// <param name="TYPE">Encryption type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_ENCRYPT(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_ENCRYPT, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdCONNEC_ITEMS(IExpression<Data8> HARDWARE, IExpression<Data8> ITEMS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEMS ?? throw new ArgumentNullException(nameof(ITEMS)));
			return new cmdCOM_GET(cmdCOM_GETValue.CONNEC_ITEMS, parameterList.ToArray());
		}

		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdCONNEC_ITEM(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> LENGTH, IExpression<Data8> NAME, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new cmdCOM_GET(cmdCOM_GETValue.CONNEC_ITEM, parameterList.ToArray());
		}

		/// <summary>
		/// Returns the encryption mode of the hardware. WIFI only
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="LENGTH">Max length of returned string</param>
		/// <param name="NAME">Name</param>
		/// <param name="TYPE">Encryption type</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_INCOMING(IExpression<Data8> HARDWARE, IExpression<Data8> LENGTH, IExpression<DataString> NAME, IExpression<Data8> TYPE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(TYPE ?? throw new ArgumentNullException(nameof(TYPE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_INCOMING, parameterList.ToArray());
		}

		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ACTIVE">Active [0,1], 1 = on, 0 = off</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_GET cmdGET_MODE2(IExpression<Data8> HARDWARE, IExpression<Data8> ACTIVE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ACTIVE ?? throw new ArgumentNullException(nameof(ACTIVE)));
			return new cmdCOM_GET(cmdCOM_GETValue.GET_MODE2, parameterList.ToArray());
		}

		/// <summary>
		/// Set active state, either on or off
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ACTIVE">Active [0,1], 1 = on, 0 = off</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_ON_OFF(IExpression<Data8> HARDWARE, IExpression<Data8> ACTIVE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ACTIVE ?? throw new ArgumentNullException(nameof(ACTIVE)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_ON_OFF, parameterList.ToArray());
		}

		/// <summary>
		/// Set visibility state - Only available for bluetooth
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="VISIBLE">Visible [0,1], 1 = visible, 0 = invisible</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_VISIBLE(IExpression<Data8> HARDWARE, IExpression<Data8> VISIBLE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(VISIBLE ?? throw new ArgumentNullException(nameof(VISIBLE)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_VISIBLE, parameterList.ToArray());
		}

		/// <summary>
		/// Starts or or stops the search for remote devices
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="SEARCH">Search [0,1] 0 = stop search, 1 = start search</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_SEARCH(IExpression<Data8> HARDWARE, IExpression<Data8> SEARCH)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(SEARCH ?? throw new ArgumentNullException(nameof(SEARCH)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_SEARCH, parameterList.ToArray());
		}

		/// <summary>
		/// Set pin code.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="NAME">Name</param>
		/// <param name="PINCODE">Pin code</param>
		/// <remarks>
		/// Set the pincode for a remote device. Used when requested by bluetooth. Not at this point possible by user program.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_PIN(IExpression<Data8> HARDWARE, IExpression<DataString> NAME, IExpression<DataString> PINCODE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(PINCODE ?? throw new ArgumentNullException(nameof(PINCODE)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_PIN, parameterList.ToArray());
		}

		/// <summary>
		/// Set pin code.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ACCEPT">Acceptance [0,1] 0 = reject 1 = accept</param>
		/// <remarks>
		/// Set the pincode for a remote device. Used when requested by bluetooth. Not at this point possible by user program.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_PASSKEY(IExpression<Data8> HARDWARE, IExpression<Data8> ACCEPT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ACCEPT ?? throw new ArgumentNullException(nameof(ACCEPT)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_PASSKEY, parameterList.ToArray());
		}

		/// <summary>
		/// Initiate or close the connection request to a remote device by the specified name.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="NAME">Name</param>
		/// <param name="CONNECTION">Connect [0,1], 1 = Connect, 0 = Disconnect</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_CONNECTION(IExpression<Data8> HARDWARE, IExpression<DataString> NAME, IExpression<Data8> CONNECTION)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			parameterList.Add(CONNECTION ?? throw new ArgumentNullException(nameof(CONNECTION)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_CONNECTION, parameterList.ToArray());
		}

		/// <summary>
		/// Sets the name of the brick
		/// </summary>
		/// <param name="NAME">Name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_BRICKNAME(IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_BRICKNAME, parameterList.ToArray());
		}

		/// <summary>
		/// Moves the index in list one step up.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Index in table</param>
		/// <remarks>
		/// Used to re-arrange WIFI list. Only used for WIFI.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_MOVEUP(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_MOVEUP, parameterList.ToArray());
		}

		/// <summary>
		/// Moves the index in list one step down.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Index in table</param>
		/// <remarks>
		/// Used to re-arrange WIFI list. Only used for WIFI.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_MOVEDOWN(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_MOVEDOWN, parameterList.ToArray());
		}

		/// <summary>
		/// Sets the encryption type for an item in a list.
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ITEM">Index in table</param>
		/// <param name="ENCRYPT">Encryption type</param>
		/// <remarks>
		/// Only used for WIFI.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_ENCRYPT(IExpression<Data8> HARDWARE, IExpression<Data8> ITEM, IExpression<Data8> ENCRYPT)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ITEM ?? throw new ArgumentNullException(nameof(ITEM)));
			parameterList.Add(ENCRYPT ?? throw new ArgumentNullException(nameof(ENCRYPT)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_ENCRYPT, parameterList.ToArray());
		}

		/// <summary>
		/// Sets the SSID name. Only used for WIFI
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="NAME">Name</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_SSID(IExpression<Data8> HARDWARE, IExpression<DataString> NAME)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(NAME ?? throw new ArgumentNullException(nameof(NAME)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_SSID, parameterList.ToArray());
		}

		/// <summary>
		/// Set active mode state, either active or not
		/// </summary>
		/// <param name="HARDWARE">Hardware Transport Layer</param>
		/// <param name="ACTIVE">Active [0,1], 1 = on, 0 = off</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdCOM_SET cmdSET_MODE2(IExpression<Data8> HARDWARE, IExpression<Data8> ACTIVE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(HARDWARE ?? throw new ArgumentNullException(nameof(HARDWARE)));
			parameterList.Add(ACTIVE ?? throw new ArgumentNullException(nameof(ACTIVE)));
			return new cmdCOM_SET(cmdCOM_SETValue.SET_MODE2, parameterList.ToArray());
		}

		/// <summary>
		/// Enables test byte codes for 10 seconds
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_OPEN()
		{
			var parameterList = new List<IByteCode>();
			return new cmdTST(cmdTSTValue.TST_OPEN, parameterList.ToArray());
		}

		/// <summary>
		/// Disables test byte codes
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_CLOSE()
		{
			var parameterList = new List<IByteCode>();
			return new cmdTST(cmdTSTValue.TST_CLOSE, parameterList.ToArray());
		}

		/// <summary>
		/// Read connector pin status
		/// </summary>
		/// <param name="PORT">Input connector [0..3], output connector [16..19]</param>
		/// <param name="LENGTH">Number of pins in returned string</param>
		/// <param name="STRING">String variable start index ('0' = low, '1' = high)</param>
		/// <remarks>
		/// Input -----— STRING[0] Pin1 I_ONx current source control output ['0','1'] STRING[1] Pin2 LEGDETx ['0','1'] STRING[2] Pin5 DIGIx0 ['0','1'] STRING[3] Pin6 DIGIx1 ['0','1'] STRING[4] - TXINx_EN ['0','1']
		/// Output -----— STRING[0] Pin1 MxIN0 ['0','1'] STRING[1] Pin2 MxIN1 ['0','1'] STRING[2] Pin5 DETx0 ['0','1'] STRING[3] Pin5 INTx0 ['0','1'] STRING[4] Pin6 DIRx ['0','1']
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_READ_PINS(IExpression<Data8> PORT, IExpression<Data8> LENGTH, IExpression<Data8> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PORT ?? throw new ArgumentNullException(nameof(PORT)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdTST(cmdTSTValue.TST_READ_PINS, parameterList.ToArray());
		}

		/// <summary>
		/// Write to connector pin
		/// </summary>
		/// <param name="PORT">Input connector [0..3], output connector [16..19]</param>
		/// <param name="LENGTH">Number of pins in returned string</param>
		/// <param name="STRING">String variable start index ('0' = set low, '1' = set high, 'X' = tristate, '-' = don't touch)</param>
		/// <remarks>
		/// Input -----— STRING[0] Pin1 I_ONx current source control output ['0','1','X','-'] STRING[1] Pin2 LEGDETx ['0','1','X','-'] STRING[2] Pin5 DIGIx0 ['0','1','X','-'] STRING[3] Pin6 DIGIx1 ['0','1','X','-'] STRING[4] - TXINx_EN ['0','1','X','-']
		/// Output -----— STRING[0] Pin1 MxIN0 ['0','1','X','-'] STRING[1] Pin2 MxIN1 ['0','1','X','-'] STRING[2] Pin5 DETx0 Write ['0','1','X','-'] STRING[3] Pin5 INTx0 Read ['0','1','X','-'] STRING[4] Pin6 DIRx ['0','1','X','-']
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_WRITE_PINS(IExpression<Data8> PORT, IExpression<Data8> LENGTH, IExpression<Data8> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PORT ?? throw new ArgumentNullException(nameof(PORT)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdTST(cmdTSTValue.TST_WRITE_PINS, parameterList.ToArray());
		}

		/// <summary>
		/// Read raw count from ADC
		/// </summary>
		/// <param name="INDEX">Input mapped index (see remarks) [0..15]</param>
		/// <param name="VALUE">Raw count [0..4095]</param>
		/// <remarks>
		/// INDEX 0..3 Input connector pin 1 (0=conn1, 1=conn2, 2=conn3, 3=conn4) INDEX 4..7 Input connector pin 6 (4=conn1, 5=conn2, 6=conn3, 7=conn4) INDEX 8..11 Output connector pin 5 (8=conn1, 9=conn2, 10=conn3, 11=conn4)
		/// INDEX 12 Battery temperature INDEX 13 Current flowing to motors INDEX 14 Current flowing from the battery INDEX 15 Voltage at battery cell 1, 2, 3,4, 5, and 6
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_READ_ADC(IExpression<Data8> INDEX, IExpression<Data16> VALUE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(INDEX ?? throw new ArgumentNullException(nameof(INDEX)));
			parameterList.Add(VALUE ?? throw new ArgumentNullException(nameof(VALUE)));
			return new cmdTST(cmdTSTValue.TST_READ_ADC, parameterList.ToArray());
		}

		/// <summary>
		/// Write data to port through UART
		/// </summary>
		/// <param name="PORT">Input connector [0..3]</param>
		/// <param name="LENGTH">Length of string to write [0..63]</param>
		/// <param name="STRING">String of data</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_WRITE_UART(IExpression<Data8> PORT, IExpression<Data8> LENGTH, IExpression<Data8> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PORT ?? throw new ArgumentNullException(nameof(PORT)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdTST(cmdTSTValue.TST_WRITE_UART, parameterList.ToArray());
		}

		/// <summary>
		/// Read data from port through UART
		/// </summary>
		/// <param name="PORT">Input connector [0..3]</param>
		/// <param name="LENGTH">Length of string to write [0..63]</param>
		/// <param name="STRING">String of data</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_READ_UART(IExpression<Data8> PORT, IExpression<Data8> LENGTH, IExpression<Data8> STRING)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(PORT ?? throw new ArgumentNullException(nameof(PORT)));
			parameterList.Add(LENGTH ?? throw new ArgumentNullException(nameof(LENGTH)));
			parameterList.Add(STRING ?? throw new ArgumentNullException(nameof(STRING)));
			return new cmdTST(cmdTSTValue.TST_READ_UART, parameterList.ToArray());
		}

		/// <summary>
		/// Enable all UARTs
		/// </summary>
		/// <param name="BITRATE">Bit rate [2400..115200 b/S]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_ENABLE_UART(IExpression<Data32> BITRATE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(BITRATE ?? throw new ArgumentNullException(nameof(BITRATE)));
			return new cmdTST(cmdTSTValue.TST_ENABLE_UART, parameterList.ToArray());
		}

		/// <summary>
		/// Disable all UARTs
		/// </summary>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_DISABLE_UART()
		{
			var parameterList = new List<IByteCode>();
			return new cmdTST(cmdTSTValue.TST_DISABLE_UART, parameterList.ToArray());
		}

		/// <summary>
		/// Read accu switch state
		/// </summary>
		/// <param name="ACTIVE">State [0..1]</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_ACCU_SWITCH(IExpression<Data8> ACTIVE)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(ACTIVE ?? throw new ArgumentNullException(nameof(ACTIVE)));
			return new cmdTST(cmdTSTValue.TST_ACCU_SWITCH, parameterList.ToArray());
		}

		/// <summary>
		/// Turn on mode2
		/// </summary>
		/// <remarks>
		/// This only works on pre-release EV3 hardware.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_BOOT_MODE2()
		{
			var parameterList = new List<IByteCode>();
			return new cmdTST(cmdTSTValue.TST_BOOT_MODE2, parameterList.ToArray());
		}

		/// <summary>
		/// Read mode2 status
		/// </summary>
		/// <param name="STATUS">State [0..2]</param>
		/// <remarks>
		/// This only works on pre-release EV3 hardware.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_POLL_MODE2(IExpression<Data8> STATUS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATUS ?? throw new ArgumentNullException(nameof(STATUS)));
			return new cmdTST(cmdTSTValue.TST_POLL_MODE2, parameterList.ToArray());
		}

		/// <summary>
		/// Closes mode2
		/// </summary>
		/// <remarks>
		/// This only works on pre-release EV3 hardware.
		/// </remarks>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_CLOSE_MODE2()
		{
			var parameterList = new List<IByteCode>();
			return new cmdTST(cmdTSTValue.TST_CLOSE_MODE2, parameterList.ToArray());
		}

		/// <summary>
		/// Read RAM test status status
		/// </summary>
		/// <param name="STATUS">State [0,1] 0 = FAIL, 1 = SUCCESS</param>
		[Support(Official = true, Xtended = true, Compat = true)]
		public static cmdTST cmdTST_RAM_CHECK(IExpression<Data8> STATUS)
		{
			var parameterList = new List<IByteCode>();
			parameterList.Add(STATUS ?? throw new ArgumentNullException(nameof(STATUS)));
			return new cmdTST(cmdTSTValue.TST_RAM_CHECK, parameterList.ToArray());
		}

	}

	enum OpcodeValue
	{
		ERROR = 0x00,
		NOP = 0x01,
		PROGRAM_STOP = 0x02,
		PROGRAM_START = 0x03,
		OBJECT_STOP = 0x04,
		OBJECT_START = 0x05,
		OBJECT_TRIG = 0x06,
		OBJECT_WAIT = 0x07,
		RETURN = 0x08,
		CALL = 0x09,
		OBJECT_END = 0x0A,
		SLEEP = 0x0B,
		PROGRAM_INFO = 0x0C,
		LABEL = 0x0D,
		PROBE = 0x0E,
		DO = 0x0F,
		ADD8 = 0x10,
		ADD16 = 0x11,
		ADD32 = 0x12,
		ADDF = 0x13,
		SUB8 = 0x14,
		SUB16 = 0x15,
		SUB32 = 0x16,
		SUBF = 0x17,
		MUL8 = 0x18,
		MUL16 = 0x19,
		MUL32 = 0x1A,
		MULF = 0x1B,
		DIV8 = 0x1C,
		DIV16 = 0x1D,
		DIV32 = 0x1E,
		DIVF = 0x1F,
		OR8 = 0x20,
		OR16 = 0x21,
		OR32 = 0x22,
		AND8 = 0x24,
		AND16 = 0x25,
		AND32 = 0x26,
		XOR8 = 0x28,
		XOR16 = 0x29,
		XOR32 = 0x2A,
		RL8 = 0x2C,
		RL16 = 0x2D,
		RL32 = 0x2E,
		INIT_BYTES = 0x2F,
		MOVE8_8 = 0x30,
		MOVE8_16 = 0x31,
		MOVE8_32 = 0x32,
		MOVE8_F = 0x33,
		MOVE16_8 = 0x34,
		MOVE16_16 = 0x35,
		MOVE16_32 = 0x36,
		MOVE16_F = 0x37,
		MOVE32_8 = 0x38,
		MOVE32_16 = 0x39,
		MOVE32_32 = 0x3A,
		MOVE32_F = 0x3B,
		MOVEF_8 = 0x3C,
		MOVEF_16 = 0x3D,
		MOVEF_32 = 0x3E,
		MOVEF_F = 0x3F,
		JR = 0x40,
		JR_FALSE = 0x41,
		JR_TRUE = 0x42,
		JR_NAN = 0x43,
		CP_LT8 = 0x44,
		CP_LT16 = 0x45,
		CP_LT32 = 0x46,
		CP_LTF = 0x47,
		CP_GT8 = 0x48,
		CP_GT16 = 0x49,
		CP_GT32 = 0x4A,
		CP_GTF = 0x4B,
		CP_EQ8 = 0x4C,
		CP_EQ16 = 0x4D,
		CP_EQ32 = 0x4E,
		CP_EQF = 0x4F,
		CP_NEQ8 = 0x50,
		CP_NEQ16 = 0x51,
		CP_NEQ32 = 0x52,
		CP_NEQF = 0x53,
		CP_LTEQ8 = 0x54,
		CP_LTEQ16 = 0x55,
		CP_LTEQ32 = 0x56,
		CP_LTEQF = 0x57,
		CP_GTEQ8 = 0x58,
		CP_GTEQ16 = 0x59,
		CP_GTEQ32 = 0x5A,
		CP_GTEQF = 0x5B,
		SELECT8 = 0x5C,
		SELECT16 = 0x5D,
		SELECT32 = 0x5E,
		SELECTF = 0x5F,
		SYSTEM = 0x60,
		PORT_CNV_OUTPUT = 0x61,
		PORT_CNV_INPUT = 0x62,
		NOTE_TO_FREQ = 0x63,
		JR_LT8 = 0x64,
		JR_LT16 = 0x65,
		JR_LT32 = 0x66,
		JR_LTF = 0x67,
		JR_GT8 = 0x68,
		JR_GT16 = 0x69,
		JR_GT32 = 0x6A,
		JR_GTF = 0x6B,
		JR_EQ8 = 0x6C,
		JR_EQ16 = 0x6D,
		JR_EQ32 = 0x6E,
		JR_EQF = 0x6F,
		JR_NEQ8 = 0x70,
		JR_NEQ16 = 0x71,
		JR_NEQ32 = 0x72,
		JR_NEQF = 0x73,
		JR_LTEQ8 = 0x74,
		JR_LTEQ16 = 0x75,
		JR_LTEQ32 = 0x76,
		JR_LTEQF = 0x77,
		JR_GTEQ8 = 0x78,
		JR_GTEQ16 = 0x79,
		JR_GTEQ32 = 0x7A,
		JR_GTEQF = 0x7B,
		INFO = 0x7C,
		STRINGS = 0x7D,
		MEMORY_WRITE = 0x7E,
		MEMORY_READ = 0x7F,
		UI_FLUSH = 0x80,
		UI_READ = 0x81,
		UI_WRITE = 0x82,
		UI_BUTTON = 0x83,
		UI_DRAW = 0x84,
		TIMER_WAIT = 0x85,
		TIMER_READY = 0x86,
		TIMER_READ = 0x87,
		BP0 = 0x88,
		BP1 = 0x89,
		BP2 = 0x8A,
		BP3 = 0x8B,
		BP_SET = 0x8C,
		MATH = 0x8D,
		RANDOM = 0x8E,
		TIMER_READ_US = 0x8F,
		KEEP_ALIVE = 0x90,
		COM_READ = 0x91,
		COM_WRITE = 0x92,
		SOUND = 0x94,
		SOUND_TEST = 0x95,
		SOUND_READY = 0x96,
		INPUT_SAMPLE = 0x97,
		INPUT_DEVICE_LIST = 0x98,
		INPUT_DEVICE = 0x99,
		INPUT_READ = 0x9A,
		INPUT_TEST = 0x9B,
		INPUT_READY = 0x9C,
		INPUT_READSI = 0x9D,
		INPUT_READEXT = 0x9E,
		INPUT_WRITE = 0x9F,
		OUTPUT_GET_TYPE = 0xA0,
		OUTPUT_SET_TYPE = 0xA1,
		OUTPUT_RESET = 0xA2,
		OUTPUT_STOP = 0xA3,
		OUTPUT_POWER = 0xA4,
		OUTPUT_SPEED = 0xA5,
		OUTPUT_START = 0xA6,
		OUTPUT_POLARITY = 0xA7,
		OUTPUT_READ = 0xA8,
		OUTPUT_TEST = 0xA9,
		OUTPUT_READY = 0xAA,
		OUTPUT_POSITION = 0xAB,
		OUTPUT_STEP_POWER = 0xAC,
		OUTPUT_TIME_POWER = 0xAD,
		OUTPUT_STEP_SPEED = 0xAE,
		OUTPUT_TIME_SPEED = 0xAF,
		OUTPUT_STEP_SYNC = 0xB0,
		OUTPUT_TIME_SYNC = 0xB1,
		OUTPUT_CLR_COUNT = 0xB2,
		OUTPUT_GET_COUNT = 0xB3,
		OUTPUT_PRG_STOP = 0xB4,
		FILE = 0xC0,
		ARRAY = 0xC1,
		ARRAY_WRITE = 0xC2,
		ARRAY_READ = 0xC3,
		ARRAY_APPEND = 0xC4,
		MEMORY_USAGE = 0xC5,
		FILENAME = 0xC6,
		READ8 = 0xC8,
		READ16 = 0xC9,
		READ32 = 0xCA,
		READF = 0xCB,
		WRITE8 = 0xCC,
		WRITE16 = 0xCD,
		WRITE32 = 0xCE,
		WRITEF = 0xCF,
		COM_READY = 0xD0,
		COM_READDATA = 0xD1,
		COM_WRITEDATA = 0xD2,
		COM_GET = 0xD3,
		COM_SET = 0xD4,
		COM_TEST = 0xD5,
		COM_REMOVE = 0xD6,
		COM_WRITEFILE = 0xD7,
		MAILBOX_OPEN = 0xD8,
		MAILBOX_WRITE = 0xD9,
		MAILBOX_READ = 0xDA,
		MAILBOX_TEST = 0xDB,
		MAILBOX_READY = 0xDC,
		MAILBOX_CLOSE = 0xDD,
		INPUT_SET_CONN = 0xE0,
		INPUT_IIC_READ = 0xE1,
		INPUT_IIC_STATUS = 0xE2,
		INPUT_IIC_WRITE = 0xE3,
		INPUT_SET_AUTOID = 0xE4,
		MAILBOX_SIZE = 0xE5,
		FILE_MD5SUM = 0xE6,
		DYNLOAD_VMLOAD = 0xF0,
		DYNLOAD_VMEXIT = 0xF1,
		DYNLOAD_ENTRY_0 = 0xF2,
		DYNLOAD_ENTRY_1 = 0xF3,
		DYNLOAD_ENTRY_2 = 0xF4,
		DYNLOAD_ENTRY_3 = 0xF5,
		DYNLOAD_ENTRY_4 = 0xF6,
		DYNLOAD_ENTRY_5 = 0xF7,
		DYNLOAD_ENTRY_6 = 0xF8,
		DYNLOAD_ENTRY_7 = 0xF9,
		DYNLOAD_ENTRY_8 = 0xFA,
		DYNLOAD_ENTRY_9 = 0xFB,
		DYNLOAD_GET_VM = 0xFC,
		TST = 0xFF,
	}
	enum cmdPROGRAM_INFOValue
	{
		OBJ_STOP = 0x00,
		OBJ_START = 0x04,
		GET_STATUS = 0x16,
		GET_SPEED = 0x17,
		GET_PRGRESULT = 0x18,
		SET_INSTR = 0x19,
		GET_PRGNAME = 0x1A,
	}

	enum cmdINFOValue
	{
		SET_ERROR = 0x01,
		GET_ERROR = 0x02,
		ERRORTEXT = 0x03,
		GET_VOLUME = 0x04,
		SET_VOLUME = 0x05,
		GET_MINUTES = 0x06,
		SET_MINUTES = 0x07,
	}

	enum cmdSTRINGSValue
	{
		GET_SIZE = 0x01,
		ADD = 0x02,
		COMPARE = 0x03,
		DUPLICATE = 0x05,
		VALUE_TO_STRING = 0x06,
		STRING_TO_VALUE = 0x07,
		STRIP = 0x08,
		NUMBER_TO_STRING = 0x09,
		SUB = 0x0A,
		VALUE_FORMATTED = 0x0B,
		NUMBER_FORMATTED = 0x0C,
	}

	enum cmdUI_READValue
	{
		GET_VBATT = 0x01,
		GET_IBATT = 0x02,
		GET_OS_VERS = 0x03,
		GET_EVENT = 0x04,
		GET_TBATT = 0x05,
		GET_IINT = 0x06,
		GET_IMOTOR = 0x07,
		GET_STRING = 0x08,
		GET_HW_VERS = 0x09,
		GET_FW_VERS = 0x0A,
		GET_FW_BUILD = 0x0B,
		GET_OS_BUILD = 0x0C,
		GET_ADDRESS = 0x0D,
		GET_CODE = 0x0E,
		KEY = 0x0F,
		GET_SHUTDOWN = 0x10,
		GET_WARNING = 0x11,
		GET_LBATT = 0x12,
		TEXTBOX_READ = 0x15,
		GET_VERSION = 0x1A,
		GET_IP = 0x1B,
		GET_POWER = 0x1D,
		GET_SDCARD = 0x1E,
		GET_USBSTICK = 0x1F,
	}

	enum cmdUI_WRITEValue
	{
		WRITE_FLUSH = 0x01,
		FLOATVALUE = 0x02,
		STAMP = 0x03,
		PUT_STRING = 0x08,
		VALUE8 = 0x09,
		VALUE16 = 0x0A,
		VALUE32 = 0x0B,
		VALUEF = 0x0C,
		ADDRESS = 0x0D,
		CODE = 0x0E,
		DOWNLOAD_END = 0x0F,
		SCREEN_BLOCK = 0x10,
		ALLOW_PULSE = 0x11,
		SET_PULSE = 0x12,
		TEXTBOX_APPEND = 0x15,
		SET_BUSY = 0x16,
		SET_TESTPIN = 0x18,
		INIT_RUN = 0x19,
		UPDATE_RUN = 0x1A,
		LED = 0x1B,
		POWER = 0x1D,
		GRAPH_SAMPLE = 0x1E,
		TERMINAL = 0x1F,
	}

	enum cmdUI_BUTTONValue
	{
		SHORTPRESS = 0x01,
		LONGPRESS = 0x02,
		WAIT_FOR_PRESS = 0x03,
		FLUSH = 0x04,
		PRESS = 0x05,
		RELEASE = 0x06,
		GET_HORZ = 0x07,
		GET_VERT = 0x08,
		PRESSED = 0x09,
		SET_BACK_BLOCK = 0x0A,
		GET_BACK_BLOCK = 0x0B,
		TESTSHORTPRESS = 0x0C,
		TESTLONGPRESS = 0x0D,
		GET_BUMBED = 0x0E,
		GET_BUMPED = 0x0E,
		GET_CLICK = 0x0F,
	}

	enum cmdUI_DRAWValue
	{
		UPDATE = 0x00,
		CLEAN = 0x01,
		PIXEL = 0x02,
		LINE = 0x03,
		CIRCLE = 0x04,
		TEXT = 0x05,
		ICON = 0x06,
		PICTURE = 0x07,
		VALUE = 0x08,
		FILLRECT = 0x09,
		RECT = 0x0A,
		RECTANGLE = 0x0A,
		NOTIFICATION = 0x0B,
		QUESTION = 0x0C,
		KEYBOARD = 0x0D,
		BROWSE = 0x0E,
		VERTBAR = 0x0F,
		INVERSERECT = 0x10,
		SELECT_FONT = 0x11,
		TOPLINE = 0x12,
		FILLWINDOW = 0x13,
		SCROLL = 0x14,
		DOTLINE = 0x15,
		VIEW_VALUE = 0x16,
		VIEW_UNIT = 0x17,
		FILLCIRCLE = 0x18,
		STORE = 0x19,
		RESTORE = 0x1A,
		ICON_QUESTION = 0x1B,
		BMPFILE = 0x1C,
		POPUP = 0x1D,
		GRAPH_SETUP = 0x1E,
		GRAPH_DRAW = 0x1F,
		TEXTBOX = 0x20,
	}

	enum cmdMATHValue
	{
		EXP = 0x01,
		MOD = 0x02,
		FLOOR = 0x03,
		CEIL = 0x04,
		ROUND = 0x05,
		ABS = 0x06,
		NEGATE = 0x07,
		SQRT = 0x08,
		LOG = 0x09,
		LN = 0x0A,
		SIN = 0x0B,
		COS = 0x0C,
		TAN = 0x0D,
		ASIN = 0x0E,
		ACOS = 0x0F,
		ATAN = 0x10,
		MOD8 = 0x11,
		MOD16 = 0x12,
		MOD32 = 0x13,
		POW = 0x14,
		TRUNC = 0x15,
	}

	enum cmdCOM_READValue
	{
		COMMAND = 0x0E,
	}

	enum cmdCOM_WRITEValue
	{
		REPLY = 0x0E,
	}

	enum cmdSOUNDValue
	{
		BREAK = 0x00,
		TONE = 0x01,
		PLAY = 0x02,
		REPEAT = 0x03,
		SERVICE = 0x04,
	}

	enum cmdINPUT_DEVICEValue
	{
		INSERT_TYPE = 0x01,
		GET_FORMAT = 0x02,
		CAL_MINMAX = 0x03,
		CAL_DEFAULT = 0x04,
		GET_TYPEMODE = 0x05,
		GET_SYMBOL = 0x06,
		CAL_MIN = 0x07,
		CAL_MAX = 0x08,
		SETUP = 0x09,
		CLR_ALL = 0x0A,
		GET_RAW = 0x0B,
		GET_CONNECTION = 0x0C,
		STOP_ALL = 0x0D,
		SET_TYPEMODE = 0x0E,
		READY_IIC = 0x0F,
		GET_NAME = 0x15,
		GET_MODENAME = 0x16,
		SET_RAW = 0x17,
		GET_FIGURES = 0x18,
		GET_CHANGES = 0x19,
		CLR_CHANGES = 0x1A,
		READY_PCT = 0x1B,
		READY_RAW = 0x1C,
		READY_SI = 0x1D,
		GET_MINMAX = 0x1E,
		GET_BUMPS = 0x1F,
	}

	enum cmdFILEValue
	{
		OPEN_APPEND = 0x00,
		OPEN_READ = 0x01,
		OPEN_WRITE = 0x02,
		READ_VALUE = 0x03,
		WRITE_VALUE = 0x04,
		READ_TEXT = 0x05,
		WRITE_TEXT = 0x06,
		CLOSE = 0x07,
		LOAD_IMAGE = 0x08,
		GET_HANDLE = 0x09,
		MAKE_FOLDER = 0x0A,
		GET_POOL = 0x0B,
		SET_LOG_SYNC_TIME = 0x0C,
		GET_FOLDERS = 0x0D,
		GET_LOG_SYNC_TIME = 0x0E,
		GET_SUBFOLDER_NAME = 0x0F,
		WRITE_LOG = 0x10,
		CLOSE_LOG = 0x11,
		GET_IMAGE = 0x12,
		GET_ITEM = 0x13,
		GET_CACHE_FILES = 0x14,
		PUT_CACHE_FILE = 0x15,
		GET_CACHE_FILE = 0x16,
		DEL_CACHE_FILE = 0x17,
		DEL_SUBFOLDER = 0x18,
		GET_LOG_NAME = 0x19,
		OPEN_LOG = 0x1B,
		READ_BYTES = 0x1C,
		WRITE_BYTES = 0x1D,
		REMOVE = 0x1E,
		MOVE = 0x1F,
	}

	enum cmdARRAYValue
	{
		DELETE = 0x00,
		DESTROY = 0x00,
		CREATE8 = 0x01,
		CREATE16 = 0x02,
		CREATE32 = 0x03,
		CREATEF = 0x04,
		RESIZE = 0x05,
		FILL = 0x06,
		COPY = 0x07,
		INIT8 = 0x08,
		INIT16 = 0x09,
		INIT32 = 0x0A,
		INITF = 0x0B,
		SIZE = 0x0C,
		SET_SIZE = 0x0C,
		READ_CONTENT = 0x0D,
		WRITE_CONTENT = 0x0E,
		READ_SIZE = 0x0F,
	}

	enum cmdFILENAMEValue
	{
		EXIST = 0x10,
		TOTALSIZE = 0x11,
		SPLIT = 0x12,
		MERGE = 0x13,
		CHECK = 0x14,
		PACK = 0x15,
		UNPACK = 0x16,
		GET_FOLDERNAME = 0x17,
	}

	enum cmdCOM_GETValue
	{
		GET_ON_OFF = 0x01,
		GET_VISIBLE = 0x02,
		GET_RESULT = 0x04,
		GET_PIN = 0x05,
		LIST_STATE = 0x07,
		SEARCH_ITEMS = 0x08,
		SEARCH_ITEM = 0x09,
		FAVOUR_ITEMS = 0x0A,
		FAVOUR_ITEM = 0x0B,
		GET_ID = 0x0C,
		GET_BRICKNAME = 0x0D,
		GET_NETWORK = 0x0E,
		GET_PRESENT = 0x0F,
		GET_ENCRYPT = 0x10,
		CONNEC_ITEMS = 0x11,
		CONNEC_ITEM = 0x12,
		GET_INCOMING = 0x13,
		GET_MODE2 = 0x14,
	}

	enum cmdCOM_SETValue
	{
		SET_ON_OFF = 0x01,
		SET_VISIBLE = 0x02,
		SET_SEARCH = 0x03,
		SET_PIN = 0x05,
		SET_PASSKEY = 0x06,
		SET_CONNECTION = 0x07,
		SET_BRICKNAME = 0x08,
		SET_MOVEUP = 0x09,
		SET_MOVEDOWN = 0x0A,
		SET_ENCRYPT = 0x0B,
		SET_SSID = 0x0C,
		SET_MODE2 = 0x0D,
	}

	enum cmdTSTValue
	{
		TST_OPEN = 0x0A,
		TST_CLOSE = 0x0B,
		TST_READ_PINS = 0x0C,
		TST_WRITE_PINS = 0x0D,
		TST_READ_ADC = 0x0E,
		TST_WRITE_UART = 0x0F,
		TST_READ_UART = 0x10,
		TST_ENABLE_UART = 0x11,
		TST_DISABLE_UART = 0x12,
		TST_ACCU_SWITCH = 0x13,
		TST_BOOT_MODE2 = 0x14,
		TST_POLL_MODE2 = 0x15,
		TST_CLOSE_MODE2 = 0x16,
		TST_RAM_CHECK = 0x17,
	}

}

#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore IDE0028 // Collection Initalization

