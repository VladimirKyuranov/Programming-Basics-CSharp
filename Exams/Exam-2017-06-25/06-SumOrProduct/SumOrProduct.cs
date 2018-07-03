using System;

class SumOrProduct
{
    static void Main(string[] args)
    {
        var controlNumber = int.Parse(Console.ReadLine());

        bool hasOne = false;

        for (int num1 = 1; num1 <= 30; num1++)
        {
            for (int num2 = 1; num2 <= 30; num2++)
            {
                for (int num3 = 1; num3 <= 30; num3++)
                {
                    if (num1 < num2 && num2 < num3 && num1 + num2 + num3 == controlNumber)
                    {
                        Console.WriteLine($"{num1} + {num2} + {num3} = {controlNumber}");
                        hasOne = true;
                    }
                    if (num1 > num2 && num2 > num3 && num1 * num2 * num3 == controlNumber)
                    {
                        Console.WriteLine($"{num1} * {num2} * {num3} = {controlNumber}");
                        hasOne = true;
                    }
                }
            }
        }

        if (!hasOne)
        {
            Console.WriteLine("No!");
        }
    }
}