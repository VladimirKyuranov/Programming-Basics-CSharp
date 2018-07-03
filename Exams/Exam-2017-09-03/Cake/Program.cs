using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var lenght = int.Parse(Console.ReadLine());
            var pieces = width * lenght;

            for (int i = 1; i > 0; i++)
            {
                var taken = Console.ReadLine();
                if (taken != "STOP")
                {
                    if (pieces >= int.Parse(taken))
                    {
                        pieces -= int.Parse(taken);
                    }
                    else
                    {
                        Console.WriteLine($"No more cake left! You need {int.Parse(taken) - pieces} pieces more.");
                        i = -1;
                    }
                }
                else
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                    i = -1;
                }
            }
        }
    }
}
