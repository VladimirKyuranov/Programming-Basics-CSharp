using System;

class Snowflake
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int outsideDots = 0;
        int insideDots = size;
        string rowToPrint = "";

        for (int row = 0; row < size - 1; row++)
        {
            rowToPrint = $"{new string('.', outsideDots)}*{new string('.', insideDots)}*{new string('.', insideDots)}*{new string('.', outsideDots)}";
            Console.WriteLine(rowToPrint);
            insideDots--;
            outsideDots++;
        }

        for (int row = 0; row < 3; row++)
        {
            if (row == 1)
            {
                rowToPrint = new string('*', 2 * size + 3);
            }
            else
            {
                rowToPrint = $"{new string('.', size - 1)}*****{new string('.', size - 1)}";
            }

            Console.WriteLine(rowToPrint);
        }

        insideDots++;
        outsideDots--;

        for (int i = size - 2; i > -1; i--)
        {
            rowToPrint = $"{new string('.', outsideDots)}*{new string('.', insideDots)}*{new string('.', insideDots)}*{new string('.', outsideDots)}";
            Console.WriteLine(rowToPrint);
            insideDots++;
            outsideDots--;
        }
    }
}