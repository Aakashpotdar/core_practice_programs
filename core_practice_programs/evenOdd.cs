using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class evenOdd
    {
        public void check()
        {
            Console.WriteLine("enter the no.");
            int num = int.Parse(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
    }
}
