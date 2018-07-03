using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        while (secondNumber != 0)
        {
            int temp = secondNumber;
            secondNumber = firstNumber % secondNumber;
            firstNumber = temp;
        }

        Console.WriteLine(firstNumber);
    }
}