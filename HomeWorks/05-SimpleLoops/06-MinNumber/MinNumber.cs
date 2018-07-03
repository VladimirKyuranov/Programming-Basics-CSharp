using System;

class MinNumber
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int min = int.MaxValue;

        for (int num = 0; num < count; num++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine(min);
    }
}