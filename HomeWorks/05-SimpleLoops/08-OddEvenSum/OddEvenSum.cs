using System;

class OddEvenSum
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int oddSum = 0;
        int evenSum = 0;

        for (int num = 1; num <= count; num++)
        {
            int number = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}