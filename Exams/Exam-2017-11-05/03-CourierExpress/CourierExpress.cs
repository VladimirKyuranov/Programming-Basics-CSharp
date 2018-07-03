using System;

class CourierExpress
{
    static void Main(string[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        string serviceType = Console.ReadLine();
        int distance = int.Parse(Console.ReadLine());

        double finalPrice = 0;
        double overcharge = 0;

        if (serviceType == "standard")
        {
            finalPrice = distance * 0.03;

            if (weight >= 1 && weight < 11)
            {
                finalPrice = distance * 0.05;
            }
            else if (weight >= 11 && weight < 41)
            {
                finalPrice = distance * 0.10;
            }
            else if (weight >= 41 && weight < 91)
            {
                finalPrice = distance * 0.15;
            }
            else if (weight >= 91)
            {
                finalPrice = distance * 0.20;
            }
        }
        else
        {
            overcharge = distance * (weight * 0.03 * 0.8);
            finalPrice = distance * 0.03 + overcharge;

            if (weight >= 1 && weight < 11)
            {
                overcharge = distance * (weight * 0.05 * 0.4);
                finalPrice = distance * 0.05 + overcharge;
            }
            else if (weight >= 11 && weight < 41)
            {
                overcharge = distance * (weight * 0.10 * 0.05);
                finalPrice = distance * 0.10 + overcharge;
            }
            else if (weight >= 41 && weight < 91)
            {
                overcharge = distance * (weight * 0.15 * 0.02);
                finalPrice = distance * 0.15 + overcharge;
            }
            else if (weight >= 91)
            {
                overcharge = distance * (weight * 0.20 * 0.01);
                finalPrice = distance * 0.20 + overcharge;
            }
        }

        Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {finalPrice:F2} lv.");
    }
}