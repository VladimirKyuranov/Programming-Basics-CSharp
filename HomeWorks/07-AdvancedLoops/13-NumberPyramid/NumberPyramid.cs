using System;

class NumberPyramid
{
    static void Main(string[] args)
    {
        int numbersToPrint = int.Parse(Console.ReadLine());

        int printedNumbers = 1;

        for (int row = 1; row <= numbersToPrint; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (numbersToPrint >= printedNumbers)
                {
                    Console.Write($"{printedNumbers} ");
                    printedNumbers++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}