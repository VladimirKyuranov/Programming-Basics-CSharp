using System;

class MobileOperator
{
    static void Main(string[] args)
    {
        string period = Console.ReadLine();
        string type = Console.ReadLine();
        string internet = Console.ReadLine();
        int months = int.Parse(Console.ReadLine());

        double tax = 0;
        string combo = $"{type} {internet}";

        if (period == "one")
        {
            switch (combo)
            {
                case "Small yes":
                    tax = 9.98 + 5.50;
                    break;
                case "Middle yes":
                    tax = 18.99 + 4.35;
                    break;
                case "Large yes":
                    tax = 25.98 + 4.35;
                    break;
                case "ExtraLarge yes":
                    tax = 35.99 + 3.85;
                    break;
                case "Small no":
                    tax = 9.98;
                    break;
                case "Middle no":
                    tax = 18.99;
                    break;
                case "Large no":
                    tax = 25.98;
                    break;
                case "ExtraLarge no":
                    tax = 35.99;
                    break;
            }
        }
        else
        {
            switch (combo)
            {
                case "Small yes":
                    tax = 8.58 + 5.50;
                    break;
                case "Middle yes":
                    tax = 17.09 + 4.35;
                    break;
                case "Large yes":
                    tax = 23.59 + 4.35;
                    break;
                case "ExtraLarge yes":
                    tax = 31.79 + 3.85;
                    break;
                case "Small no":
                    tax = 8.58;
                    break;
                case "Middle no":
                    tax = 17.09;
                    break;
                case "Large no":
                    tax = 23.59;
                    break;
                case "ExtraLarge no":
                    tax = 31.79;
                    break;
                default:
                    break;
            }

            tax *= 0.9625;
        }

        Console.WriteLine($"{(tax * months):F2} lv.");
    }
}