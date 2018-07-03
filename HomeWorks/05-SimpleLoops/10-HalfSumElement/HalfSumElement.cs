using System;

class HalfSumElement
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int max = 0;
        int sum = 0;

        for (int num = 0; num < count; num++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        if (max == sum - max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {max}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(sum - 2 * max)}");
        }
    }
}