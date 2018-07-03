using System;

class House
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int stars = 1;
        string row;

        if (size % 2 == 0)
        {
            stars = 2;
        }

        int dashes = (size - stars) / 2;

        for (int rowNumber = 1; rowNumber <= size; rowNumber++)
        {
            if (rowNumber <= (size + 1) / 2)
            {
                row = $"{new string('-', dashes)}{new string('*', stars)}{new string('-', dashes)}";
                dashes--;
                stars += 2;
            }
            else
            {
                row = $"|{new string('*', stars - 4)}|";
            }

            Console.WriteLine(row);
        }
    }
}