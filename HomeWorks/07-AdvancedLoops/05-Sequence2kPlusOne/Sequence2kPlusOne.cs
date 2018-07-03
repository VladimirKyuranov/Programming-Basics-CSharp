using System;

class Sequence2kPlusOne
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int number = 1; number <= count; number = 2 * number + 1)
        {
            Console.WriteLine(number);
        }
    }
}