using System;

namespace FunctionalProgramming
{
    public class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine( "2"+"^"+i+"="+ Math.Pow(2,i));
            }
        }
    }
}