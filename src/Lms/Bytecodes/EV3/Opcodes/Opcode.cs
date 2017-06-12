using Dandy.Lms.Bytecodes.EV3.Opcodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3.Opcodes
{
    /// <summary>
    /// Base class for <see cref="Opcode"/> and subcommands.
    /// </summary>
    public abstract class AbstractOpcode : IByteCode
    {
        readonly byte code;
        readonly IByteCode[] parameters;

        internal IEnumerable<IByteCode> Parameters => parameters;

        internal AbstractOpcode(byte code, params IByteCode[] parameters)
        {
            this.code = code;
            this.parameters = parameters;
        }

        internal IEnumerable<Tuple<LabelPlaceholder, int, Action<int>>> Write(BinaryWriter writer)
        {
            writer.Write(code);
            foreach (var p in parameters)
            {
                if (p is LabelPlaceholder lp)
                {
                    Action<int> deferredWrite = v =>
                    {
                        writer.Write(PrimPar.Long.BitwiseOr(PrimPar.TwoBytes).AsByte());
                        writer.Write((short)v);
                    };
                    writer.WriteDeferred(ref deferredWrite);
                    var pos = writer.BaseStream.Position;
                    yield return new Tuple<LabelPlaceholder, int, Action<int>>(lp, (int)pos, deferredWrite);
                }
                else
                {
                    writer.Write(p);
                }
            }
        }

        void IByteCode.Write(BinaryWriter writer)
        {
            // have to call ToList() to force complete iteration, otherwise parameters will be missed
            Write(writer).ToList();
        }
    }

    /// <summary>
    /// Represents an opcode. These are basically VM function calls and are the building blocks of <see cref="BytecodeObject"/>s.
    /// </summary>
    [DebuggerDisplay("{code}")]
    public class Opcode : AbstractOpcode
    {
        OpcodeValue code;

        internal OpcodeValue Code => code;

        internal Opcode(OpcodeValue code, params IByteCode[] parameters) : base((byte)code, parameters)
        {
            this.code = code;
        }

        internal void Write(BinaryWriter writer, out Action<int> deferredWriteLabel, out Action<int> deferredWriteSubcall)
        {
            throw new NotImplementedException();
        }
    }
}
