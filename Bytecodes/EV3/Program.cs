using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    public sealed class Program
    {
        readonly int globals;
        readonly BytecodeObject[] objs;

        internal Program(int globals, BytecodeObject[] objs)
        {
            this.globals = globals;
            // TODO: is there a max number of objects?
            this.objs = objs;
        }

        public Program WithBytecodeObjects(params BytecodeObject[] objs)
        {
            return new Program(globals, objs);
        }

        public byte[] ToBytes()
        {
            using (var writer = new BinaryWriter(new MemoryStream()))
            {
                // 16-byte program header

                writer.Write("LEGO", 0, includeNullTerminator: false);
                Action<int> writeProgramSize = v => writer.Write(v);
                writer.WriteDeferred(ref writeProgramSize);
                writer.Write((ushort)109); // TODO: get firmware version from somewhere
                writer.Write((ushort)objs.Length);
                writer.Write(globals);

                // 12-byte object headers

                var writeObjectOffsetQueue = new Queue<Action<int>>();
                foreach (var o in objs)
                {
                    Action<int> writeObjectOffset = v => writer.Write(v);
                    writer.WriteDeferred(ref writeObjectOffset);
                    writeObjectOffsetQueue.Enqueue(writeObjectOffset);
                    writer.Write((ushort)0); // owner
                    writer.Write((ushort)o.Type); // trigger
                    writer.Write(o.Locals);
                }

                // objects

                foreach (var o in objs)
                {
                    var writeObjectOffset = writeObjectOffsetQueue.Dequeue();
                    writeObjectOffset((int)writer.BaseStream.Position);
                    writer.Write(o);
                }

                var programSize = writer.BaseStream.Position;
                writeProgramSize((int)programSize);

                return ((MemoryStream)writer.BaseStream).ToArray();
            }
        }
    }
}
