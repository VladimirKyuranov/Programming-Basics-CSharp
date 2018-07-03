using System;

class SumNumbers
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int num = 0; num < count; num++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}