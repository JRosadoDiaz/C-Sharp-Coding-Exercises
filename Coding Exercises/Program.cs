using System;

namespace Coding_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Smart World";

            Console.WriteLine(message);
            ReverseString.DoWork(message);
            PigLatin.DoWork(message);
            CountVowels.DoWork(message);
            Palindrome.DoWork(message);
            CountWords.DoWork(message);
        }
    }
}
