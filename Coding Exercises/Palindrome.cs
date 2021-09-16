using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Exercises
{
    class Palindrome
    {
        static public void DoWork(string message)
        {
            string temp = message.ToLower();
            string reverseMessage = "";

            for(int i = temp.Length - 1; i >= 0; i--)
            {
                reverseMessage += temp[i];
            }

            Console.WriteLine("Palindrome: " + String.Equals(temp, reverseMessage));
        }
    }
}
