using System;

class RectangleOfNxNStars
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(new string('*', size));
        }
    }
}