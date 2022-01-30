using System;

namespace FunctionalProgramming
{
    public class LargestNumber
    {
        public void largeNum()
        {

            Console.WriteLine("Enter 3 Numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number 1 is largest among 3 numbers");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Number 2 is largest among 3 numbers");
            }
            else
            {
                Console.WriteLine("Number 3 is largest among 3 numbers");
            }
        }
        
    }
}