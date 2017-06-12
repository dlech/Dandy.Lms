using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentAssertions;
using Xunit;

using static Dandy.Lms.Bytecodes.EV3.BytecodeFactory;
using static Dandy.Lms.Bytecodes.EV3.Constants.Defines;
using static Dandy.Lms.Bytecodes.EV3.Constants.BUTTONTYPE;
using static Dandy.Lms.Bytecodes.EV3.Constants.FONTTYPE;
using static Dandy.Lms.Bytecodes.EV3.Constants.LEDPATTERN;
using static Dandy.Lms.Bytecodes.EV3.Constants.N_ICON_NO;

namespace Dandy.Lms.Bytecodes.EV3.Test
{
    public class EV3ProgramTests
    {
        static IExpression<Data8> LC8(int value) => LocalConstant((sbyte)value);
        static IExpression<Data8> LC8(uint value) => LocalConstant((sbyte)value);
        static IExpression<Data8> LC8(Enum value) => LocalConstant((sbyte)(int)(object)value);
        static IExpression<Data16> LC16(int value) => LocalConstant((short)value);
        static IExpression<Data32> LC32(int value) => LocalConstant(value);
        static IExpression<DataString> LCS(string value) => LocalConstant(value);

        [Fact]
        public void TestChangeName()
        {
            var appv = LCS("Change Name V1.02");

            // subcalls
            var changeName = LC16(2);

            // program based on Test/Change Name.lms
            var program = Program().WithBytecodeObjects(
                VMThread()
                    .WithLocals<Data8>(out var showVersion, Data8.FixedSize)
                    .WithLabels(out var dontShowVersion, out var showVersionWait)
                    .WithOpcodes(
                        opUI_BUTTON(cmdPRESSED(LC8(RIGHT_BUTTON), showVersion)),
                        opJR_FALSE(showVersion, dontShowVersion),

                        opUI_DRAW(cmdFILLRECT(LC8(BG_COLOR), LC16(4), LC16(50), LC16(170), LC16(28))),
                        opUI_DRAW(cmdRECT(LC8(FG_COLOR), LC16(6), LC16(52), LC16(166), LC16(24))),
                        opUI_DRAW(cmdTEXT(LC8(FG_COLOR), LC16(13), LC16(60), appv)),
                        opUI_DRAW(cmdUPDATE()),

                        opLABEL(showVersionWait),

                        opUI_BUTTON(cmdPRESSED(LC8(RIGHT_BUTTON), showVersion)),
                        opJR_TRUE(showVersion, showVersionWait),

                        opUI_BUTTON(cmdFLUSH()),

                        opLABEL(dontShowVersion),

                        opUI_DRAW(cmdRESTORE(LC8(0))),
                        opUI_DRAW(cmdTOPLINE(LC8(0))),
                        opUI_BUTTON(cmdSET_BACK_BLOCK(LC8(1))),
                        opUI_WRITE(cmdLED(LC8(LED_GREEN))),

                        opCALL(changeName, LC8(0)),

                        opUI_BUTTON(cmdFLUSH()),
                        opUI_BUTTON(cmdSET_BACK_BLOCK(LC8(0))),
                        opUI_DRAW(cmdTOPLINE(LC8(1))
                    )
                ),
                Subcall()
                    .WithLocals<Data8, DataString>(out var state, Data8.FixedSize, out var @string, BRICKNAMESIZE)
                    .WithLabels(out var noString)
                    .WithOpcodes(
                        opUI_DRAW(cmdFILLWINDOW(LC8(0x00), LC16(0), LC16(0))),
                        opUI_DRAW(cmdSELECT_FONT(LC8(SMALL_FONT))),
                        opUI_DRAW(cmdTEXT(LC8(FG_COLOR), LC16(0), LC16(1), LCS("Change Name"))),
                        opUI_DRAW(cmdLINE(LC8(FG_COLOR), LC16(0), LC16(TOPLINE_HEIGHT), LC16(LCD_WIDTH), LC16(TOPLINE_HEIGHT))),
                        opUI_DRAW(cmdSELECT_FONT(LC8(NORMAL_FONT))),

                        opCOM_GET(cmdGET_BRICKNAME(LC8(BRICKNAMESIZE), @string)),
                        opMOVE8_8(LC8(CHARSET_NAME), state),
                        opUI_DRAW(cmdKEYBOARD(LC8(FG_COLOR), LC16(16), LC16(19), LC8(ICON_NONE), LC8(BRICKNAMESIZE), LCS("Brick Name"), state, @string)),

                        opJR_FALSE(@string[0], noString),
                        opCOM_SET(cmdSET_BRICKNAME(@string)),

                        opLABEL(noString)
                    )
            );
            var bytes = program.ToBytes();
            
            // bytes from Test/Change Name.rbf
            var rbf = new byte[]
            {
                0x4C, 0x45, 0x47, 0x4F, 0xD2, 0x00, 0x00, 0x00, 0x6D, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x28, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x83, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x01, 0x00, 0x79, 0x00, 0x00, 0x00, 0x83, 0x09, 0x04, 0x40, 0x41, 0x40, 0x82, 0x3A,
                0x00, 0x84, 0x09, 0x00, 0x04, 0x81, 0x32, 0x82, 0xAA, 0x00, 0x1C, 0x84, 0x0A, 0x01, 0x06, 0x81,
                0x34, 0x82, 0xA6, 0x00, 0x18, 0x84, 0x05, 0x01, 0x0D, 0x81, 0x3C, 0x80, 0x43, 0x68, 0x61, 0x6E,
                0x67, 0x65, 0x20, 0x4E, 0x61, 0x6D, 0x65, 0x20, 0x56, 0x31, 0x2E, 0x30, 0x32, 0x00, 0x84, 0x00,
                0x83, 0x09, 0x04, 0x40, 0x42, 0x40, 0x82, 0xF7, 0xFF, 0x83, 0x04, 0x84, 0x1A, 0x00, 0x84, 0x12,
                0x00, 0x83, 0x0A, 0x01, 0x82, 0x1B, 0x01, 0x09, 0x02, 0x00, 0x83, 0x04, 0x83, 0x0A, 0x00, 0x84,
                0x12, 0x01, 0x0A, 0x00, 0x84, 0x13, 0x00, 0x00, 0x00, 0x84, 0x11, 0x01, 0x84, 0x05, 0x01, 0x00,
                0x01, 0x80, 0x43, 0x68, 0x61, 0x6E, 0x67, 0x65, 0x20, 0x4E, 0x61, 0x6D, 0x65, 0x00, 0x84, 0x03,
                0x01, 0x00, 0x0A, 0x82, 0xB2, 0x00, 0x0A, 0x84, 0x11, 0x00, 0xD3, 0x0D, 0x81, 0x78, 0x41, 0x30,
                0x01, 0x40, 0x84, 0x0D, 0x01, 0x10, 0x13, 0x3F, 0x81, 0x78, 0x80, 0x42, 0x72, 0x69, 0x63, 0x6B,
                0x20, 0x4E, 0x61, 0x6D, 0x65, 0x00, 0x40, 0x41, 0x41, 0x41, 0x82, 0x03, 0x00, 0xD4, 0x08, 0x41,
                0x08, 0x0A,
            };

            bytes.Should().Equal(rbf);
        }
    }
}
