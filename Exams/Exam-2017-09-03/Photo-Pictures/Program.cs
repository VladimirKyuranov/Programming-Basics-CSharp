using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictures = int.Parse(Console.ReadLine());
            var size = Console.ReadLine();
            var orderType = Console.ReadLine();

            double price = 0.16;

            switch (size)
            {
                case "9X13":
                    if (pictures >= 50)
                    {
                        price *= 0.95;
                    }
                    break;
                case "10X15":
                    if (pictures >= 80)
                    {
                        price *= 0.97;
                    }
                    break;
                case "13X18":
                    price = 0.38;
                    if (pictures > 100)
                    {
                        price *= 0.95;
                    }
                    else if (pictures >= 50)
                    {
                        price *= 0.97;
                    }
                    break;
                case "20X30":
                    price = 2.90;
                    if (pictures > 50)
                    {
                        price *= 0.91;
                    }
                    else if (pictures >= 10)
                    {
                        price *= 0.93;
                    }
                    break;
                default:
                    break;
            }

            if (orderType == "online")
            {
                price *= 0.98;
            }

            Console.WriteLine($"{(price * pictures):F2}BGN");
        }
    }
}
