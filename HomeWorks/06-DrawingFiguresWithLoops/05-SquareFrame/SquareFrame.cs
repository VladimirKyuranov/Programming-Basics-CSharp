using System;

class SquareFrame
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        char border = '|';

        for (int row = 1; row <= size; row++)
        {
            if (row == 1 || row == size)
            {
                border = '+';
            }
            else
            {
                border = '|';
            }

            Console.Write($"{border} ");

            for (int col = 0; col < size - 2; col++)
            {
                Console.Write("- ");
            }

            Console.WriteLine(border);
        }
    }
}