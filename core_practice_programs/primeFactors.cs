using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class primeFactors
    {
        public void findFactors()
        {
            Console.WriteLine("enter the no.");
            int Number = int.Parse(Console.ReadLine()),temp=0,count=0;

            Console.WriteLine("the prime factorial numbers are:");

            for (int i = 1; i <= Number; i++)
            {
                count = 0;
                temp = 0;
                if ((Number % i) == 0)
                {
                    temp = i;
                }

                for (int j = 1; j <= temp; j++)
                {
                    if ((temp % j) == 0)
                    { count++; }        
                }   
                if(count==2)
                {
                    Console.Write(" "+temp);

                }
            }

        }
    }
}
