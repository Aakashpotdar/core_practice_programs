using System;

namespace core_practice_programs
{
    class Program
    {
        static void Main(string[] args)
        {
  lable1: Console.WriteLine("enter choice :      1.coin flip program          2.leap year program");
            Console.WriteLine("3.power of '2'      4.Hermonic number            5.Prime factors of number 6.Quotient and remainder");
            Console.WriteLine("7.swap two numbers  8.Check the even oddnumber   9.vowel or consonant      10.Find largest number");

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
                    evenOdd obj8 = new evenOdd();
                        obj8.check();
                    break;
                case 9:
                    vowelConsonant obj9 = new vowelConsonant();
                    obj9.logicPart();
                    break;
                case 10:
                    largestNum obj10 = new largestNum();
                    obj10.compair();
                    break;
                default:
                    Console.WriteLine("wrong choice");

                    break;
            }
        
            Console.WriteLine("do you want to continue please select y/n");
            char option = char.Parse(Console.ReadLine());

            if (option == 'y')
            {
                goto lable1;
            }
            else
            {
                Console.WriteLine("Thank you for your time");
            }

        }
    }
}
