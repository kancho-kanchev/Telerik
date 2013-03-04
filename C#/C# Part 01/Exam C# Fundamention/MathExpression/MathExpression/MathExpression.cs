using System;

class MathExpression
{
    static void Main()
    {
        decimal N = Convert.ToDecimal(Console.ReadLine());
        decimal M = Convert.ToDecimal(Console.ReadLine());
        decimal P = Convert.ToDecimal(Console.ReadLine());
        decimal varLongFloat =128.523123123M;
        int angle = (int)M % 180;
        decimal result = ((N * N + 1 / (M * P) + 1337) / (N - varLongFloat * P)) + (decimal)Math.Sin((double)angle);
        Console.WriteLine("{0:0.000000}", result);
    }
}