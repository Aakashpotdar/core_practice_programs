using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class quotientRemainder
    {
        public void calculation()
        {
            Console.WriteLine("enter the no. for division");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second no.");
            int num2 = int.Parse(Console.ReadLine());

            int quotient = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("the quotient is:"+quotient);
            Console.WriteLine("the remainder is:"+remainder);
        }
    }
}
