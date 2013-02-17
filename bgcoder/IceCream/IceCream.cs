using System;

class IceCream
{
    static void Main()
    {
        byte SlonchetaN;
        string SlonchetaK;
        string[] LineLoniMoni;
        byte NumberSlonchetaEat=0;
        LineLoniMoni = Console.ReadLine().Split();
        SlonchetaN = Convert.ToByte(LineLoniMoni [0]);
        SlonchetaK = LineLoniMoni[1];
        for (int i = 0; i < SlonchetaK.Length; i++)
        {
            if ('0' != SlonchetaK[i]) NumberSlonchetaEat++;
        }
        Console.WriteLine(SlonchetaN - NumberSlonchetaEat);
    }
}
