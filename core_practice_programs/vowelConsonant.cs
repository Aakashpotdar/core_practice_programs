using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class vowelConsonant
    {
        public void logicPart()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("the char");
            char key = char.Parse(Console.ReadLine());
            int scan = 0;

            for(int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == key)
                {
                    scan++;
                }
            }
            if (scan > 0) { Console.WriteLine("the enterd char is vowel"); }
            else { Console.WriteLine("the enterd char is consonel"); }
        }
    }
}
