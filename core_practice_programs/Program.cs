using System;

namespace core_practice_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice :      1.coin flip program  2.leap year program");
            Console.WriteLine("3.power of '2'      4.Hermonic number    5.Prime factors of number 6.Quotient and remainder");
            Console.WriteLine("7.swap two numbers  8.swap two numbers   9.                        10.");

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
                    primeFactors obj5 = new primeFactors();
                    obj5.findFactors();
                    break;
                case 6:
                    quotientRemainder obj6 = new quotientRemainder();
                    obj6.calculation();
                    break;
                case 7:
                    swap2Numbers obj7 = new swap2Numbers();
                    obj7.opration();
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
