using System;

class Sheriff
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        string dots = new string('.', (3 * size - 3) / 2);
        string middle = "";
        string rowToPrint = "";

        for (int row = 0; row < 3; row++)
        {
            if (row == 0)
            {
                middle = ".x.";
            }
            if (row == 1)
            {
                middle = "/x\\";
            }
            if (row == 2)
            {
                middle = "x|x";
            }
            rowToPrint = $"{dots}{middle}{dots}";
            Console.WriteLine(rowToPrint);
        }

        Stars(size);

        for (int row = 0; row < 2; row++)
        {
            if (row == 0)
            {
                middle = "/x\\";
            }
            if (row == 1)
            {
                middle = "\\x/";
            }

            rowToPrint = $"{dots}{middle}{dots}";
            Console.WriteLine(rowToPrint);
        }

        Stars(size);

        for (int row = 0; row < 3; row++)
        {
            if (row == 0)
            {
                middle = "x|x";
            }
            if (row == 1)
            {
                middle = "\\x/";
            }
            if (row == 2)
            {
                middle = ".x.";
            }
            rowToPrint = $"{dots}{middle}{dots}";
            Console.WriteLine(rowToPrint);
        }

    }

    static void Stars(int size)
    {
        int dots = size / 2;
        int stars = size;
        string rowToPrint = "";

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string('.', dots)}{new string('x', stars)}|{new string('x', stars)}{new string('.', dots)}";
            Console.WriteLine(rowToPrint);

            if (row < size / 2)
            {
                stars++;
                dots--;
            }
            else
            {
                stars--;
                dots++;
            }
        }
    }
}