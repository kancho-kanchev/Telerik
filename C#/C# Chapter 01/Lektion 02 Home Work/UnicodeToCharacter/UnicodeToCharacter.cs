using System;
//Declare a character variable and assign it with the symbol that has Unicode code 72.
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72
class UnicodeToCharacter
{
    static void Main()
    {
//        char variable = (char)0x48;
        char variable = '\u0048';
        Console.WriteLine("The symbol \"{0}\" has unicode number \"72\" in decimal and \"48\" in hexadecimal.", variable);
    }
}