using System;

namespace FunctionalProgramming
{
    public class Factor
    {
        public void factorPrime()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Prime Factor :"+i);
                }
                
            }

        }
        
    }
}