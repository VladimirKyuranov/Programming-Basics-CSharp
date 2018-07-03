using System;

class ChristmasToy
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int dashes = 2 * size - 2;
        int middle = size + 2;
        int stars = 1;
        string firstLastRow = $"{new string('-', size * 2)}{new string('*', size)}{new string('-', size * 2)}";
        string middleRow = $"{new string('-', size / 2)}*{new string('|', 4 * size - 2)}*{new string('-', size / 2)}";
        string rowToPrint = "";

        Console.WriteLine(firstLastRow);

        for (int row = 0; row < size / 2; row++)
        {
            rowToPrint = $"{new string('-', dashes)}{new string('*', stars)}{new string('&', middle)}{new string('*', stars)}{new string('-', dashes)}";
            Console.WriteLine(rowToPrint);
            dashes -= 2;
            middle += 2;
            stars++;
        }

        stars -= 2;
        middle += 2;
        dashes++;

        for (int row = 0; row < size / 2; row++)
        {
            rowToPrint = $"{new string('-', dashes)}{new string('*', stars)}{new string('~', middle)}{new string('*', stars)}{new string('-', dashes)}";
            Console.WriteLine(rowToPrint);
            dashes --;
            middle += 2;
        }

        Console.WriteLine(middleRow);
        dashes++;
        middle -= 2;

        for (int row = 0; row < size / 2; row++)
        {
            rowToPrint = $"{new string('-', dashes)}{new string('*', stars)}{new string('~', middle)}{new string('*', stars)}{new string('-', dashes)}";
            Console.WriteLine(rowToPrint);
            dashes++;
            middle -= 2;
        }

        stars++;
        middle -= 2;

        for (int row = 0; row < size / 2; row++)
        {
            rowToPrint = $"{new string('-', dashes)}{new string('*', stars)}{new string('&', middle)}{new string('*', stars)}{new string('-', dashes)}";
            Console.WriteLine(rowToPrint);
            dashes += 2;
            middle -= 2;
            stars--;
        }

        Console.WriteLine(firstLastRow);
    }
}