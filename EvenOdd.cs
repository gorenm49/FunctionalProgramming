using System;

namespace FunctionalProgramming
{
    public class EvenOdd
    {
        public void evenOddFun()
        {

            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}