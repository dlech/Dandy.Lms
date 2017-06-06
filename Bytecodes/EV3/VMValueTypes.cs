using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Base class for all VM data types.
    /// </summary>
    public abstract class VMValueType
    {
        internal VMValueType()
        {
        }

        internal abstract void ParseValue(BinaryReader reader, int size);
    }

    /// <summary>
    /// Base class for VM data types that are associated with managed data type.
    /// </summary>
    /// <typeparam name="T">The managed data type.</typeparam>
    [DebuggerDisplay("{Value}")]
    public abstract class VMValueType<T> : VMValueType
    {
        internal VMValueType()
        {
        }

        /// <summary>
        /// Gets the managed representation of the VM data type.
        /// </summary>
        public T Value { get; protected set; }

        /// <summary>
        /// Converts the VM data type to the corresponding managed data type.
        /// </summary>
        /// <param name="self"></param>
        public static implicit operator T(VMValueType<T> self)
        {
            if (self == null)
            {
                return default(T);
            }
            return self.Value;
        }
    }

    /// <summary>
    /// Represents an 8-bit signed integer value.
    /// </summary>
    public sealed class Data8 : VMValueType<sbyte>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
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

    /// <summary>
    /// Represents an 16-bit signed integer value.
    /// </summary>
    public sealed class Data16 : VMValueType<short>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
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

    /// <summary>
    /// Represents an 32-bit signed integer value.
    /// </summary>
    public sealed class Data32 : VMValueType<int>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
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

    /// <summary>
    /// Represents an 32-bit floating point value.
    /// </summary>
    public sealed class DataFloat : VMValueType<float>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
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

    /// <summary>
    /// Represents an string (character array) value.
    /// </summary>
    public sealed class DataString : VMValueType<string>
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            Value = reader.ReadString(size);
        }
    }

    /// <summary>
    /// Represents an array of 8-bit signed integers.
    /// </summary>
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

    /// <summary>
    /// Represents an array of 16-bit signed integers.
    /// </summary>
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

    /// <summary>
    /// Represents an array of 32-bit signed integers.
    /// </summary>
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

    /// <summary>
    /// Represents an array of 32-bit floating point values.
    /// </summary>
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

    /// <summary>
    /// Represents a bytecode object label.
    /// </summary>
    public sealed class DataLabel : VMValueType<short>
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
