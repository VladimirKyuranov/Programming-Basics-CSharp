using System;

class LatinLetters
{
    static void Main(string[] args)
    {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter == 'z')
            {
                Console.WriteLine("z.");
            }
            else
            {
                Console.Write($"{letter}, ");
            }
        }
    }
}