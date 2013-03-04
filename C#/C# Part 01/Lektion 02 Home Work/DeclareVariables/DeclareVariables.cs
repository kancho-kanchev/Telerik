using System;
//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
//52130, -115, 4825932, 97, -10000
class DeclareVariables
{
    static void Main()
    {
        sbyte varSByte = -115;
        byte varByte = 97;
        short varShort = -10000;
        ushort varUShort = 52130;
        uint varUInt = 4825932;
        Console.WriteLine("UShort  52 130 =? {0,9:n0}", varUShort);
        Console.WriteLine("SByte     -115 =? {0,9:n0}", varSByte);
        Console.WriteLine("UInt 4 825 932 =? {0,9:n0}", varUInt);
        Console.WriteLine("byte        97 =? {0,9:n0}", varByte);
        Console.WriteLine("short  -10 000 =? {0,9:n0}", varShort);
    }
}