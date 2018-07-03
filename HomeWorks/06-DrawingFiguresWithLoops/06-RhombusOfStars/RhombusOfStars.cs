using System;

class RhombusOfStars
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int space = size - 1;
        int stars = 1;

        for (int row = 0; row < 2 * size - 1; row++)
        {
            Console.Write(new string(' ', space));

            for (int col = 0; col < stars; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();

            if (row < size - 1)
            {
                space--;
                stars++;
            }
            else
            {
                space++;
                stars--;
            }
        }
    }
}