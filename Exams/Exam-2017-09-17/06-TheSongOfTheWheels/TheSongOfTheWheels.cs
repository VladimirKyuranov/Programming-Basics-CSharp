using System;

class TheSongOfTheWheels
{
    static void Main(string[] args)
    {
        var controlNumber = int.Parse(Console.ReadLine());

        int fourth = 0;
        string password = "";
        string output = "No!";

        for (int digit1 = 1; digit1 <= 9; digit1++)
        {
            for (int digit2 = 1; digit2 <= 9; digit2++)
            {
                for (int digit3 = 1; digit3 <= 9; digit3++)
                {
                    for (int digit4 = 1; digit4 <= 9; digit4++)
                    {
                        if (controlNumber == digit1 * digit2 + digit3 * digit4 && digit1 < digit2 && digit3 > digit4)
                        {
                            Console.Write($"{digit1}{digit2}{digit3}{digit4} ");
                            fourth++;

                            if (fourth == 4)
                            {
                                password = $"{digit1}{digit2}{digit3}{digit4}";
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine();

        if (password != "")
        {
            output = $"Password: {password}";
        }

        Console.WriteLine(output);
    }
}