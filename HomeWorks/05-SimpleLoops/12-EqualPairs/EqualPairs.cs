using System;

class EqualPairs
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        int sum = first + second;
        int maxDiff = int.MinValue;

        for (int pair = 0; pair < n - 1; pair++)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (sum != a + b)
            {
                int diff = Math.Abs(sum - (a + b));
                if (maxDiff < diff)
                {
                    maxDiff = diff;
                }
                sum = a + b;
            }
        }

        if (maxDiff == int.MinValue)
        {
            Console.WriteLine($"Yes, value={sum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}