using System;

class BarcodeGenerator
{
    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i++)
        {
            if (i.ToString().Contains("0") || i.ToString().Contains("2") || i.ToString().Contains("4") || i.ToString().Contains("6") || i.ToString().Contains("8"))
            {
            }
            else if (i.ToString()[1] < min.ToString()[1] || i.ToString()[2] < min.ToString()[2] || i.ToString()[3] < min.ToString()[3])
            {
            }
            else if (i.ToString()[1] > max.ToString()[1] || i.ToString()[2] > max.ToString()[2] || i.ToString()[3] > max.ToString()[3])
            {
            }
            else
            {
                Console.Write($"{i} ");
            }
        }
    }
}