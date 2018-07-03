using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var grades = double.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());

            var social = 0.00;
            var excellent = 0.00;
            if (grades >= 4.5)
            {
                if (income < salary)
                {
                    social = salary * 0.35;
                }
                if (grades >= 5.5)
                {
                    excellent = grades * 25;
                }
            }
            if (excellent > social)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent)} BGN");
            }
            else if (social > excellent)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
