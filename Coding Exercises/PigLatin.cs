using System;
using System.Linq;

namespace Coding_Exercises
{
    class PigLatin
    {
        static public void DoWork(string message)
        {
            string[] words = message.ToLower().Split(" ");
            string resultMessage = "";
            foreach (string word in words)
            {
                string consonantTemp = "";
                foreach(char c in word)
                {
                    if(IsConsonant(c))
                    {
                        consonantTemp += c;
                    }
                    else
                    {
                        break;
                    }
                }

                string tempWord = word.Substring(consonantTemp.Length) + consonantTemp + "ay ";
                resultMessage += tempWord;
            }

            Console.WriteLine(resultMessage);
        }

        private static bool IsConsonant(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if(!vowels.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
