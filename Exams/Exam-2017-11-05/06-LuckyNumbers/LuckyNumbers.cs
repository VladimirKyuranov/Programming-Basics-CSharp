using System;

class LuckyNumbers
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int currentNumber = 1111; currentNumber <= 9999; currentNumber++)
        {
            int firstDigit = int.Parse(currentNumber.ToString()[0].ToString());
            int secondDigit = int.Parse(currentNumber.ToString()[1].ToString());
            int thirdDigit = int.Parse(currentNumber.ToString()[2].ToString());
            int fourthDigit = int.Parse(currentNumber.ToString()[3].ToString());

            if (!currentNumber.ToString().Contains("0") && firstDigit + secondDigit == thirdDigit + fourthDigit && number % (firstDigit + secondDigit) == 0)
            {
                Console.Write($"{currentNumber} ");
            }
        }
    }
}