using System;

class CarToGo
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string classType = "Luxury class";
        string car = "Jeep";
        double price = budget * 0.9;

        if (budget <= 100)
        {
            classType = "Economy class";

            if (season == "summer")
            {
                car = "Cabrio";
                price = budget * 0.35;
            }
            else
            {
                price = budget * 0.65;
            }
        }
        else if (budget <= 500)
        {
            classType = "Compact class";

            if (season == "summer")
            {
                car = "Cabrio";
                price = budget * 0.45;
            }
            else
            {
                price = budget * 0.8;
            }
        }

        Console.WriteLine($"{classType}");
        Console.WriteLine($"{car} - {price:F2}");
    }
}