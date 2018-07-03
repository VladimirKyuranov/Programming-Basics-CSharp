using System;

class GrandpaStavri
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        double liters = 0;
        double degreesSum = 0;

        for (int day = 0; day < days; day++)
        {
            double rakia = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            liters += rakia;
            degreesSum += rakia * degrees;
        }

        double strong = degreesSum / liters;

        Console.WriteLine($"Liter: {liters:F2}");
        Console.WriteLine($"Degrees: {(strong):F2}");

        if (strong < 38)
        {
            Console.WriteLine("Not good, you should baking!");
        }
        else if (strong < 42)
        {
            Console.WriteLine("Super!");
        }
        else
        {
            Console.WriteLine("Dilution with distilled water!");
        }
    }
}