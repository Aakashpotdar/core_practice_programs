using System;

namespace core_practice_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice : 1.coin flip program 2.leap year program");
            Console.WriteLine("3.power of '2' 4.Hermonic number 5.6");
            Console.WriteLine("7.8.9.10");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    coinFlip obj1 = new coinFlip();
                    obj1.flipCoin();
                    break;
                case 2:
                    leapYear obj2 = new leapYear();
                    obj2.checkYear();
                    break;
                case 3:
                    powerOf2 obj3 = new powerOf2();
                    obj3.calculation();
                    break;
                case 4:
                    hermonicNumber obj4 = new hermonicNumber();
                    obj4.hermonic();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }
        }
    }
}
