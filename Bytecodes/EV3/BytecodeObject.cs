using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    [DebuggerDisplay("{Type} {Name}")]
    public class BytecodeObject : IByteCode
    {
        readonly BytecodeObjectType type;
        readonly int locals;
        readonly Opcode[] ops;
        
        internal BytecodeObject(string name, BytecodeObjectType type, int locals, params Opcode[] ops)
        {
            if (locals < 0)
            {
                throw new ArgumentOutOfRangeException("Must be >= 0", nameof(locals));
            }

            Name = name;
            this.type = type;
            this.locals = locals;
            this.ops = ops ?? throw new ArgumentNullException(nameof(ops));
        }

        internal BytecodeObjectType Type => type;
        internal int Locals => locals;

        public string Name { get; }

        public BytecodeObject WithLocals<T0>(
            out IExpression<T0> lv0, int size0)
            where T0 : VMValueType
        {
            if (size0 < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size0));
            }
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1)
            where T0 : VMValueType
            where T1 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1, T2>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2)
            where T0 : VMValueType
            where T1 : VMValueType
            where T2 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1, T2, T3>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3)
            where T0 : VMValueType
            where T1 : VMValueType
            where T2 : VMValueType
            where T3 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1, T2, T3, T4>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4)
            where T0 : VMValueType
            where T1 : VMValueType
            where T2 : VMValueType
            where T3 : VMValueType
            where T4 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1, T2, T3, T4, T5>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4,
            out IExpression<T5> lv5, int size5)
            where T0 : VMValueType
            where T1 : VMValueType
            where T2 : VMValueType
            where T3 : VMValueType
            where T4 : VMValueType
            where T5 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            lv5 = new LocalVariable<T5>(size5, ref offset);
            return new BytecodeObject(Name, type, offset,  ops);
        }

        public BytecodeObject WithLocals<T0, T1, T2, T3, T4, T5, T6>(
            out IExpression<T0> lv0, int size0,
            out IExpression<T1> lv1, int size1,
            out IExpression<T2> lv2, int size2,
            out IExpression<T3> lv3, int size3,
            out IExpression<T4> lv4, int size4,
            out IExpression<T5> lv5, int size5,
            out IExpression<T6> lv6, int size6)
            where T0 : VMValueType
            where T1 : VMValueType
            where T2 : VMValueType
            where T3 : VMValueType
            where T4 : VMValueType
            where T5 : VMValueType
            where T6 : VMValueType
        {
            int offset = 0;
            lv0 = new LocalVariable<T0>(size0, ref offset);
            lv1 = new LocalVariable<T1>(size1, ref offset);
            lv2 = new LocalVariable<T2>(size2, ref offset);
            lv3 = new LocalVariable<T3>(size3, ref offset);
            lv4 = new LocalVariable<T4>(size4, ref offset);
            lv5 = new LocalVariable<T5>(size5, ref offset);
            lv6 = new LocalVariable<T6>(size6, ref offset);
            return new BytecodeObject(Name, type, offset, ops);
        }

        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0)
        {
            l0 = new LabelPlaceholder(this);
            return this;
        }

        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            return this;
        }

        public BytecodeObject WithLabels(
            out IExpression<DataLabel> l0,
            out IExpression<DataLabel> l1,
            out IExpression<DataLabel> l2)
        {
            l0 = new LabelPlaceholder(this);
            l1 = new LabelPlaceholder(this);
            l2 = new LabelPlaceholder(this);
            return this;
        }

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
            return this;
        }

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
            return this;
        }

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
            return this;
        }

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
            return this;
        }

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
            return this;
        }

        public BytecodeObject WithOpcodes(params Opcode[] ops)
        {
            return new BytecodeObject(Name, type, locals, ops);
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
                        throw new InvalidOperationException($"Attempting to redefine a label - {$"{nameof(BytecodeFactory.opLABEL)} can only be used once per label"}", ex);
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
                writer.Write(BytecodeFactory.opRETURN());
            }

            writer.Write(BytecodeFactory.opOBJECT_END());

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
