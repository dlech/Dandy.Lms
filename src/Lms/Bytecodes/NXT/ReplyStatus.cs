using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes.NXT
{
    /// <summary>
    /// Possible status codes returned by NXT commands.
    /// </summary>
    /// <seealso cref="CommandFailedException"/>
    public enum ReplyStatus
    {
        /// <summary>
        /// The command was successful.
        /// </summary>
        Success = 0x00,

        // direct commands

        /// <summary>
        /// Pending communication transaction in progress.
        /// </summary>
        Busy = 0x20,

        /// <summary>
        /// Specified mailbox queue is empty.
        /// </summary>
        MailboxQueueEmpty = 0x40,

        /// <summary>
        /// Request failed (e.g. specified file not found).
        /// </summary>
        RequestFailed = 0xBD,

        /// <summary>
        /// Unknwon command opcode.
        /// </summary>
        UnknownCommandOpcode = 0xBE,

        /// <summary>
        /// The packet is maformed.
        /// </summary>
        InsanePacket = 0xBF,

        /// <summary>
        /// Data contains out-of-range values.
        /// </summary>
        DataOutOfRange = 0xC0,

        /// <summary>
        /// Communication bus error.
        /// </summary>
        CommBusError = 0xDD,

        /// <summary>
        /// No free memory in communications buffer.
        /// </summary>
        CommBufferFull = 0xDE,

        /// <summary>
        /// Specified channel/connection is invalid.
        /// </summary>
        InvalidCommChannel = 0xDF,

        /// <summary>
        /// Specified channel/connection is not configured or busy.
        /// </summary>
        CommChannelBusy = 0xE0,

        /// <summary>
        /// No active program.
        /// </summary>
        NoActiveProgram = 0xEC,

        /// <summary>
        /// Illegal size specified.
        /// </summary>
        IllegalSize = 0xED,

        /// <summary>
        /// Illegal mailbox queue ID specified.
        /// </summary>
        IllegalMailbox = 0xEE,

        /// <summary>
        /// Attempted to access invalid field of a structure.
        /// </summary>
        InvalidField = 0xEF,

        /// <summary>
        /// Bad input or output specified.
        /// </summary>
        BadIO = 0xF0,

        /// <summary>
        /// Insufficient memory available.
        /// </summary>
        OutOfMemory = 0xFB,

        /// <summary>
        /// Bad arguments.
        /// </summary>
        BadArguments = 0xFF,

        // system commands

        /// <summary>
        /// No more file handles are available
        /// </summary>
        NoMoreHandles = 0x81,

        /// <summary>
        /// No more space
        /// </summary>
        NoMoreSpace = 0x82,

        /// <summary>
        /// No more files
        /// </summary>
        NoMoreFiles = 0x83,

        /// <summary>
        /// The end of a file was expected.
        /// </summary>
        EndOfFileExpected = 0x84,

        /// <summary>
        /// The end of a file has been reached.
        /// </summary>
        EndOfFile = 0x85,

        /// <summary>
        /// The file is not a linear file.
        /// </summary>
        NotALinearFile = 0x86,

        /// <summary>
        /// The file was not found.
        /// </summary>
        FileNotFound = 0x87,

        /// <summary>
        /// The file handle was already closed.
        /// </summary>
        HandleAlreadyClosed = 0x88,

        /// <summary>
        /// No linear space.
        /// </summary>
        NoLinearSpace = 0x89,

        /// <summary>
        /// An unknown error occured.
        /// </summary>
        UndefinedError = 0x8A,

        /// <summary>
        /// The file is busy.
        /// </summary>
        FileIsBusy = 0x8B,

        /// <summary>
        /// There are no write buffers available.
        /// </summary>
        NoWriteBuffers = 0x8C,

        /// <summary>
        /// Appending this file is not possible.
        /// </summary>
        AppendNotPossible = 0x8D,

        /// <summary>
        /// The file is full.
        /// </summary>
        FileIsFull = 0x8E,

        /// <summary>
        /// The file already exists.
        /// </summary>
        FileExists = 0x8F,

        /// <summary>
        /// The module was not found.
        /// </summary>
        ModuleNotFound = 0x90,

        /// <summary>
        /// Out of bounds.
        /// </summary>
        OutOfBounds = 0x91,

        /// <summary>
        /// File name is not valid.
        /// </summary>
        IllegalFileName = 0x92,

        /// <summary>
        /// File handle is not valid.
        /// </summary>
        IllegalHandle = 0x93,
    }
}
