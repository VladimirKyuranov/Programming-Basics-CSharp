using System;

class DeerOfSanta
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int food = int.Parse(Console.ReadLine());
        double deerOne = double.Parse(Console.ReadLine());
        double deerTwo = double.Parse(Console.ReadLine());
        double deerThree = double.Parse(Console.ReadLine());

        double foodNeeded = days * (deerOne + deerTwo + deerThree);

        if (food >= foodNeeded)
        {
            Console.WriteLine($"{Math.Floor(food - foodNeeded)} kilos of food left.");
        }
        else
        {
            Console.WriteLine($"{Math.Ceiling(foodNeeded - food)} more kilos of food are needed.");
        }
    }
}