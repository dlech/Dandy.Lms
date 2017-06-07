using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandy.Lms.Bytecodes.EV3.System
{
    sealed class BeginDownload : SystemCommand<byte>
    {
        private readonly int size;
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.BeginDownload;

        public BeginDownload(int size, string path)
        {
            this.size = size;
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(size);
            writer.Write(path, 0);
        }

        protected sealed override byte ParseReplyParameters(BinaryReader reader)
        {
            var handle = reader.ReadByte();
            return handle;
        }
    }

    sealed class ContinueDownload : SystemCommand<byte>
    {
        private readonly byte handle;
        private readonly byte[] payload;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.ContinueDownload;

        public ContinueDownload(byte handle, byte[] payload)
        {
            this.handle = handle;
            this.payload = payload;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(handle);
            writer.Write(payload);
        }

        protected sealed override byte ParseReplyParameters(BinaryReader reader)
        {
            var newHandle = reader.ReadByte();
            return newHandle;
        }
    }

    sealed class BeginUpload : SystemCommand<ValueTuple<int, byte, byte[]>>
    {
        private readonly ushort chunkSize;
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.BeginUpload;

        public BeginUpload(ushort chunkSize, string path)
        {
            this.chunkSize = chunkSize;
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(chunkSize);
            writer.Write(path, 0);
        }

        protected sealed override (int, byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var length = reader.ReadInt32();
            var handle = reader.ReadByte();
            var payload = reader.ReadBytes(chunkSize);
            return (length, handle, payload);
        }
    }

    sealed class ContinueUpload : SystemCommand<ValueTuple<byte, byte[]>>
    {
        private readonly byte handle;
        private readonly ushort chunkSize;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.ContinueUpload;

        public ContinueUpload(byte handle, ushort chunkSize)
        {
            this.handle = handle;
            this.chunkSize = chunkSize;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(handle);
            writer.Write(chunkSize);
        }

        protected sealed override (byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var newHandle = reader.ReadByte();
            var payload = reader.ReadBytes(chunkSize);
            return (newHandle, payload);
        }
    }

    sealed class BeginGetFile : SystemCommand<ValueTuple<int, byte, byte[]>>
    {
        private readonly ushort chunkSize;
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.BeginGetFile;

        public BeginGetFile(ushort chunkSize, string path)
        {
            this.chunkSize = chunkSize;
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(chunkSize);
            writer.Write(path, 0);
        }

        protected sealed override (int, byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var length = reader.ReadInt32();
            var handle = reader.ReadByte();
            var payload = reader.ReadBytes(chunkSize);
            return (length, handle, payload);
        }
    }

    sealed class ContinueGetFile : SystemCommand<ValueTuple<int, byte, byte[]>>
    {
        private readonly byte handle;
        private readonly ushort chunkSize;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.ContinueGetFile;

        public ContinueGetFile(byte handle, ushort chunkSize)
        {
            this.handle = handle;
            this.chunkSize = chunkSize;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(handle);
            writer.Write(chunkSize);
        }

        protected sealed override (int, byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var length = reader.ReadInt32();
            var newHandle = reader.ReadByte();
            var payload = reader.ReadBytes(chunkSize);
            return (length, newHandle, payload);
        }
    }

    sealed class BeginListFiles : SystemCommand<ValueTuple<int, byte, byte[]>>
    {
        private readonly ushort chunkSize;
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.BeginListFiles;

        public BeginListFiles(ushort chunkSize, string path)
        {
            this.chunkSize = chunkSize;
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(chunkSize);
            writer.Write(path, 0);
        }

        protected sealed override (int, byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var length = reader.ReadInt32();
            var handle = reader.ReadByte();
            var payload = reader.ReadBytes(length);
            return (length, handle, payload);
        }
    }

    sealed class ContinueListFiles : SystemCommand<ValueTuple<byte, byte[]>>
    {
        private readonly byte handle;
        private readonly ushort chunkSize;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.ContinueListFiles;

        public ContinueListFiles(byte handle, ushort chunkSize)
        {
            this.handle = handle;
            this.chunkSize = chunkSize;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(handle);
            writer.Write(chunkSize);
        }

        protected sealed override (byte, byte[]) ParseReplyParameters(BinaryReader reader)
        {
            var newHandle = reader.ReadByte();
            var payload = reader.ReadBytes(chunkSize);
            return (newHandle, payload);
        }
    }

    sealed class CloseFileHandle : SystemCommand<Unit>
    {
        private readonly byte handle;
        private readonly ulong hash;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.CloseFileHandle;

        public CloseFileHandle(byte handle, ulong hash)
        {
            this.handle = handle;
            this.hash = hash;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(handle);
            writer.Write(hash);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }

    sealed class CreateDirectory : SystemCommand<Unit>
    {
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.CreateDirectory;

        public CreateDirectory(string path)
        {
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(path, 0);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }

    sealed class DeleteFile : SystemCommand<Unit>
    {
        private readonly string path;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.DeleteFile;

        public DeleteFile(string path)
        {
            this.path = path;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(path, 0);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }

    sealed class ListOpenHandles : SystemCommand<ushort>
    {
        public sealed override SystemCommandType SystemCommandType => SystemCommandType.ListOpenHandles;

        public ListOpenHandles()
        {
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
        }

        protected sealed override ushort ParseReplyParameters(BinaryReader reader)
        {
            var flags = reader.ReadUInt16();
            return flags;
        }
    }

    sealed class WriteMailbox : SystemCommand<Unit>
    {
        private readonly string name;
        private readonly byte[] payload;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.WriteMailbox;

        public WriteMailbox(string name, byte[] payload)
        {
            this.name = name;
            this.payload = payload;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(name, sizeof(byte), includeNullCharInLength: false);
            writer.Write((ushort)payload.Length);
            writer.Write(payload);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            throw new InvalidOperationException();
        }
    }

    sealed class SendBluetoothPin : SystemCommand<ValueTuple<string, string>>
    {
        private readonly string hostMACAddress;
        private readonly string pinCode;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.SendBluetoothPin;

        public SendBluetoothPin(string hostMACAddress, string pinCode)
        {
            this.hostMACAddress = hostMACAddress;
            this.pinCode = pinCode;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(hostMACAddress, sizeof(byte));
            writer.Write(pinCode, sizeof(byte));
        }

        protected sealed override (string, string) ParseReplyParameters(BinaryReader reader)
        {
            var clientMacAddressLength = reader.ReadByte();
            var clientMACAddress = reader.ReadString(clientMacAddressLength);
            var pinCodeLength = reader.ReadByte();
            var clientPinCode = reader.ReadString(pinCodeLength);
            return (clientMACAddress, clientPinCode);
        }
    }

    sealed class EnterFimrwareUpdateMode : SystemCommand<Unit>
    {
        public sealed override SystemCommandType SystemCommandType => SystemCommandType.EnterFimrwareUpdateMode;

        public EnterFimrwareUpdateMode()
        {
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }

    sealed class SetBundleID : SystemCommand<Unit>
    {
        private readonly string id;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.SetBundleID;

        public SetBundleID(string id)
        {
            this.id = id;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(id, 0);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }

    sealed class SetBundleSeedID : SystemCommand<Unit>
    {
        private readonly string id;

        public sealed override SystemCommandType SystemCommandType => SystemCommandType.SetBundleSeedID;

        public SetBundleSeedID(string id)
        {
            this.id = id;
        }

        protected sealed override void WriteCommandParameters(BinaryWriter writer)
        {
            writer.Write(id, 0);
        }

        protected sealed override Unit ParseReplyParameters(BinaryReader reader)
        {
            return Unit.Value;
        }
    }
}
