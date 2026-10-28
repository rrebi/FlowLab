using System;
using System.Collections.Generic;
using System.Text;

namespace FlowLab.Core;

public static class RegisterConverter
{
    public static float ToFloat(ushort highWord, ushort lowWord)
    //conversion: unsigned int-> shift 16 left -> 32 bit number
    {
        uint bits = ((uint)highWord << 16) | lowWord;   // 0x000041CC  << 16  =  0x41CC0000 | 0x0000 = 0x41CC0000
        return BitConverter.Int32BitsToSingle(unchecked((int)bits)); // 32 bit number
    }
}

