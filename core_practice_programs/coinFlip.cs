using System;
using System.Collections.Generic;
using System.Text;

namespace core_practice_programs
{
    class coinFlip
    {
        public void flipCoin()
        {
            Console.WriteLine("enter the no. of time want to flip the coin");
            int coinNumber= int.Parse(Console.ReadLine()),coin,head=0,tail=0;
            Random ran = new Random();
            for(int i = 1; i < coinNumber; i++)
            {
                coin = ran.Next(0, 2);
                if (coin == 1)
                {
                    tail++;    
                }
                else
                {
                    head++;
                }
            }
            int avrageHead = (head * 100) / coinNumber;
            int avrageTail = (tail * 100) / coinNumber;
            Console.WriteLine("avrage no. of time head apper is:"+avrageHead+"%");
            Console.WriteLine("avrage no. of time tail apper is:" + avrageTail + "%");
        }
    }
}
