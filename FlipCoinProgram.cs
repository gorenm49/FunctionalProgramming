using System;

namespace FunctionalProgramming
{
    public class FlipCoinProgram
    {
        const double MID = 0.5;
        double head = 0, tail = 0;

        public void flipCoin()
        {

            Random random = new Random();
            Console.WriteLine("Enter number for coin flip count:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++ )
            {           
                double flip = random.NextDouble();
                if (flip < MID)
                {
                    head++;
                }   
                else
                {
                    tail++;
                }
            }
            Console.WriteLine("Percentage of Head: "+(head/num)*100);
            Console.WriteLine("Percentage of Tail: "+(tail/num)*100);
        }
    }
}