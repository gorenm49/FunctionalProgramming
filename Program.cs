using System;

namespace FunctionalProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoinProgram /n 2.LeapYear /n 3.Exit /n");
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
                        break;
                    default:
                        Console.WriteLine("Enter correct option...");
                        break;
                }
                
            }

        }
        
    }
    
}