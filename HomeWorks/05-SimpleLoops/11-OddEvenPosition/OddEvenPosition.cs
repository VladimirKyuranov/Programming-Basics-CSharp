using System;

class OddEvenPosition
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        double evenSum = 0;
        double oddSum = 0;
        double evenMax = double.MinValue;
        double oddMax = double.MinValue;
        double evenMin = double.MaxValue;
        double oddMin = double.MaxValue;

        for (int num = 1; num <= count; num++)
        {
            double number = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                evenSum += number;
                if (number > evenMax)
                {
                    evenMax = number;
                }
                if (number < evenMin)
                {
                    evenMin = number;
                }
            }
            else
            {
                oddSum += number;
                if (number > oddMax)
                {
                    oddMax = number;
                }
                if (number < oddMin)
                {
                    oddMin = number;
                }
            }
        }

        Console.WriteLine($"Oddsum={oddSum},");
        if (oddMin != double.MaxValue)
        {
            Console.WriteLine($"OddMin={oddMin},");
            Console.WriteLine($"OddMax={oddMax},");
        }
        else
        {
            Console.WriteLine($"OddMin=No,");
            Console.WriteLine($"OddMax=No,");
        }

        Console.WriteLine($"evensum={evenSum},");

        if (evenMin != double.MaxValue)
        {
            Console.WriteLine($"evenMin={evenMin},");
            Console.WriteLine($"evenMax={evenMax}");
        }
        else
        {
            Console.WriteLine($"evenMin=No,");
            Console.WriteLine($"evenMax=No");
        }
    }
}