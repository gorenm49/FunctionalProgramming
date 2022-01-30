using System;

namespace FunctionalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoinProgram \n 2.LeapYear \n 3.Power Of two \n 4.Harmonic Function \n 5.Exit \n");
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
                        break;
                    default:
                        Console.WriteLine("Enter correct option...");
                        break;
                }
                
            }

        }
        
    }
    
}