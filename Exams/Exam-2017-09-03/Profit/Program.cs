using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = int.Parse(Console.ReadLine());
            var two = int.Parse(Console.ReadLine());
            var five = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= one; i++)
            {
                for (int j = 0; j <= 2 * two; j+=2)
                {
                    for (int k = 0; k <= 5 * five; k+=5)
                    {
                        if (i + j + k == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j / 2} * 2 lv. + {k / 5} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
