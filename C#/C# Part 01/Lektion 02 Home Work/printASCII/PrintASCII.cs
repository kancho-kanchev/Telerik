using System;
using System.Text;
//Write a program that prints the entire ASCII table of characters on the console.
class PrintASCII
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int countRow = 0;
        int countCol = 0;
        int count = 0;
        int rowMax = 16;
        int colMax = 8;
        Console.WriteLine("{0}ASCII Table 0-127",'\u0009');
        Console.WriteLine();
        for (countRow = 0; countRow < rowMax; countRow++)
        {
            count = countRow;
            for (countCol = 0; countCol < colMax; countCol++)
            {
                if (count < 32)
                {
                    switch (count)
                    {
                        case 0:
                            Console.Write("  {0,3:000}   nul   ", count);
                            break;
                        case 1:
                            Console.Write("  {0,3:000} {1,1} soh   ", count, (char)count);
                            break;
                        case 2:
                            Console.Write("  {0,3:000} {1,1} stx   ", count, (char)count);
                            break;
                        case 3:
                            Console.Write("  {0,3:000} {1,1} etx   ", count, (char)count);
                            break;
                        case 4:
                            Console.Write("  {0,3:000} {1,1} eot   ", count, (char)count);
                            break;
                        case 5:
                            Console.Write("  {0,3:000} {1,1} enq   ", count, (char)count);
                            break;
                        case 6:
                            Console.Write("  {0,3:000} {1,1} ack   ", count, (char)count);
                            break;
                        case 7:
                            Console.Write("  {0,3:000}   bel   ", count);
                            break;
                        case 8:
                            Console.Write("  {0,3:000}   bs    ", count);
                            break;
                        case 9:
                            Console.Write("  {0,3:000}   tab   ", count);
                            break;
                        case 10:
                            Console.Write("  {0,3:000}   lf    ", count);
                            break;
                        case 11:
                            Console.Write("  {0,3:000} {1,1} vt    ", count, (char)count);
                            break;
                        case 12:
                            Console.Write("  {0,3:000} {1,1} ff    ", count, (char)count);
                            break;
                        case 13:
                            Console.Write("  {0,3:000}   cr    ", count);
                            break;
                        case 14:
                            Console.Write("  {0,3:000} {1,1} so    ", count, (char)count);
                            break;
                        case 15:
                            Console.Write("  {0,3:000} {1,1} si    ", count, (char)count);
                            break;
                        case 16:
                            Console.Write("{0,3:000} {1,1} dle   ", count, (char)count);
                            break;
                        case 17:
                            Console.Write("{0,3:000} {1,1} dc1   ", count, (char)count);
                            break;
                        case 18:
                            Console.Write("{0,3:000} {1,1} dc2   ", count, (char)count);
                            break;
                        case 19:
                            Console.Write("{0,3:000} {1,1} dc3   ", count, (char)count);
                            break;
                        case 20:
                            Console.Write("{0,3:000} {1,1} dc4   ", count, (char)count);
                            break;
                        case 21:
                            Console.Write("{0,3:000} {1,1} nak   ", count, (char)count);
                            break;
                        case 22:
                            Console.Write("{0,3:000} {1,1} syn   ", count, (char)count);
                            break;
                        case 23:
                            Console.Write("{0,3:000} {1,1} etb   ", count, (char)count);
                            break;
                        case 24:
                            Console.Write("{0,3:000} {1,1} can   ", count, (char)count);
                            break;
                        case 25:
                            Console.Write("{0,3:000} {1,1} em    ", count, (char)count);
                            break;
                        case 26:
                            Console.Write("{0,3:000} {1,1} sub   ", count, (char)count);
                            break;
                        case 27:
                            Console.Write("{0,3:000} {1,1} esc   ", count, (char)count);
                            break;
                        case 28:
                            Console.Write("{0,3:000} {1,1} fs    ", count, (char)count);
                            break;
                        case 29:
                            Console.Write("{0,3:000} {1,1} gs    ", count, (char)count);
                            break;
                        case 30:
                            Console.Write("{0,3:000} {1,1} rs    ", count, (char)count);
                            break;
                        case 31:
                            Console.Write("{0,3:000} {1,1} us    ", count, (char)count);
                            break;
                    }
                }
                else Console.Write("{0,3:000} {1,1}   ", count, (char)count);
                count = count + rowMax;
            }
            Console.WriteLine();
            if ((count == 128)&&(countRow==rowMax)) break;
        }
        Console.WriteLine();
        Console.WriteLine("ASCII Name Description");
        Console.WriteLine();
        Console.WriteLine("nul-null byte       bs -backspace       lf-newline        ff -formfeed");
        Console.WriteLine("bel-bell character  tab-horizontal tab  vt -vertical tab  cr -carriage return");
        Console.WriteLine("                                                          esc-escape");
        Console.Write("Press any key to show Extended ASCII Codes...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("{0}Extended ASCII Codes 128-255", '\u0009');
        Console.WriteLine();
        for (countRow = 0; countRow < rowMax; countRow++)
        {
            count = countRow;
            for (countCol = 0; countCol < colMax; countCol++)
            {
                Console.Write("{0,3:000} {1,1}   ", (count+128), (char)(count+128));
                count = count + rowMax;
            }
            Console.WriteLine();
            if ((count == 128) && (countRow == rowMax)) break;
        }

    }
}