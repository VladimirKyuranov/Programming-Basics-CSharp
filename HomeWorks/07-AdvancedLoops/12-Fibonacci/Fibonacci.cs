using System;

class Fibonacci
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int firstNumber = 1;
        int secondNumber = 1;


        for (int i = 0; i < count - 1; i++)
        {
            int temp = secondNumber;
            secondNumber += firstNumber;
            firstNumber = temp;
        }

        Console.WriteLine(secondNumber);
    }
}