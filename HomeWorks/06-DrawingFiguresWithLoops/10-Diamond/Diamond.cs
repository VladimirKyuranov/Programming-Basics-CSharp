using System;

class Diamond
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int starsCount = 1;
        int rowsCount = size;

        if (size % 2 == 0)
        {
            starsCount = 2;
            rowsCount = size - 1;
        }

        int sideDashes = (size - starsCount) / 2;
        int middleDashes = starsCount - 2;
        string row;


        for (int rowNumber = 1; rowNumber <= rowsCount / 2 + 1; rowNumber++)
        {
            if (rowNumber == 1)
            {
                row = $"{new string('-', sideDashes)}{new string('*', starsCount)}{new string('-', sideDashes)}";
            }
            else
            {
                row = $"{new string('-', sideDashes)}*{new string('-', middleDashes)}*{new string('-', sideDashes)}";
            }
            sideDashes--;
            middleDashes += 2;
            Console.WriteLine(row);
        }

        sideDashes += 2;
        middleDashes -= 4;

        for (int i = 1; i <= rowsCount / 2; i++)
        {
            if (i == rowsCount / 2)
            {
                row = $"{new string('-', sideDashes)}{new string('*', starsCount)}{new string('-', sideDashes)}";
            }
            else
            {
                row = $"{new string('-', sideDashes)}*{new string('-', middleDashes)}*{new string('-', sideDashes)}";
            }

            sideDashes++;
            middleDashes -= 2;
            Console.WriteLine(row);
        }
    }
}