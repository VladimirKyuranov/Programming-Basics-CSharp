using System;

class EvenPowersOfTwo
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int power = 0; power <= count; power++)
        {
            if (power % 2 == 0)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}