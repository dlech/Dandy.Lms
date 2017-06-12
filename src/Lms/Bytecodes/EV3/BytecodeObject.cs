using Dandy.Lms.Bytecodes.EV3.Opcodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Object that represents a VM routine.
    /// </summary>
    [DebuggerDisplay("{Type} {Name}")]
    public class BytecodeObject : IByteCode
    {
        readonly BytecodeObjectType type;
        readonly int locals;
        readonly Opcode[] ops;
        
        internal BytecodeObject(BytecodeObjectType type, int locals, params Opcode[] ops)
        {
            if (locals < 0)
            {
                throw new ArgumentOutOfRangeException("Must be >= 0", nameof(locals));
            }

            this.type = type;
            this.locals = locals;
            this.ops = ops ?? throw new ArgumentNullException(nameof(ops));
        }

        internal BytecodeObjectType Type => type;
        internal int Locals => locals;
        internal IReadOnlyList<Opcode> Opcodes => ops.ToList().AsReadOnly();

        /// <summary>
        /// Creates a copy of this object with one local variable.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0>(
            out IExpression<T0> lv0, int size0)
            where T0 : VMDataType
        {
            if (size0 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size0));
            }
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with two local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1)
            where T0 : VMDataType
            where T1 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with three local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <typeparam name="T2">The VM data type of <paramref name="lv2"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <param name="lv2">Object representing a local variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="lv2"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1, T2>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with four local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <typeparam name="T2">The VM data type of <paramref name="lv2"/>.</typeparam>
        /// <typeparam name="T3">The VM data type of <paramref name="lv3"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <param name="lv2">Object representing a local variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="lv2"/>.</param>
        /// <param name="lv3">Object representing a local variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="lv3"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1, T2, T3>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with five local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <typeparam name="T2">The VM data type of <paramref name="lv2"/>.</typeparam>
        /// <typeparam name="T3">The VM data type of <paramref name="lv3"/>.</typeparam>
        /// <typeparam name="T4">The VM data type of <paramref name="lv4"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <param name="lv2">Object representing a local variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="lv2"/>.</param>
        /// <param name="lv3">Object representing a local variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="lv3"/>.</param>
        /// <param name="lv4">Object representing a local variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="lv4"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1, T2, T3, T4>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with six local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <typeparam name="T2">The VM data type of <paramref name="lv2"/>.</typeparam>
        /// <typeparam name="T3">The VM data type of <paramref name="lv3"/>.</typeparam>
        /// <typeparam name="T4">The VM data type of <paramref name="lv4"/>.</typeparam>
        /// <typeparam name="T5">The VM data type of <paramref name="lv5"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <param name="lv2">Object representing a local variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="lv2"/>.</param>
        /// <param name="lv3">Object representing a local variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="lv3"/>.</param>
        /// <param name="lv4">Object representing a local variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="lv4"/>.</param>
        /// <param name="lv5">Object representing a local variable.</param>
        /// <param name="size5">The number of bytes to allocate for <paramref name="lv5"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1, T2, T3, T4, T5>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4,
            out IExpression<T5> lv5, int size5)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
            where T5 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            lv5 = new LocalVariable<T5>(size5, ref offset);
            return new BytecodeObject(type, offset,  ops);
        }

        /// <summary>
        /// Creates a copy of this object with seven local variables.
        /// </summary>
        /// <typeparam name="T0">The VM data type of <paramref name="lv0"/>.</typeparam>
        /// <typeparam name="T1">The VM data type of <paramref name="lv1"/>.</typeparam>
        /// <typeparam name="T2">The VM data type of <paramref name="lv2"/>.</typeparam>
        /// <typeparam name="T3">The VM data type of <paramref name="lv3"/>.</typeparam>
        /// <typeparam name="T4">The VM data type of <paramref name="lv4"/>.</typeparam>
        /// <typeparam name="T5">The VM data type of <paramref name="lv5"/>.</typeparam>
        /// <typeparam name="T6">The VM data type of <paramref name="lv6"/>.</typeparam>
        /// <param name="lv0">Object representing a local variable.</param>
        /// <param name="size0">The number of bytes to allocate for <paramref name="lv0"/>.</param>
        /// <param name="lv1">Object representing a local variable.</param>
        /// <param name="size1">The number of bytes to allocate for <paramref name="lv1"/>.</param>
        /// <param name="lv2">Object representing a local variable.</param>
        /// <param name="size2">The number of bytes to allocate for <paramref name="lv2"/>.</param>
        /// <param name="lv3">Object representing a local variable.</param>
        /// <param name="size3">The number of bytes to allocate for <paramref name="lv3"/>.</param>
        /// <param name="lv4">Object representing a local variable.</param>
        /// <param name="size4">The number of bytes to allocate for <paramref name="lv4"/>.</param>
        /// <param name="lv5">Object representing a local variable.</param>
        /// <param name="size5">The number of bytes to allocate for <paramref name="lv5"/>.</param>
        /// <param name="lv6">Object representing a local variable.</param>
        /// <param name="size6">The number of bytes to allocate for <paramref name="lv6"/>.</param>
        /// <returns>A new bytecode object.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="size0"/> is negative or if <typeparamref name="T0"/> is a fixed
        /// size type such as <see cref="Data8"/> and <paramref name="size0"/> is not the correct size.
        /// The same applies to the additional arguments.
        /// (Tip: You can use <see cref="Data8.FixedSize"/> to get the correct size.)
        /// </exception>
        public BytecodeObject WithLocals<T0, T1, T2, T3, T4, T5, T6>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4,
            out IExpression<T5> lv5, int size5,
            out IExpression<T6> lv6, int size6)
            where T0 : VMDataType
            where T1 : VMDataType
            where T2 : VMDataType
            where T3 : VMDataType
            where T4 : VMDataType
            where T5 : VMDataType
            where T6 : VMDataType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            lv5 = new LocalVariable<T5>(size5, ref offset);
            lv6 = new LocalVariable<T6>(size6, ref offset);
            return new BytecodeObject(type, offset, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with one label.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0)
        {
            l0 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with two labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with three labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with four labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <param name="l3">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2,
            out IExpression<DataLabel> l3)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            l3 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with five labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <param name="l3">An object representing the label.</param>
        /// <param name="l4">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2,
            out IExpression<DataLabel> l3,
            out IExpression<DataLabel> l4)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            l3 = new LabelPlaceholder(this);
            l4 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with six labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <param name="l3">An object representing the label.</param>
        /// <param name="l4">An object representing the label.</param>
        /// <param name="l5">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2,
            out IExpression<DataLabel> l3,
            out IExpression<DataLabel> l4,
            out IExpression<DataLabel> l5)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            l3 = new LabelPlaceholder(this);
            l4 = new LabelPlaceholder(this);
            l5 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with seven labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <param name="l3">An object representing the label.</param>
        /// <param name="l4">An object representing the label.</param>
        /// <param name="l5">An object representing the label.</param>
        /// <param name="l6">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2,
            out IExpression<DataLabel> l3,
            out IExpression<DataLabel> l4,
            out IExpression<DataLabel> l5,
            out IExpression<DataLabel> l6)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            l3 = new LabelPlaceholder(this);
            l4 = new LabelPlaceholder(this);
            l5 = new LabelPlaceholder(this);
            l6 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with eight labels.
        /// </summary>
        /// <param name="l0">An object representing the label.</param>
        /// <param name="l1">An object representing the label.</param>
        /// <param name="l2">An object representing the label.</param>
        /// <param name="l3">An object representing the label.</param>
        /// <param name="l4">An object representing the label.</param>
        /// <param name="l5">An object representing the label.</param>
        /// <param name="l6">An object representing the label.</param>
        /// <param name="l7">An object representing the label.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2,
            out IExpression<DataLabel> l3,
            out IExpression<DataLabel> l4,
            out IExpression<DataLabel> l5,
            out IExpression<DataLabel> l6,
            out IExpression<DataLabel> l7)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            l3 = new LabelPlaceholder(this);
            l4 = new LabelPlaceholder(this);
            l5 = new LabelPlaceholder(this);
            l6 = new LabelPlaceholder(this);
            l7 = new LabelPlaceholder(this);
            return new BytecodeObject(type, locals, ops);
        }

        /// <summary>
        /// Creates a copy of this bytecode object with the specified opcodes.
        /// </summary>
        /// <param name="ops">The opcodes.</param>
        /// <returns>A new bytecode object.</returns>
        public BytecodeObject WithOpcodes(params Opcode[] ops)
        {
            return new BytecodeObject(type, locals, ops);
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            var labelOffsets = new Dictionary<LabelPlaceholder, int>();
            var deferredLabelWriteMap = new Dictionary<LabelPlaceholder, List<Tuple<int, Action<int>>>>();

            if (type == BytecodeObjectType.Subcall)
            {
                writer.Write((sbyte)0); // FIXME this is the parameter count
            }

            foreach (var op in ops)
            {
                // Don't actually write any bytes for a label. Just save the position.
                if (op.Code == OpcodeValue.LABEL)
                {
                    try
                    {
                        var placeholder = (LabelPlaceholder)op.Parameters.Single();
                        labelOffsets.Add(placeholder, (int)writer.BaseStream.Position);
                    }
                    catch (ArgumentException ex)
                    {
                        throw new InvalidOperationException($"Attempting to redefine a label - {$"{nameof(BytecodeFactory.Opcode.opLABEL)} can only be used once per label"}", ex);
                    }
                }
                else
                {
                    var deferredLabelWrites = op.Write(writer);
                    foreach (var w in deferredLabelWrites)
                    {
                        if (!deferredLabelWriteMap.ContainsKey(w.Item1))
                        {
                            deferredLabelWriteMap.Add(w.Item1, new List<Tuple<int, Action<int>>>());
                        }
                        deferredLabelWriteMap[w.Item1].Add(new Tuple<int, Action<int>>(w.Item2, w.Item3));
                    }
                }
            }

            if (type == BytecodeObjectType.Subcall)
            {
                writer.Write(BytecodeFactory.Opcode.opRETURN());
            }

            writer.Write(BytecodeFactory.Opcode.opOBJECT_END());

            foreach (var item in deferredLabelWriteMap)
            {
                foreach (var writeLabel in deferredLabelWriteMap[item.Key])
                {
                    writeLabel.Item2(labelOffsets[item.Key] - writeLabel.Item1);
                }
            }
        }
    }
}
