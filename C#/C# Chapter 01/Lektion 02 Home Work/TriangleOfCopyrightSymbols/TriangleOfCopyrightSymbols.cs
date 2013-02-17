using System;
using System.Text;
//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.
//Note: the © symbol may be displayed incorrectly.
class TriangleOfCopyrightSymbols
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int countInRow = 1;
        int countRow = 0;
        int charNumbers = 25;
        char simbol = (char)0xA9;
        //char simbol = '\u00A9';
        int writeSimbol = 1;
        string rowToWrite = "";
        while (writeSimbol <= charNumbers)
        {
            for (int i = 1; i <= countInRow; i++)
            {
                if (writeSimbol <= charNumbers) writeSimbol++;
            }
            countInRow=countInRow+2;
        }
        writeSimbol = 1;
        countRow = ((countInRow+1)/2)-1;
        countInRow = countInRow - 2;
        for (int i = 1; i <= countRow; i++)
        {
            for (int j = 1; j <= countInRow; j++)
            {
                if ((j <= ((countInRow - writeSimbol) / 2))||(j > ((countInRow - writeSimbol) / 2)+writeSimbol))
                {
                    rowToWrite = rowToWrite + " ";
                }
                else
                {
                    rowToWrite=rowToWrite+simbol;
                }
            }
            writeSimbol = writeSimbol + 2;
            Console.WriteLine(rowToWrite);
            rowToWrite="";
        }
    }
}