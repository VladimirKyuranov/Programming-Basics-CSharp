using System;

class GameOfIntervals
{
    static void Main(string[] args)
    {
        int moves = int.Parse(Console.ReadLine());

        int ones = 0;
        int tens = 0;
        int twenties = 0;
        int thirties = 0;
        int fourties = 0;
        int invalid = 0;
        double sum = 0;


        for (int move = 0; move < moves; move++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 50)
            {
                invalid++;
                sum /= 2;
            }
            else if (number <= 9)
            {
                ones++;
                sum += number * 0.2;
            }
            else if (number <= 19)
            {
                tens++;
                sum += number * 0.3;
            }
            else if (number <= 29)
            {
                twenties++;
                sum += number * 0.4;
            }
            else if (number <= 39)
            {
                thirties++;
                sum += 50;
            }
            else
            {
                fourties++;
                sum += 100;
            }
        }

        Console.WriteLine($"{sum:F2}");
        Console.WriteLine($"From 0 to 9: {(double)ones / moves * 100:F2}%");
        Console.WriteLine($"From 10 to 19: {(double)tens / moves * 100:F2}%");
        Console.WriteLine($"From 20 to 29: {(double)twenties / moves * 100:F2}%");
        Console.WriteLine($"From 30 to 39: {(double)thirties / moves * 100:F2}%");
        Console.WriteLine($"From 40 to 50: {(double)fourties / moves * 100:F2}%");
        Console.WriteLine($"Invalid numbers: {(double)invalid / moves * 100:F2}%");
    }
}