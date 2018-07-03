using System;

class DwarfPresents
{
    static void Main(string[] args)
    {
        int dwarfs = int.Parse(Console.ReadLine());
        int money = int.Parse(Console.ReadLine());

        double moneyNeeded = 0;

        for (int dwarf = 0; dwarf < dwarfs; dwarf++)
        {
            string present = Console.ReadLine();

            switch (present)
            {
                case "sand clock":
                    moneyNeeded += 2.20;
                    break;
                case "magnet":
                    moneyNeeded += 1.50;
                    break;
                case "cup":
                    moneyNeeded += 5.00;
                    break;
                case "t-shirt":
                    moneyNeeded += 10.00;
                    break;
            }
        }

        if (money >= moneyNeeded)
        {
            Console.WriteLine($"Santa Claus has {money - moneyNeeded:F2} more leva left!");
        }
        else
        {
            Console.WriteLine($"Santa Claus will need {moneyNeeded - money:F2} more leva.");
        }
    }
}