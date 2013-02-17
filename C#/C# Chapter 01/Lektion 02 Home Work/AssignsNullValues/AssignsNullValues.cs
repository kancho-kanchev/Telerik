using System;
//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.

class AssignsNullValues
{
    static void Main()
    {
        int? valueInt = null;
        double? valueDouble = null;
        Console.WriteLine("This is the integer with Null value -> " + valueInt);
        Console.WriteLine("This is the double  with Null value -> " + valueDouble);
        Console.WriteLine("This is the integer with Null value or default -> " + valueInt.GetValueOrDefault());
        Console.WriteLine("This is the double  with Null value or default -> " + valueDouble.GetValueOrDefault());
        valueInt = valueInt + 2;
        valueDouble = valueDouble + 2.2;
        Console.WriteLine("This is the integer with value or default -> " + valueInt.GetValueOrDefault());
        Console.WriteLine("This is the double  with value or default -> " + valueDouble.GetValueOrDefault());
        valueInt = null;
        valueInt = valueInt+null;
        valueDouble = null;
        valueDouble = valueDouble + null;
        Console.WriteLine("This is the integer with Null + Null value or default -> " + valueInt.GetValueOrDefault());
        Console.WriteLine("This is the double  with Null + Null value or default -> " + valueDouble.GetValueOrDefault());
    }
}