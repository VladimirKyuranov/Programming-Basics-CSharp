using System;

class GroupName
{
    static void Main(string[] args)
    {
        char capitalLetter = char.Parse(Console.ReadLine());
        char smallLetter1 = char.Parse(Console.ReadLine());
        char smallLetter2 = char.Parse(Console.ReadLine());
        char smallLetter3 = char.Parse(Console.ReadLine());
        int digit = int.Parse(Console.ReadLine());

        int output = (capitalLetter - 64) * (smallLetter1 - 96) * (smallLetter2 - 96) * (smallLetter3 - 96) * (digit + 1) - 1;

        Console.WriteLine(output);
    }
}