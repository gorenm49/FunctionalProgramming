using System;

namespace FunctionalProgramming
{
    public class LeapYear
    {
        public void CheckYear()
        {
            Console.WriteLine("Enter the Year in YYYY format:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                    Console.WriteLine(year+" Is Leap year.");
            }
            else
            {
                    Console.WriteLine(year+" is not Leap year.");
            }
        }
    }
}