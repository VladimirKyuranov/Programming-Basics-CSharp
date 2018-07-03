using System;

class Lutenitsa
{
    static void Main(string[] args)
    {
        double tomatoes = double.Parse(Console.ReadLine());
        int boxes = int.Parse(Console.ReadLine());
        int jars = int.Parse(Console.ReadLine());

        double lutenitsa = tomatoes / 5.00;
        double jarsNeeded = lutenitsa / 0.535;
        var boxesNeeded = jarsNeeded / jars;

        Console.WriteLine($"Total lutenica: {Math.Floor(lutenitsa)} kilograms.");

        if (boxes <= boxesNeeded)
        {
            Console.WriteLine($"{Math.Floor(boxesNeeded - boxes)} boxes left.");
            Console.WriteLine($"{Math.Floor(jarsNeeded - boxes * jars)} jars left.");
        }
        else
        {
            Console.WriteLine($"{Math.Floor(boxes - boxesNeeded)} more boxes needed.");
            Console.WriteLine($"{Math.Floor(boxes * jars - jarsNeeded)} more jars needed.");
        }
    }
}