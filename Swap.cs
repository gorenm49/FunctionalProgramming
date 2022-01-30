using System;

namespace FunctionalProgramming
{
    public class Swap
    {
        public void swapNumber()
        {

            Console.WriteLine("Enter two numbers for Swap:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Provided number are :"+num1+"\t"+num2);

            num1 += num2;
            num2 = num1 - num2;
            num1 -= num2;

            Console.WriteLine("Swap Numbers are: "+num1+"\t"+num2);
        }
    }
}