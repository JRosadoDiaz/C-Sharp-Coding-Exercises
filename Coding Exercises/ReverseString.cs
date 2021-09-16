using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    class ReverseString
    {
        public static void DoWork(string message)
        {
            string temp = "";

            for(int i = message.Length - 1; i >= 0; i--)
            {
                temp += message[i];
            }

            Console.WriteLine(temp);
        }
    }
}
