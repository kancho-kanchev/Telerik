using System;
using System.Globalization;
//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, BIC code and
//3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account
//using the appropriate data types and descriptive names.
class SingleBankAccount
{
    static void Main()
    {
        string holderName = ""; //first name, middle name and last name
        decimal balance = 0.0M;
        string bankName = "";
        string IBAN = "";
        string BIC = "";
        ulong cardNumberOne = 0L;
        ulong cardNumberTwo = 0L;
        ulong cardNumberThree = 0L;
        Console.WriteLine("Holder name (first name, middle name and last name): " + holderName);
        Console.WriteLine("Balance: " + balance.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine("BIC: " + BIC);
        Console.WriteLine("Credit card number 1: " + cardNumberOne);
        Console.WriteLine("Credit card number 2: " + cardNumberTwo);
        Console.WriteLine("Credit card number 3: " + cardNumberThree);
    }
}