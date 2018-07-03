using System;

class SquareOfStars
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}