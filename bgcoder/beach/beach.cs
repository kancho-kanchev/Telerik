using System;

class beach
{
    static void Main()
    {
        byte LoniBeginTimeH;
        byte LoniBeginTimeM;
        byte LoniEndTimeH;
        byte LoniEndTimeM;
        byte MoniBeginTimeH;
        byte MoniBeginTimeM;
        byte MoniEndTimeH;
        byte MoniEndTimeM;
        byte BuferTimeByte;
        int BuferTime;
        int LoniBeginTime;
        int LoniEndTime;
        int MoniBeginTime;
        int MoniEndTime;
        string[] LineLoniMoni;
        LineLoniMoni = Console.ReadLine().Split();
        LoniBeginTimeH = Convert.ToByte(LineLoniMoni[0]);
        LoniBeginTimeM = Convert.ToByte(LineLoniMoni[1]);
        LoniEndTimeH = Convert.ToByte(LineLoniMoni[2]);
        LoniEndTimeM = Convert.ToByte(LineLoniMoni[3]);
        MoniBeginTimeH = Convert.ToByte(LineLoniMoni[4]);
        MoniBeginTimeM = Convert.ToByte(LineLoniMoni[5]);
        MoniEndTimeH = Convert.ToByte(LineLoniMoni[6]);
        MoniEndTimeM = Convert.ToByte(LineLoniMoni[7]);
        LoniBeginTime = Convert.ToInt32(LineLoniMoni[0]) * 60 + Convert.ToInt32(LineLoniMoni[1]);
        LoniEndTime = Convert.ToInt32(LineLoniMoni[2]) * 60 + Convert.ToInt32(LineLoniMoni[3]);
        MoniBeginTime = Convert.ToInt32(LineLoniMoni[4]) * 60 + Convert.ToInt32(LineLoniMoni[5]);
        MoniEndTime = Convert.ToInt32(LineLoniMoni[6]) * 60 + Convert.ToInt32(LineLoniMoni[7]);
        if (LoniBeginTime > MoniBeginTime)
        {
            BuferTimeByte = MoniBeginTimeH;
            MoniBeginTimeH = LoniBeginTimeH;
            LoniBeginTimeH = BuferTimeByte;
            BuferTimeByte = MoniBeginTimeM;
            MoniBeginTimeM = LoniBeginTimeM;
            LoniBeginTimeM = BuferTimeByte;
            BuferTimeByte = MoniEndTimeH;
            MoniEndTimeH = LoniEndTimeH;
            LoniEndTimeH = BuferTimeByte;
            BuferTimeByte = MoniEndTimeM;
            MoniEndTimeM = LoniEndTimeM;
            LoniEndTimeM = BuferTimeByte;
            BuferTime = MoniBeginTime;
            MoniBeginTime = LoniBeginTime;
            LoniBeginTime = MoniBeginTime;
            BuferTime = MoniEndTime;
            MoniEndTime = LoniEndTime;
            LoniEndTime = BuferTime;
        }
        if (MoniBeginTime <= LoniEndTime)
        {
            if (LoniEndTime >= MoniEndTime)
            {
                Console.WriteLine(MoniBeginTimeH + " " + MoniBeginTimeM + " " + MoniEndTimeH + " " + MoniEndTimeM);
            }
            else
            {
                Console.WriteLine(MoniBeginTimeH + " " + MoniBeginTimeM + " " + LoniEndTimeH + " " + LoniEndTimeM);
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}