using System;

class NumbersEndingInSeven
{
    static void Main(string[] args)
    {
        for (int number = 7; number <= 997; number += 10)
        {
            Console.WriteLine(number);
        }
    }
}