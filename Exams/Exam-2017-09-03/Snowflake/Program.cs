using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = n;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < a; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < a; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                a--;
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    for (int j = 0; j < 2 * n + 3; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= 2 * n - 1; j++)
                    {
                        if (j == n)
                        {
                            Console.Write("*****");
                        }
                        else
                        {
                        Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
            }
            a++;
            for (int i = n - 2; i > -1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < a; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < a; j++)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                a++;
                Console.WriteLine();
            }

        }
    }
}
