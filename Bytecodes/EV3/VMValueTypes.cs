using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Dandy.Lms.Bytecodes.EV3
{

    public abstract class VMValueType
    {
        internal VMValueType()
        {
        }

        internal abstract void ParseValue(BinaryReader reader, int size);
    }

    [DebuggerDisplay("{Value}")]
    public abstract class VMValueType<T> : VMValueType
    {
        internal VMValueType()
        {
        }

        public T Value { get; protected set; }

        public static implicit operator T(VMValueType<T> self)
        {
            if (self == null)
            {
                return default(T);
            }
            return self.Value;
        }
    }

    public sealed class Data8 : VMValueType<sbyte>
    {
        public static int FixedSize => sizeof(sbyte);

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size != FixedSize)
            {
                throw new ArgumentOutOfRangeException($"Size must be {FixedSize}", nameof(size));
            }
            Value = reader.ReadSByte();
        }
    }

    public sealed class Data16 : VMValueType<short>
    {
        public static int FixedSize => sizeof(short);

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size != FixedSize)
            {
                throw new ArgumentOutOfRangeException($"Size must be {FixedSize}", nameof(size));
            }
            Value = reader.ReadInt16();
        }
    }

    public sealed class Data32 : VMValueType<int>
    {
        public static int FixedSize => sizeof(int);

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size != FixedSize)
            {
                throw new ArgumentOutOfRangeException($"Size must be {FixedSize}", nameof(size));
            }
            Value = reader.ReadInt32();
        }
    }

    public sealed class DataFloat : VMValueType<float>
    {
        public static int FixedSize => sizeof(float);

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size != FixedSize)
            {
                throw new ArgumentOutOfRangeException($"Size must be {FixedSize}", nameof(size));
            }
            Value = reader.ReadSingle();
        }
    }

    public sealed class DataString : VMValueType<string>
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            Value = reader.ReadString(size);
        }
    }

    public sealed class DataArray8 : VMValueType<sbyte[]>
    {
        static IEnumerable<sbyte> GetValues(BinaryReader reader, int length)
        {
            for (int i = 0; i < length; i++)
            {
                yield return reader.ReadSByte();
            }
        }

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            Value = GetValues(reader, size).ToArray();
        }
    }

    public sealed class DataArray16 : VMValueType<short[]>
    {
        static IEnumerable<short> GetValues(BinaryReader reader, int length)
        {
            for (int i = 0; i < length; i++)
            {
                yield return reader.ReadInt16();
            }
        }

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size < 0 || size % sizeof(short) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            Value = GetValues(reader, size / sizeof(short)).ToArray();
        }
    }

    public sealed class DataArray32 : VMValueType<int[]>
    {
        static IEnumerable<int> GetValues(BinaryReader reader, int length)
        {
            for (int i = 0; i < length; i++)
            {
                yield return reader.ReadInt32();
            }
        }

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size < 0 || size % sizeof(int) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            Value = GetValues(reader, size / sizeof(int)).ToArray();
        }
    }

    public sealed class DataArrayFloat : VMValueType<float[]>
    {
        static IEnumerable<float> GetValues(BinaryReader reader, int length)
        {
            for (int i = 0; i < length; i++)
            {
                yield return reader.ReadSingle();
            }
        }

        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            if (size < 0 || size % sizeof(float) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            Value = GetValues(reader, size / sizeof(float)).ToArray();
        }
    }

    public sealed class DataLabel : VMValueType<byte> // FIXME: not sure what the actual size is
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }

    sealed class DataHandle : VMValueType<byte> // FIXME: not sure what the actual size is
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }

    sealed class DataAddress : VMValueType<byte> // FIXME: not sure what the actual size is
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }
}
