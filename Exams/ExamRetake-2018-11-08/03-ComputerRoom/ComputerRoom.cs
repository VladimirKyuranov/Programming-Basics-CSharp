﻿using System;

class ComputerRoom
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int groupSize = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();
        double price = 0;

        switch (month)
        {
            case "march":
            case "april":
            case "may":
                if (dayTime == "day")
                {
                    price = 10.5;
                }
                else
                {
                    price = 8.4;
                }
                break;
            case "june":
            case "july":
            case "august":
                if (dayTime == "day")
                {
                    price = 12.6;
                }
                else
                {
                    price = 10.2;
                }
                break;
            default:
                break;
        }

        if (groupSize >= 4)
        {
            price *= 0.9;
        }

        if (hours >= 5)
        {
            price *= 0.5;
        }

        Console.WriteLine($"Price per person for one hour: {price:F2}");
        Console.WriteLine($"Total cost of the visit: {price * groupSize * hours:F2}");
    }
}