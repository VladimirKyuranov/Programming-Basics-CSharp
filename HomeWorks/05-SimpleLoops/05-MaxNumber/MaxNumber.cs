using System;

class MaxNumber
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int max = int.MinValue;

        for (int num = 0; num < count; num++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine(max);
    }
}