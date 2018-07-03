using System;

class NumbersOneToNWithStep3
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int number = 1; number <= count; number += 3)
        {
            Console.WriteLine(number);
        }
    }
}