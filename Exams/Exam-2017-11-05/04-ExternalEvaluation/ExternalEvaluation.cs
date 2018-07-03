using System;

class ExternalEvaluation
{
    static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());

        int badMarks = 0;
        int satisfactoryMarks = 0;
        int goodMarks = 0;
        int veryGoodMarks = 0;
        int excellentMarks = 0;

        for (int i = 0; i < students; i++)
        {
            double score = double.Parse(Console.ReadLine());

            if (score <= 22.5)
            {
                badMarks++;
            }
            else if (score <= 40.5)
            {
                satisfactoryMarks++;
            }
            else if (score <= 58.5)
            {
                goodMarks++;
            }
            else if (score <= 76.5)
            {
                veryGoodMarks++;
            }
            else
            {
                excellentMarks++;
            }
        }

        Console.WriteLine($"{badMarks * 100.00 / students:F2}% poor marks");
        Console.WriteLine($"{satisfactoryMarks * 100.00 / students:F2}% satisfactory marks");
        Console.WriteLine($"{goodMarks * 100.00 / students:F2}% good marks");
        Console.WriteLine($"{veryGoodMarks * 100.00 / students:F2}% very good marks");
        Console.WriteLine($"{excellentMarks * 100.00 / students:F2}% excellent marks");
    }
}