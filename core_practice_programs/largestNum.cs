using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class largestNum
    {
        public void compair()
        {
            Console.WriteLine("enter the 1st no.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2st no.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3st no.");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("the largest number is 1st one " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("the largest number is 2nd one " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("the largest number is 3rd one " + num3);
            }
        }
    }
}
