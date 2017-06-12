using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Base class for all EV3 VM data types.
    /// </summary>
    /// <seealso cref="VMDataType{T}"/>
    public abstract class VMDataType
    {
        internal VMDataType()
        {
        }

        internal abstract void ParseValue(BinaryReader reader, int size);
    }

    /// <summary>
    /// Base class for EV3 VM data types that are associated with managed data type.
    /// </summary>
    /// <typeparam name="T">The managed data type.</typeparam>
    [DebuggerDisplay("{Value}")]
    public abstract class VMDataType<T> : VMDataType
    {
        internal VMDataType()
        {
        }

        /// <summary>
        /// Gets the managed representation of the VM data type.
        /// </summary>
        /// <value>The managed value.</value>
        public T Value { get; protected set; }

        /// <summary>
        /// Converts the VM data type to the corresponding managed data type.
        /// </summary>
        /// <param name="value">The VM value.</param>
        /// <returns>The managed value.</returns>
        public static implicit operator T(VMDataType<T> value)
        {
            if (value == null)
            {
                return default(T);
            }
            return value.Value;
        }
    }

    /// <summary>
    /// Represents an 8-bit signed integer value.
    /// </summary>
    public sealed class Data8 : VMDataType<sbyte>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
        /// <value>Always returns 1.</value>
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
    /// <value>Always returns 2.</value>
    public sealed class Data16 : VMDataType<short>
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
    public sealed class Data32 : VMDataType<int>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
        /// <value>Always returns 4.</value>
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
    public sealed class DataFloat : VMDataType<float>
    {
        /// <summary>
        /// The size of this type in bytes.
        /// </summary>
        /// <value>Always returns 4.</value>
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
    /// Represents a null-terminated string value.
    /// </summary>
    public sealed class DataString : VMDataType<string>
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            Value = reader.ReadString(size).TrimEnd('\0');
        }
    }

    /// <summary>
    /// Represents an array of 8-bit signed integers.
    /// </summary>
    public sealed class DataArray8 : VMDataType<sbyte[]>
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
    public sealed class DataArray16 : VMDataType<short[]>
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
    public sealed class DataArray32 : VMDataType<int[]>
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
    public sealed class DataArrayFloat : VMDataType<float[]>
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
    public sealed class DataLabel : VMDataType<short>
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }

    sealed class DataHandle : VMDataType<byte> // FIXME: not sure what the actual size is
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }

    sealed class DataAddress : VMDataType<byte> // FIXME: not sure what the actual size is
    {
        internal sealed override void ParseValue(BinaryReader reader, int size)
        {
            throw new NotImplementedException();
        }
    }
}
