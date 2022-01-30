using System;

namespace FunctionalProgramming
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("1"+"/"+i+"+");
            }
        }
    }
    
}