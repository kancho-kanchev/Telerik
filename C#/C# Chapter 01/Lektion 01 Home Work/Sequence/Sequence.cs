// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Sequence
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("The "+i+" member of sequence is:  "+(i+1));
            i++;
            Console.WriteLine("The "+i+" member of sequence is: "+(-i-1));
        }
        //Console.WriteLine();
        //Console.WriteLine();
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write(i + 1);
        //    i++;
        //    Console.Write(", "+(-i - 1));
        //    if (i < 10) Console.Write(", ");
        //}
        //Console.WriteLine();
    }
}