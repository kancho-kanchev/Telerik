using System;

class elmessage
{
    static void Main()
    {
        int MyBuffer = 0;
        int NumberSimbols = 0;
        string ElMessage;
        ElMessage = Console.ReadLine().ToLower();
        for (int i = 0; i < (ElMessage.Length - 1); i++) //Lenght-1 because Lenght = '.' 
        {
            //if (((ElMessage[i] >= 'A') && (ElMessage[i] <= 'Z')) || ((ElMessage[i] >= 'a') && (ElMessage[i] <= 'z')) || ((ElMessage[i] >= '0') && (ElMessage[i] <= '9')) || (ElMessage[i] == ' '))
            if ( char.IsLetterOrDigit(ElMessage[i]) || (ElMessage[i] == ' '))
            {
                if (MyBuffer > NumberSimbols)
                {
                    NumberSimbols = MyBuffer;
                }
                MyBuffer = 0;
            }
            else
            {
                MyBuffer++;
            }
        }
        Console.WriteLine(NumberSimbols);
    }
}

/*

using System;
  
class elmessage
{
    static void Main()
    {
        int MyBuffer = 0;
        int NumberSimbols = 0;
        string ElMessage;
        ElMessage = Console.ReadLine();
        for (int i = 0; i < (ElMessage.Length - 1); i++) //Lenght-1 because Lenght = '.'
        {
            if ( char.IsLetterOrDigit(ElMessage[i]) || (ElMessage[i] == ' '))
            {
                if (MyBuffer > NumberSimbols)
                {
                    NumberSimbols = MyBuffer;
                }
                MyBuffer = 0;
            }
            else
            {
                MyBuffer++;
            }
        }
        if (NumberSimbols != 0)
        {
            Console.WriteLine(NumberSimbols);
        }
    }
}

*/