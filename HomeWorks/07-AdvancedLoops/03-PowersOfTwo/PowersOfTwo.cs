using System;

class PowersOfTwo
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int power = 0; power <= count; power++)
        {
            Console.WriteLine(Math.Pow(2, power));
        }
    }
}