using System;

class ThreeBrothers
{
    static void Main(string[] args)
    {
        double firstBrother = double.Parse(Console.ReadLine());
        double secondBrother = double.Parse(Console.ReadLine());
        double thirthBrother = double.Parse(Console.ReadLine());
        double fishingTime = double.Parse(Console.ReadLine());

        double cleaningTime = (1 / (1 / firstBrother + 1 / secondBrother + 1 / thirthBrother)) * 1.15;

        Console.WriteLine($"Cleaning time: {cleaningTime:F2}");

        if (fishingTime > cleaningTime)
        {
            Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(fishingTime - cleaningTime)} hours.");
        }
        else
        {
            Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(cleaningTime - fishingTime)} hours.");
        }
    }
}