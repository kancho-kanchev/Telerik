using System;

//Write a program that prints all possible cards from
//a standard deck of 52 cards (without jokers). The cards
//should be printed with their English names.
//Use nested for loops and switch-case

class DeckOf_52_Cards
{
    static string SignificanceChar(string pSignificance)
    {
        string result = "";
        switch (pSignificance)
        {
            case "Deuce":
                result = "2";
                break;

            case "Trey":
                result = "3";
                break;

            case "Four":
                result = "4";
                break;

            case "Five":
                result = "5";
                break;

            case "Six":
                result = "6";
                break;

            case "Seven":
                result = "7";
                break;

            case "Eight":
                result = "8";
                break;

            case "Nine":
                result = "9";
                break;

            case "Ten":
                result = "10";
                break;

            default:
                result = Convert.ToString(pSignificance[0]);
                break;
        }
        return result;
    }

    static void Main()
    {
        byte deck = 52; //52 or 32 cards
        byte number = 1;
        string[] suit = { "Spades", "Hearts", "Diamonds", "Clubs" };
        byte[] suitChar = { 6, 3, 4, 5 };
        string[] significance = { "Ace", "King", "Queen", "Jack", "Ten", "Nine", "Eight", "Seven", "Six", "Five", "Four", "Trey", "Deuce" };
        // 2 3 4 5 6 7 8 9 10 J Q K A
        // Deuce, Trey, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace.
        // Spades, Hearts, Diamonds, Clubs
        for (int k = 0; k < suit.Length; k++)
        {
            Console.WriteLine("+--+------+----------------+");
            for (int i = 0; i < (deck / suit.Length); i++)
            {
                Console.WriteLine("|{0,2}| {1,2} {2} | {3,5} {4,-8} |", number++, SignificanceChar(significance[i]), (char)suitChar[k], significance[i], suit[k]);
            }
        }
        Console.WriteLine("+--+------+----------------+");
    }
}