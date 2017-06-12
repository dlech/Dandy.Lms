using System;
using System.Collections.Generic;
using System.Text;

using Dandy.Core;

using static Dandy.Lms.Bytecodes.EV3.BytecodeFactory;
using static Dandy.Lms.Bytecodes.EV3.BytecodeFactory.Opcode;

using Xunit;
using FluentAssertions;

namespace Dandy.Lms.Bytecodes.EV3.Direct.Test
{
    public class EV3DirectCommandTests
    {
        const byte DirectCommandReply = 0x00;
        const byte DirectCommandNoReply = 0x80;
        const byte DirectReply = 0x02;
        const byte DriectReplyError = 0x04;

        const byte opERROR = 0x00;
        const byte opNOP = 0x01;
        const byte opPROGRAM_STOP = 0x02;
        const byte opPROGRAM_START = 0x03;
        const byte opOBJECT_STOP = 0x04;
        const byte opOBJECT_START = 0x05;
        const byte opOBJECT_TRIG = 0x06;
        const byte opOBJECT_WAIT = 0x07;
        const byte opRETURN = 0x08;
        const byte opCALL = 0x09;
        const byte opOBJECT_END = 0x0A;
        const byte opSLEEP = 0x0B;
        const byte opPROGRAM_INFO = 0x0C;
        const byte opLABEL = 0x0D;
        const byte opPROBE = 0x0E;
        const byte opDO = 0x0F;

        const short GUI_SLOT = 0;
        const short USER_SLOT = 1;
        const short CMD_SLOT = 2;
        const short TERM_SLOT = 3;
        const short DEBUG_SLOT = 4;
        const short SLOTS = 5;
        const short CURRENT_SLOT = -1;

        [Fact]
        public void TestGlobals()
        {
            var cmd = DirectCommand<DataString>(out var gv, 100);
            var bytes = cmd.ToBytes();
            bytes[1].Should().Be(100);
            bytes[2].Should().Be(0);

            cmd = DirectCommand(out gv, 256);
            bytes = cmd.ToBytes();
            bytes[1].Should().Be(0);
            bytes[2].Should().Be(1);

            // max allowable
            DirectCommand(out gv, 1021);

            // too many
            Action act = () => DirectCommand(out gv, 1022);
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Test_opERROR()
        {
            var cmd = DirectCommand().WithBytecodeObject(VMThread()
                .WithOpcodes(opERROR()));
            Assert.Equal(new byte[] { DirectCommandReply, 0, 0,
                opERROR,
                opOBJECT_END }, cmd.ToBytes());
            Assert.Equal(Unit.Value, cmd.ParseReply(new byte[] { DirectReply }));
        }

        [Fact]
		public void Test_opNOP()
        {
            var cmd = DirectCommand().WithBytecodeObject(VMThread()
                .WithOpcodes(opNOP()));
            Assert.Equal(new byte[] { DirectCommandReply, 0, 0,
                opNOP,
                opOBJECT_END }, cmd.ToBytes());
            Assert.Equal(Unit.Value, cmd.ParseReply(new byte[] { DirectReply }));
        }

        [Fact]
        public void Test_opPROGRAM_STOP()
        {
            var cmd = DirectCommand().WithBytecodeObject(VMThread()
                .WithOpcodes(opPROGRAM_STOP(LocalConstant(CURRENT_SLOT))));
            Assert.Equal(new byte[] { DirectCommandReply, 0, 0,
                opPROGRAM_STOP, 0x3F,
                opOBJECT_END }, cmd.ToBytes());
            Assert.Equal(Unit.Value, cmd.ParseReply(new byte[] { DirectReply }));
        }
    }
}
