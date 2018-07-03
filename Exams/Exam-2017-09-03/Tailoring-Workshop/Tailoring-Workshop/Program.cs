using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sideA = decimal.Parse(Console.ReadLine());
            var sideB = decimal.Parse(Console.ReadLine());

            var coversArea = count * (sideA + 2 * 0.30m) * (sideB + 2 * 0.30m);
            var squaresArea = count * (sideA / 2) * (sideA / 2);

            var priceUSD = coversArea * 7 + squaresArea * 9;
            var priceBGN = priceUSD * 1.85m;

            Console.WriteLine($"{Decimal.Round(priceUSD, 2, MidpointRounding.AwayFromZero)} USD");
            Console.WriteLine($"{Decimal.Round(priceBGN, 2)} BGN");
        }
    }
}