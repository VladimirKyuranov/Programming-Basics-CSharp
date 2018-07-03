using System;

class LeftAndRightSum
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int num = 1; num <= 2 * count; num++)
        {
            int number = int.Parse(Console.ReadLine());

            if (num <= count)
            {
                leftSum += number;
            }
            else
            {
                rightSum += number;
            }
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}