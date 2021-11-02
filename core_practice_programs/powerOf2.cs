using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class powerOf2
    {
        public void calculation() 
        {
            Console.WriteLine("enter the no. between 1 to 31");
            int Number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= Number; i++)
            {
                Console.WriteLine("2^"+i+"="+Math.Pow(2,i));
            }

        }
    }
}
