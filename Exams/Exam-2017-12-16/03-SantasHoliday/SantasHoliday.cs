using System;

class SantasHoliday
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string grade = Console.ReadLine();

        string holidayLenght = "short";
        int nights = days - 1;
        double fullPrice = nights * 18;

        if (days > 10 && days <= 15)
        {
            holidayLenght = "medium";
        }
        else if (days > 15)
        {
            holidayLenght = "long";
        }

        switch (holidayLenght)
        {
            case "short":
                if (roomType == "apartment")
                {
                    fullPrice = nights * 25 * 0.7;
                }
                else if (roomType == "president apartment")
                {
                    fullPrice = nights * 35 * 0.9;
                }

                break;
            case "medium":
                if (roomType == "apartment")
                {
                    fullPrice = nights * 25 * 0.65;
                }
                else if (roomType == "president apartment")
                {
                    fullPrice = nights * 35 * 0.85;
                }

                break;
            case "long":
                if (roomType == "apartment")
                {
                    fullPrice = nights * 25 * 0.5;
                }
                else if (roomType == "president apartment")
                {
                    fullPrice = nights * 35 * 0.8;
                }

                break;
        }

        if (grade == "positive")
        {
            fullPrice += fullPrice * 0.25;
        }
        else
        {
            fullPrice -= fullPrice * 0.1;
        }

        Console.WriteLine($"{fullPrice:F2}");
    }
}