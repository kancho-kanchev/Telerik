using System;
//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the
//first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable
//(you should perform type casting).
class StringToObjectToString
{
    static void Main()
    {
        string string1 = "Hello";
        string string2 = "World";
        object objectVariable = string1+" "+string2;
        string string3 = (string)objectVariable;
        Console.WriteLine(string3);
    }
}