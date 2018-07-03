using System;

class WireNet
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        double wire = (lenght + width) * 2;

        Console.WriteLine(wire);
        Console.WriteLine($"{wire * price:F2}");
        Console.WriteLine($"{wire * height * weight:F3}");
    }
}