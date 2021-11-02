using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class leapYear
    {
        public void checkYear()
        {
            Console.WriteLine("enter the year");
            string yearToCheck = Console.ReadLine();
            if (yearToCheck.Length == 4)
            {
                int year = int.Parse(yearToCheck);
                int result1 = year % 4;
                int result2 = year % 100;
                int result3 = year % 400;
                if ((result3 == 0) || ((result2 != 0) && (result1 == 0)))
                {
                    Console.WriteLine("the year is leap year");
                }
                else
                {
                    Console.WriteLine("the year is not leap year");
                }
            }
            else
            {
                Console.WriteLine("enter the valid input year");
             }
        }
    }
}
