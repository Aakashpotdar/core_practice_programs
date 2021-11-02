using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class swap2Numbers
    {
        public void opration()
        {
            Console.WriteLine("enter the no. for division");
            int[] nums = new int[] { 2, 3, 4, 6, 8 };
            Console.WriteLine("befor swaping the number");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(" "+nums[i]);
            }
            int temp = nums[2];
            nums[2] = nums[3];
            nums[3] = temp;
            Console.WriteLine("");
            Console.WriteLine("after swaping the number");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i]);
            }
        }
    }
}
