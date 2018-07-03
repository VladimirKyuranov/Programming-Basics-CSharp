using System;

class Java
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int ets = 2 * size + 4;
        string steam = "~ ~ ~";
        string java = "";
        string borders = new string('=', 3 * size + 5);
        string rowToPrint = "";

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string(' ', size)}{steam}";
            Console.WriteLine(rowToPrint);
        }

        Console.WriteLine(borders);

        for (int row = 1; row <= size - 2; row++)
        {
            if (row == size / 2)
            {
                java = "JAVA";

            }
            else
            {
                java = "~~~~";
            }

            rowToPrint = $"|{new string('~', size)}{java}{new string('~', size)}|{new string(' ', size - 1)}|";
            Console.WriteLine(rowToPrint);
        }

        Console.WriteLine(borders);

        for (int row = 0; row < size; row++)
        {
            rowToPrint = $"{new string(' ', row)}\\{new string('@', ets)}/";
            Console.WriteLine(rowToPrint);
            ets -= 2;
        }

        rowToPrint = new string('=', 2 * size + 6);
        Console.WriteLine(rowToPrint);
    }
}