using System;

class Sunglasses
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        string glass;
        string middle;

        for (int rouNumber = 1; rouNumber <= size; rouNumber++)
        {
            if (rouNumber == 1 || rouNumber == size)
            {
                glass = new string('*', 2 * size);
                middle = new string(' ', size);
            }
            else if (rouNumber == (size + 1) / 2)
            {
                glass = $"*{new string('/', 2 * size - 2)}*";
                middle = new string('|', size);
            }
            else
            {
                glass = $"*{new string('/', 2 * size - 2)}*";
                middle = new string(' ', size);
            }

            string row = $"{glass}{middle}{glass}";

            Console.WriteLine(row);
        }
    }
}