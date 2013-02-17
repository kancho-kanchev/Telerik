using System;
//Which of the following values can be assigned to a variable of type
//float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
class FloatAndDouble
{
    static void Main()
    {
        double a = 34.567839023d;
        float b = 12.345f;
        double c = 8923.1234857d;
        float d = 3456.091f;
        Console.WriteLine("double {0,15:n9}",a);
        Console.WriteLine("float {0,10:n3}",b);
        Console.WriteLine("double {0,6:n7}", c);
        Console.WriteLine("float {0,10:n3}", d);
    }
}