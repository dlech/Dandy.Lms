﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using Dandy.Core;

namespace Dandy.Lms.Bytecodes.EV3
{
    enum PrimPar : byte
    {
        Short = 0x00,
        Long = 0x80,

        Constant = 0x00,
        Variable = 0x40,
        Local = 0x00,
        Global = 0x20,
        Handle = 0x10,
        Address = 0x08,

        Index = 0x1F,
        ConstantSign = 0x20,
        Value = 0x3F,

        Bytes = 0x07,

        StringOld = 0,
        OneByte = 1,
        TwoBytes = 2,
        FourBytes = 3,
        String = 4,

        Label = 0x20,
    }

    static class PrimParExtensions
    {
        public static byte BitwiseOr(this PrimPar primPar, byte value)
        {
            return (byte)(primPar.AsByte() | value);
        }

        public static byte BitwiseAnd(this PrimPar primPar, byte value)
        {
            return (byte)(primPar.AsByte() & value);
        }

        public static PrimPar BitwiseOr(this PrimPar primPar, PrimPar value)
        {
            return (PrimPar)(primPar.AsByte() | (byte)value);
        }

        public static byte AsByte(this PrimPar primPar)
        {
            return (byte)primPar;
        }

        public static byte[] GetSmallestBytes(this PrimPar type, int value)
        {
            byte[] bytes;

            if (value < 32 && value >= -32)
            {
                bytes = new byte[1];
                bytes[0] = type.BitwiseOr(PrimPar.Short.BitwiseOr(PrimPar.Value.BitwiseAnd((byte)value)));
            }
            else if (value < sbyte.MaxValue && value > sbyte.MinValue)
            {
                bytes = new byte[2];
                bytes[0] = type.BitwiseOr(PrimPar.Long).BitwiseOr(PrimPar.OneByte).AsByte();
                bytes[1] = (byte)(value & 0xFF);
            }
            else if (value < short.MaxValue && value > short.MinValue)
            {
                bytes = new byte[3];
                bytes[0] = type.BitwiseOr(PrimPar.Long).BitwiseOr(PrimPar.TwoBytes).AsByte();
                bytes[1] = (byte)(value & 0xFF);
                bytes[2] = (byte)((value >> 8) & 0xFF);
            }
            else
            {
                bytes = new byte[5];
                bytes[0] = type.BitwiseOr(PrimPar.Long).BitwiseOr(PrimPar.FourBytes).AsByte();
                bytes[1] = (byte)(value & 0xFF);
                bytes[2] = (byte)((value >> 8) & 0xFF);
                bytes[3] = (byte)((value >> 16) & 0xFF);
                bytes[4] = (byte)((value >> 24) & 0xFF);
            }

            return bytes;
        }
    }

    class Handle : IExpression<DataHandle>
    {
        readonly byte handle;

        IExpression<Data8> IExpression<DataHandle>.this[int index] => throw new NotImplementedException();

        internal Handle(byte handle)
        {
            this.handle = PrimPar.Handle.BitwiseOr(handle);
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(handle);
        }
    }

    class Address : IExpression<DataAddress>
    {
        readonly byte address;

        IExpression<Data8> IExpression<DataAddress>.this[int index] => throw new NotImplementedException();


        internal Address(byte address)
        {
            this.address = PrimPar.Address.BitwiseOr(address);
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(address);
        }
    }

    class LabelPlaceholder : IExpression<DataLabel>
    {
        readonly BytecodeObject obj;

        internal LabelPlaceholder(BytecodeObject obj)
        {
            this.obj = obj ?? throw new ArgumentNullException(nameof(obj));
        }

        IExpression<Data8> IExpression<DataLabel>.this[int index] => throw new InvalidOperationException();

        void IByteCode.Write(BinaryWriter writer)
        {
            throw new InvalidOperationException("Cannot write label placeholder");
        }
    }
    
    class LocalConstant8 : IExpression<Data8>
    {
        readonly byte[] bytes;

        IExpression<Data8> IExpression<Data8>.this[int index] => throw new InvalidOperationException();

        internal LocalConstant8(sbyte value)
        {
            bytes = PrimPar.Constant.GetSmallestBytes(value);
        }
        
        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class LocalConstant16 : IExpression<Data16>
    {
        readonly byte[] bytes;
 
        IExpression<Data8> IExpression<Data16>.this[int index] => throw new InvalidOperationException();

        internal LocalConstant16(short value)
        {
            bytes = PrimPar.Constant.GetSmallestBytes(value);
        }
        
        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class LocalConstant32 : IExpression<Data32>
    {
        readonly byte[] bytes;

        IExpression<Data8> IExpression<Data32>.this[int index] => throw new InvalidOperationException();

        internal LocalConstant32(int value)
        {
            bytes = PrimPar.Constant.GetSmallestBytes(value);
        }
        
        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class LocalConstantFloat : IExpression<DataFloat>
    {
        readonly byte[] bytes;

        IExpression<Data8> IExpression<DataFloat>.this[int index] => throw new InvalidOperationException();

        internal LocalConstantFloat(float value)
        {
            var intValue = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
            bytes = new byte[5];
            bytes[0] = PrimPar.Constant.BitwiseOr(PrimPar.Long).BitwiseOr(PrimPar.FourBytes).AsByte();
            bytes[1] = (byte)(intValue & 0xFF);
            bytes[2] = (byte)((intValue >> 8) & 0xFF);
            bytes[3] = (byte)((intValue >> 16) & 0xFF);
            bytes[4] = (byte)((intValue >> 24) & 0xFF);
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class LocalConstantString : IExpression<DataString>
    {
        readonly byte[] bytes;

        IExpression<Data8> IExpression<DataString>.this[int index] => new LocalConstant8((sbyte)bytes[index]);

        internal LocalConstantString(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            bytes = new byte[value.Length + 2];
            bytes[0] = PrimPar.Long.BitwiseOr(PrimPar.StringOld).AsByte();
            Encoding.ASCII.GetBytes(value, 0, value.Length, bytes, 1);
        }
        
        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class Variable<T> : IExpression<T> where T : VMDataType
    {
        readonly PrimPar primParVariableType;
        readonly int size;
        readonly int offset;
        readonly byte[] bytes;

        IExpression<Data8> IExpression<T>.this[int index] {
            get {
                if (index < 0 || index >= size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                var newOffset = offset + index;
                return new Variable<Data8>(primParVariableType, Data8.FixedSize, ref newOffset);
            }
        }

        internal int Size => size;

        internal Variable(PrimPar primParVariableType, int size, ref int offset)
        {
            if (primParVariableType != PrimPar.Local && primParVariableType != PrimPar.Global)
            {
                throw new ArgumentOutOfRangeException("Must be local or global", nameof(primParVariableType));
            }

            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be < 0", nameof(size));
            }

            // We can check the size of value types. If T is not a value type, assume it is variable sized.
            if (typeof(T).GetTypeInfo().IsValueType)
            {
                var expectedSize = Marshal.SizeOf<T>();
                if (size != expectedSize)
                {
                    throw new ArgumentOutOfRangeException($"Must be exactly {expectedSize}", nameof(size));
                }
            }

            this.primParVariableType = primParVariableType;
            this.size = size;
            offset = AlignIfNeeded(size, offset);
            this.offset = offset;
            bytes = PrimPar.Variable.BitwiseOr(primParVariableType).GetSmallestBytes(offset);
            offset += size;
        }

        /// <summary>
        /// Align <paramref name="offset"/> to a 32-bit boundary if <paramref name="size"/> is 16-bit or 32- bit.
        /// </summary>
        /// <param name="size">The size of the data type.</param>
        /// <param name="offset">The current offset.</param>
        /// <returns>The new offset</returns>
        public static int AlignIfNeeded(int size, int offset)
        {
            if (size == 2 || size == 4)
            {
                offset += size - 1;
                return offset * (size / offset);
            }
            return offset;
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            writer.Write(bytes);
        }
    }

    class LocalVariable<T> : Variable<T> where T : VMDataType
    {
        internal LocalVariable(int size, ref int offset) : base(PrimPar.Local, size, ref offset)
        {
        }
    }

    class GlobalVariable<T> : Variable<T> where T : VMDataType
    {
        internal GlobalVariable(int size, ref int offset) : base (PrimPar.Global, size, ref offset)
        {
        }

        internal T Parse(BinaryReader reader)
        {
            var data = Activator.CreateInstance<T>();
            data.ParseValue(reader, Size);
            return data;
        }
    }

    delegate T ReplyParser<T>(BinaryReader reader);

    /// <summary>
    /// This class is used to generate <see cref="Program"/>s and <see cref="DirectCommand"/>s.
    /// </summary>
    /// <remarks>
    /// All objects returned by the factory methods are immutable, so, for example, if you call a
    /// With...() method on an object, a new object will be returned.
    /// </remarks>
    public static partial class BytecodeFactory
    {
        /// <summary>
        /// Create a new empty program.
        /// </summary>
        /// <returns>Object representing the program.</returns>
        public static Program Program()
        {
            return new Program(0, new BytecodeObject[0]);
        }

        /// <summary>
        /// Creates a new empty direct command with no global variables.
        /// </summary>
        /// <returns>Object representing the direct command.</returns>
        /// <remarks>
        /// <see cref="Unit"/> basically just means a <c>void</c> return type (we can't
        /// use <see cref="Void"/> as a type parameter for technical reasons).
        /// </remarks>
        public static DirectCommand<Unit> DirectCommand()
        {
            ReplyParser<Unit> parser = (r) => Unit.Value;
            return new DirectCommand<Unit>(0, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with one global variable.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<T0> DirectCommand<T0>(
            out IExpression<T0> gv0, int size0)
            where T0 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            ReplyParser<T0> parser = ((GlobalVariable<T0>)gv0).Parse;
            return new DirectCommand<T0>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with two global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1)> DirectCommand<T0, T1>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1)
            where T0 : VMDataType
            where T1 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<(T0, T1)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                return (r0, r1);
            };
            return new DirectCommand<(T0, T1)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with three global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <typeparam name="T2">The VM variable type of <paramref name="gv2"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <param name="gv2">Object representing a global variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="gv2"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1, T2)> DirectCommand<T0, T1, T2>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1,
            out IExpression<T2> gv2, int size2)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            gv2 = new GlobalVariable<T2>(size2, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<T2> p2 = ((GlobalVariable<T2>)gv2).Parse;
            ReplyParser<(T0, T1, T2)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                var r2 = p2(r);
                return (r0, r1, r2);
            };
            return new DirectCommand<(T0, T1, T2)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with four global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <typeparam name="T2">The VM variable type of <paramref name="gv2"/></typeparam>
        /// <typeparam name="T3">The VM variable type of <paramref name="gv3"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <param name="gv2">Object representing a global variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="gv2"/></param>
        /// <param name="gv3">Object representing a global variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="gv3"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1, T2, T3)> DirectCommand<T0, T1, T2, T3>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1,
            out IExpression<T2> gv2, int size2,
            out IExpression<T3> gv3, int size3)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            gv2 = new GlobalVariable<T2>(size2, ref offset);
            gv3 = new GlobalVariable<T3>(size3, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<T2> p2 = ((GlobalVariable<T2>)gv2).Parse;
            ReplyParser<T3> p3 = ((GlobalVariable<T3>)gv3).Parse;
            ReplyParser<(T0, T1, T2, T3)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                var r2 = p2(r);
                var r3 = p3(r);
                return (r0, r1, r2, r3);
            };
            return new DirectCommand<(T0, T1, T2, T3)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with five global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <typeparam name="T2">The VM variable type of <paramref name="gv2"/></typeparam>
        /// <typeparam name="T3">The VM variable type of <paramref name="gv3"/></typeparam>
        /// <typeparam name="T4">The VM variable type of <paramref name="gv4"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <param name="gv2">Object representing a global variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="gv2"/></param>
        /// <param name="gv3">Object representing a global variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="gv3"/></param>
        /// <param name="gv4">Object representing a global variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="gv4"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1, T2, T3, T4)> DirectCommand<T0, T1, T2, T3, T4>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1,
            out IExpression<T2> gv2, int size2,
            out IExpression<T3> gv3, int size3,
            out IExpression<T4> gv4, int size4)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            gv2 = new GlobalVariable<T2>(size2, ref offset);
            gv3 = new GlobalVariable<T3>(size3, ref offset);
            gv4 = new GlobalVariable<T4>(size4, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<T2> p2 = ((GlobalVariable<T2>)gv2).Parse;
            ReplyParser<T3> p3 = ((GlobalVariable<T3>)gv3).Parse;
            ReplyParser<T4> p4 = ((GlobalVariable<T4>)gv4).Parse;
            ReplyParser<(T0, T1, T2, T3, T4)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                var r2 = p2(r);
                var r3 = p3(r);
                var r4 = p4(r);
                return (r0, r1, r2, r3, r4);
            };
            return new DirectCommand<(T0, T1, T2, T3, T4)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with six global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <typeparam name="T2">The VM variable type of <paramref name="gv2"/></typeparam>
        /// <typeparam name="T3">The VM variable type of <paramref name="gv3"/></typeparam>
        /// <typeparam name="T4">The VM variable type of <paramref name="gv4"/></typeparam>
        /// <typeparam name="T5">The VM variable type of <paramref name="gv5"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <param name="gv2">Object representing a global variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="gv2"/></param>
        /// <param name="gv3">Object representing a global variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="gv3"/></param>
        /// <param name="gv4">Object representing a global variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="gv4"/></param>
        /// <param name="gv5">Object representing a global variable.</param>
        /// <param name="size5">The number of bytes to allocate for <paramref name="gv5"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1, T2, T3, T4, T5)> DirectCommand<T0, T1, T2, T3, T4, T5>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1,
            out IExpression<T2> gv2, int size2,
            out IExpression<T3> gv3, int size3,
            out IExpression<T4> gv4, int size4,
            out IExpression<T5> gv5, int size5)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
            where T5 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            gv2 = new GlobalVariable<T2>(size2, ref offset);
            gv3 = new GlobalVariable<T3>(size3, ref offset);
            gv4 = new GlobalVariable<T4>(size4, ref offset);
            gv5 = new GlobalVariable<T5>(size5, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<T2> p2 = ((GlobalVariable<T2>)gv2).Parse;
            ReplyParser<T3> p3 = ((GlobalVariable<T3>)gv3).Parse;
            ReplyParser<T4> p4 = ((GlobalVariable<T4>)gv4).Parse;
            ReplyParser<T5> p5 = ((GlobalVariable<T5>)gv5).Parse;
            ReplyParser<(T0, T1, T2, T3, T4, T5)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                var r2 = p2(r);
                var r3 = p3(r);
                var r4 = p4(r);
                var r5 = p5(r);
                return (r0, r1, r2, r3, r4, r5);
            };
            return new DirectCommand<(T0, T1, T2, T3, T4, T5)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new empty direct command with seven global variables.
        /// </summary>
        /// <typeparam name="T0">The VM variable type of <paramref name="gv0"/></typeparam>
        /// <typeparam name="T1">The VM variable type of <paramref name="gv1"/></typeparam>
        /// <typeparam name="T2">The VM variable type of <paramref name="gv2"/></typeparam>
        /// <typeparam name="T3">The VM variable type of <paramref name="gv3"/></typeparam>
        /// <typeparam name="T4">The VM variable type of <paramref name="gv4"/></typeparam>
        /// <typeparam name="T5">The VM variable type of <paramref name="gv5"/></typeparam>
        /// <typeparam name="T6">The VM variable type of <paramref name="gv6"/></typeparam>
        /// <param name="gv0">Object representing a global variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="gv0"/></param>
        /// <param name="gv1">Object representing a global variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="gv1"/></param>
        /// <param name="gv2">Object representing a global variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="gv2"/></param>
        /// <param name="gv3">Object representing a global variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="gv3"/></param>
        /// <param name="gv4">Object representing a global variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="gv4"/></param>
        /// <param name="gv5">Object representing a global variable.</param>
        /// <param name="size5">The number of bytes to allocate for <paramref name="gv5"/></param>
        /// <param name="gv6">Object representing a global variable.</param>
        /// <param name="size6">The number of bytes to allocate for <paramref name="gv6"/></param>
        /// <returns>Object representing the direct command.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional parameters.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public static DirectCommand<(T0, T1, T2, T3, T4, T5, T6)> DirectCommand<T0, T1, T2, T3, T4, T5, T6>(
            out IExpression<T0> gv0, int size0,
            out IExpression<T1> gv1, int size1,
            out IExpression<T2> gv2, int size2,
            out IExpression<T3> gv3, int size3,
            out IExpression<T4> gv4, int size4,
            out IExpression<T5> gv5, int size5,
            out IExpression<T6> gv6, int size6)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
            where T5 : VMDataType
            where T6 : VMDataType
        {
            int offset = 0;
            gv0 = new GlobalVariable<T0>(size0, ref offset);
            gv1 = new GlobalVariable<T1>(size1, ref offset);
            gv2 = new GlobalVariable<T2>(size2, ref offset);
            gv3 = new GlobalVariable<T3>(size3, ref offset);
            gv4 = new GlobalVariable<T4>(size4, ref offset);
            gv5 = new GlobalVariable<T5>(size5, ref offset);
            gv6 = new GlobalVariable<T6>(size6, ref offset);
            // can't use out parameters inside lambda, so this is a way to encapsulate them
            ReplyParser<T0> p0 = ((GlobalVariable<T0>)gv0).Parse;
            ReplyParser<T1> p1 = ((GlobalVariable<T1>)gv1).Parse;
            ReplyParser<T2> p2 = ((GlobalVariable<T2>)gv2).Parse;
            ReplyParser<T3> p3 = ((GlobalVariable<T3>)gv3).Parse;
            ReplyParser<T4> p4 = ((GlobalVariable<T4>)gv4).Parse;
            ReplyParser<T5> p5 = ((GlobalVariable<T5>)gv5).Parse;
            ReplyParser<T6> p6 = ((GlobalVariable<T6>)gv6).Parse;
            ReplyParser<(T0, T1, T2, T3, T4, T5, T6)> parser = (r) =>
            {
                var r0 = p0(r);
                var r1 = p1(r);
                var r2 = p2(r);
                var r3 = p3(r);
                var r4 = p4(r);
                var r5 = p5(r);
                var r6 = p6(r);
                return (r0, r1, r2, r3, r4, r5, r6);
            };
            return new DirectCommand<(T0, T1, T2, T3, T4, T5, T6)>(offset, parser, new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]));
        }

        /// <summary>
        /// Creates a new bytecode object representing a VM thread.
        /// </summary>
        /// <returns>A new bytecode object.</returns>
        public static BytecodeObject VMThread()
        {
            return new BytecodeObject(BytecodeObjectType.VMThread, 0, new Opcodes.Opcode[0]);
        }

        /// <summary>
        /// Creates a new bytecode object representing a VM subroutine.
        /// </summary>
        /// <returns>A new bytecode object.</returns>
        public static BytecodeObject Subcall()
        {
            return new BytecodeObject(BytecodeObjectType.Subcall, 0, new Opcodes.Opcode[0]);
        }

        /// <summary>
        /// Create a new constant expression representing an 8-bit signed integer value.
        /// </summary>
        /// <param name="value">The constant value.</param>
        /// <returns>A new expression.</returns>
        public static IExpression<Data8> LocalConstant(sbyte value)
        {
            return new LocalConstant8(value);
        }

        /// <summary>
        /// Create a new constant expression representing an 16-bit signed integer value.
        /// </summary>
        /// <param name="value">The constant value.</param>
        /// <returns>A new expression.</returns>
        public static IExpression<Data16> LocalConstant(short value)
        {
            return new LocalConstant16(value);
        }

        /// <summary>
        /// Create a new constant expression representing an 32-bit signed integer value.
        /// </summary>
        /// <param name="value">The constant value.</param>
        /// <returns>A new expression.</returns>
        public static IExpression<Data32> LocalConstant(int value)
        {
            return new LocalConstant32(value);
        }

        /// <summary>
        /// Create a new constant expression representing an 32-bit floating point value.
        /// </summary>
        /// <param name="value">The constant value.</param>
        /// <returns>A new expression.</returns>
        public static IExpression<DataFloat> LocalConstant(float value)
        {
            return new LocalConstantFloat(value);
        }

        /// <summary>
        /// Create a new constant expression representing a string value.
        /// </summary>
        /// <param name="value">The constant value.</param>
        /// <returns>A new expression.</returns>
        public static IExpression<DataString> LocalConstant(string value)
        {
            return new LocalConstantString(value);
        }
    }
}
