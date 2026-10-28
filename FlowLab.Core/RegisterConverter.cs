using System;
using System.Collections.Generic;
using System.Text;

namespace FlowLab.Core;

public static class RegisterConverter
{
    public static float ToFloat(ushort highWord, ushort lowWord)
    //highWord-first 16 bits chunk in Modbus
    {
        uint bits = ((uint)highWord << 16) | lowWord;   //conversion: unsigned int highWord-> shift 16 left -> add lowWord-> 32 bit number
        return BitConverter.Int32BitsToSingle(unchecked((int)bits)); 
    }

    public static (ushort High, ushort Low) FromFloat (float value)
 
    {
        uint bits = unchecked((uint)BitConverter.SingleToInt32Bits(value));
        ushort high = (ushort)(bits >> 16);
        ushort low = (ushort)(bits & 0xFFFF);
        return (high, low);
    }
}
