using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Exercises
{
    class CountWords
    {
        static public void DoWork(string message)
        {
            string[] words = message.Split(" ");
            Console.WriteLine("Word count: " + words.Length);
        }
    }
}
