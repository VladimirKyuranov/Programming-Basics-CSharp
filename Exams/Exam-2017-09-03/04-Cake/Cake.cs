using System;

class Cake
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int lenght = int.Parse(Console.ReadLine());

        int pieces = width * lenght;

        for (int command = 1; command > 0; command++)
        {
            string taken = Console.ReadLine();

            if (taken != "STOP")
            {
                if (pieces >= int.Parse(taken))
                {
                    pieces -= int.Parse(taken);
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {int.Parse(taken) - pieces} pieces more.");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
                break;
            }
        }
    }
}