using System;

class RectangleOf10x10Stars
{
    static void Main(string[] args)
    {
        for (int row = 0; row < 10; row++)
        {
            Console.WriteLine(new string('*', 10));
        }
    }
}