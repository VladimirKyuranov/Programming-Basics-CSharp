using System;

class VowelsSum
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine().ToLower();

        int sum = 0;

        for (int letter = 0; letter < word.Length; letter++)
        {
            switch (word[letter])
            {
                case 'a':
                    sum++;
                    break;
                case 'e':
                    sum += 2;
                    break;
                case 'i':
                    sum += 3;
                    break;
                case 'o':
                    sum += 4;
                    break;
                case 'u':
                    sum += 5;
                    break;
            }
        }

        Console.WriteLine(sum);
    }
}