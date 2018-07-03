using System;

class NumberTable
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int row = 0; row < count; row++)
        {
            for (int col = 1; col <= count; col++)
            {
                if (col + row <= count)
                {
                    Console.Write($"{col + row} ");
                }
                else
                {
                    Console.Write($"{ 2 * count - (col + row)} ");
                }
            }

            Console.WriteLine();
        }
    }
}