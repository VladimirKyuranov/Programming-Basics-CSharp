using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime && number >= 2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}