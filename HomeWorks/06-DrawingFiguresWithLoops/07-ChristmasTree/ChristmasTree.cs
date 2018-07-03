using System;

class ChristmasTree
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int spaceCount = size;

        for (int i = 0; i < size + 1; i++)
        {
            string space = new string(' ', spaceCount);
            string star = new string('*', i);

            Console.WriteLine($"{space}{star} | {star}");
            spaceCount--;
        }
    }
}