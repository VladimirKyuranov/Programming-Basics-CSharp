using System;

class ChristmasPreparation
{
    static void Main(string[] args)
    {
        int paper = int.Parse(Console.ReadLine());
        int fabric = int.Parse(Console.ReadLine());
        double glue = double.Parse(Console.ReadLine());
        int percent = int.Parse(Console.ReadLine());

        double fullPrice = paper * 5.80 + fabric * 7.20 + glue * 1.20;
        double finalPrice = fullPrice -= fullPrice * percent / 100;

        Console.WriteLine($"{finalPrice:F3}");
    }
}