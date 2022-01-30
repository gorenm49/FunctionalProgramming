using System;

namespace FunctionalProgramming
{
    public class Divide
    {
        public void operation()
        {
            Console.WriteLine("Enter dividend and divisor Respectively: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient = "+quotient+"\n Remainder = "+remainder);
        }
        
    }
    
}