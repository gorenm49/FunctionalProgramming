using System;

namespace FunctionalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 1.FlipCoinProgram \n 2.LeapYear \n 3.Power Of two \n 4.Harmonic Function \n 5.Factor \n 6.Swap \n 7.EvenOdd \n 8. Quotient and Remainder \n 9. Alphabet \n 10.Largest Number \n 11.Exit \n");
            bool flag = true;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        FlipCoinProgram fc = new FlipCoinProgram();
                        fc.flipCoin();
                        break;
                    case 2:
                        LeapYear ly = new LeapYear();
                        ly.CheckYear();
                        break;
                    case 3:
                        PowerOfTwo pot = new PowerOfTwo();
                        pot.Power();
                        break;
                    case 4:
                        HarmonicNumber hn = new HarmonicNumber();
                        hn.Harmonic();
                        break;
                    case 5:
                        Factor f1 = new Factor();
                        f1.factorPrime();
                        break;
                    case 6:
                        Swap sp = new Swap();
                        sp.swapNumber();
                        break;
                    case 7:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.evenOddFun();
                        break;
                    case 8:
                        Divide div = new Divide();
                        div.operation();
                        break;    
                    case 9:
                        Alphabet a1 = new Alphabet();
                        a1.check();
                        break;
                    case 10:
                        LargestNumber ln = new LargestNumber();
                        ln.largeNum();
                        break;
                    case 11:
                        break;
                    default:
                        Console.WriteLine("Enter correct option...");
                        break;
                }
                
            }

        }
        
    }
    
}