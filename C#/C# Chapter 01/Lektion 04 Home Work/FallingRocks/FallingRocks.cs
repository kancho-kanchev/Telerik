using System;
using System.Numerics;
using System.Threading;
//Implement the "Falling Rocks" game in the text console

class FallingRocks
{
    static int lives = 12;
    static int difficulty = 50;
    static BigInteger result = 0;
    static int point = 10;
    static int positionDwarf = 0;
    static bool boom = false;
    static char[,] dwarf = { { '(', 'O', ')' }, { 'w', 'w', 'w' } }; // with color
    static char[,] availableRocks =  {{ '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' },
                                      { 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r', 'r' },
                                      { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }}; // color and point
    static int rocksRow = Console.WindowHeight-1;
    static int tableRowWidth = Console.WindowWidth - 2;
    static char[, ,] rocksArea = new char[tableRowWidth, rocksRow+1, 2];//rock and color
    static Random randomGenerator = new Random();

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void SetInitiolPositions()
    {
        int wichRock = 0;
        int isRock = 0;
        bool checkBoom = true;
        positionDwarf = (tableRowWidth / 2) - 1;
        //generate rocks
        while (checkBoom)
        {
            for (int y = 0; y <= rocksRow; y++)
            {
                for (int x = 0; x < tableRowWidth; x++)
                {
                    wichRock = randomGenerator.Next(0, availableRocks.Length / 3);
                    isRock = randomGenerator.Next(0, difficulty);
                    if (isRock > 0) rocksArea[x, y, 0] = ' ';
                    else rocksArea[x, y, 0] = availableRocks[0, wichRock];
                }
            }
            for (int x = 0; x < (dwarf.Length / 2); x++)
            {
                rocksArea[positionDwarf + x, rocksRow, 0] = dwarf[0, x];
                rocksArea[positionDwarf + x, rocksRow, 1] = dwarf[1, x];
            }
            checkBoom = CheckBoom();
        }
    }

    static void DrawPointsAndLives()
    {
        PrintAtPosition(10, 0, "points: " + result);
        PrintAtPosition(70, 0, "lives: " + lives);
    }

    static void PrintAtPosition(int x, int y, string str)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(str);
    }

    static void DrawDwarf()
    {
        for (int x = 0; x < (dwarf.Length / 2); x++)
        {
            rocksArea[positionDwarf + x, rocksRow, 0] = dwarf[0, x];
            rocksArea[positionDwarf + x, rocksRow, 1] = dwarf[1, x];
        }

        //for (int i = 0; i < dwarf.Length/2; i++)
        //{
        //    PrintAtPosition(positionDwarf + i, rocksRow, Convert.ToString(dwarf[0, i]));
        //}
    }

    static void ClearDrowf()
    {
        for (int x = 0; x < (dwarf.Length / 2); x++)
        {
            rocksArea[positionDwarf + x, rocksRow, 0] = ' ';
            rocksArea[positionDwarf + x, rocksRow, 1] = ' ';
        }
    }

    static void MoveDwarfRight()
    {
        if (positionDwarf < tableRowWidth - 3)
        {
            rocksArea[positionDwarf, rocksRow, 0] = ' ';
            rocksArea[positionDwarf, rocksRow, 1] = ' ';
            //PrintAtPosition(positionDwarf, rocksRow, " ");
            positionDwarf++;
        }
    }

    static void MoveDwarfLeft()
    {
        if (positionDwarf > 0)
        {
            rocksArea[positionDwarf + 2, rocksRow, 0] = ' ';
            rocksArea[positionDwarf + 2, rocksRow, 1] = ' ';
            //PrintAtPosition(positionDwarf + 2, rocksRow, " ");
            positionDwarf--;
        }
    }

    static bool CheckBoom()
    {
        bool check = false;
        for (int x = 0; x < dwarf.Length / 2; x++)
        {
            if (rocksArea[positionDwarf + x, rocksRow - 1, 0] != ' ') check = true;
        }
        return check;
    }

    static void DrawRocks()
    {
        for (int y = 1; y <= rocksRow; y++)
        {
            for (int x = 0; x < tableRowWidth; x++)
            {
                PrintAtPosition(x, y, Convert.ToString(rocksArea[x, y, 0]));
            }
        }
    }

    static void GenerateRowRocs()
    {
        //char[,] rocksRowBuffer = new char[tableRowWidth, 2];//rock and color
        int wichRock = 0;
        int isRock = 0;
        boom = CheckBoom();
        if (boom) return;
        //move rocks
        ClearDrowf();
        for (int x = 0; x < tableRowWidth; x++)
        {
            if (rocksArea[x, rocksRow, 0] != ' ') result = result + point;
        }
        for (int y = rocksRow; y > 0; y--)
        {
            for (int x = 0; x < tableRowWidth; x++)
            {
                rocksArea[x, y, 0] = rocksArea[x, y - 1, 0];
                rocksArea[x, y, 1] = rocksArea[x, y - 1, 1];
            }
        }
        for (int x = 0; x < tableRowWidth; x++)
        {
            wichRock = randomGenerator.Next(0, availableRocks.Length / 3);
            isRock = randomGenerator.Next(0, difficulty);
            if (isRock > 0) rocksArea[x, 0, 0] = ' ';
            else rocksArea[x, 0, 0] = availableRocks[0, wichRock];
        }
        DrawDwarf();
        DrawPointsAndLives();
    }

    static void Main()
    {
        RemoveScrollBars();
        while (lives>0)
        {
            SetInitiolPositions();
            Thread.Sleep(1500); 
            Console.Clear();
            DrawPointsAndLives();
            //Console.Write("rocksRow: {0}; tableRowWidth: {1}; rocksArea: {2};", rocksRow, tableRowWidth, (rocksArea.Length /(tableRowWidth)/2));
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    //PrintAtPosition(tableRowWidth, rocksRow, " ");
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if ((keyInfo.Key == ConsoleKey.Q) || (keyInfo.Key == ConsoleKey.Escape))
                    {
                        lives = 0;
                    }
                }
                if (lives == 0) break;
                DrawDwarf();    //moove dwarf
                DrawRocks();    //move rocks
                GenerateRowRocs();
                if (boom)
                {
                    PrintAtPosition(tableRowWidth/2, 0, "BOOM");
                    boom = false;
                    if (lives > 0)
                    {
                        lives--;
                        DrawPointsAndLives();
                        break;
                    }
                    else break;
                }
                Thread.Sleep(150);
            }
        }
    }
}