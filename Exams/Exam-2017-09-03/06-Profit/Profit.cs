using System;

class Profit
{
    static void Main(string[] args)
    {
        int ones = int.Parse(Console.ReadLine());
        int twos = int.Parse(Console.ReadLine());
        int fives = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int one = 0; one <= ones; one++)
        {
            for (int two = 0; two <= 2 * twos; two += 2)
            {
                for (int five = 0; five <= 5 * fives; five += 5)
                {
                    if (one + two + five == sum)
                    {
                        Console.WriteLine($"{one} * 1 lv. + {two / 2} * 2 lv. + {five / 5} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}