using System;
//Each record would have the following characteristics –
//first name, family name, age, gender (m or f), ID number,
//unique employee number (27 560 000 to 27 569 999).
//Declare the variables needed to keep the information for a single employee
//using appropriate data types and descriptive names.
class EmployeesRecord
{
    static void Main()
    {
        string firsName = "";
        string lastName = "";
        byte age = 0;       //0 to 255
        char gender = ' ';  //m||f
        ushort IDNumber = 0; // (27569999-27560000=1000=>0 to 65 535 )
        uint uniqueNumber = 0; // 0 to 4 294 967 295
        Console.WriteLine("FirstName: "+firsName);
        Console.WriteLine("LastName: "+lastName);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Gender: "+gender);
        Console.WriteLine("IDNumber: "+IDNumber);
        Console.WriteLine("UniqueNumber: "+uniqueNumber);
    }
}