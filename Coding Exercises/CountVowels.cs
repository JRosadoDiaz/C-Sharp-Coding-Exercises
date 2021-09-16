using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Coding_Exercises
{
    class CountVowels
    {
        static public void DoWork(string message)
        {
            int[] vowels = { 0, 0, 0, 0, 0 }; // a, e, i, o, u
            int count = 0;
            foreach (char c in message)
            {
                switch(c)
                {
                    case 'a':
                        vowels[0]++;
                        break;
                    case 'e':
                        vowels[1]++;
                        break;
                    case 'i':
                        vowels[2]++;
                        break;
                    case 'o':
                        vowels[3]++;
                        break;
                    case 'u':
                        vowels[4]++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Vowel count: {vowels.Sum()}\n" +
                $"a: {vowels[0]}\n" +
                $"e: {vowels[1]}\n" +
                $"i: {vowels[2]}\n" +
                $"o: {vowels[3]}\n" +
                $"u: {vowels[4]}");
        }
    }
}
