using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class hermonicNumber
    {
        public void hermonic()
        {
            Console.WriteLine("enter the number");
            double num = int.Parse(Console.ReadLine());
            double hermonicNum = 0;

            for (double i = 1; i <= num; i++)
            {
                hermonicNum += (1/i);
                Console.WriteLine("1/"+i+"="+(1/i));
            }
            Console.WriteLine(" The "+num+" hermonic number is="+hermonicNum);
        }
    }
}
