using System;

class SoftUniLogo
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dots = 6 * size - 3;
        int hashtags = 1;
        string rowToPrint = "";

        for (int row = 0; row < 2 * size; row++)
        {
            rowToPrint = $"{new string ('.', dots)}{new string('#', hashtags)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots -= 3;
            hashtags += 6;
        }

        dots += 6;
        hashtags -= 12;

        for (int row = 0; row < size - 2; row++)
        {
            rowToPrint = $"|{new string('.', dots)}{new string('#', hashtags)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
            dots += 3;
            hashtags -= 6;
        }

        for (int row = 1; row <= size; row++)
        {
            if (row == size)
            {
                Console.Write("@");
            }
            else
            {
                Console.Write("|");
            }

            rowToPrint = $"{new string('.', dots)}{new string('#', hashtags)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);
        }
    }
}