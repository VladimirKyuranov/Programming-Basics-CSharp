using System;

class SumOfTwoNumbers
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());

        int count = 0;
        int number = 0;

        for (int num1 = start; num1 <= end; num1++)
        {
            for (int num2 = start; num2 <= end; num2++)
            {
                count++;

                if (num1 + num2 == magic)
                {
                    number = count;
                    Console.WriteLine($"Combination N:{number} ({num1} + {num2} = {magic})");
                    num2 = end + 1;
                    num1 = end + 1;
                }
            }
        }

        if (number == 0)
        {
            Console.WriteLine($"{count} combinations - neither equals {magic}");
        }
    }
}