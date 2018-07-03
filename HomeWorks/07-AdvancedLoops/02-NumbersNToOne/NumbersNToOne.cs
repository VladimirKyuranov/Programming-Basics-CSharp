using System;

class NumbersNToOne
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int number = count; number >= 1; number--)
        {
            Console.WriteLine(number);
        }
    }
}