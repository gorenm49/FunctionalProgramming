using System;

namespace FunctionalProgramming
{
    public class Alphabet
    {
        public void check()
        {

            Console.WriteLine("Enter Alphabets (A-Z) or (a-z)");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'A':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'E':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'I':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'O':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'U':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("Entered alphabet is Consonant");
                    break;
            }
        }
    }
}