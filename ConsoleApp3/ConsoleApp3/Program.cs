using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a e i o u
            char vowel;
            Console.WriteLine("Enter the character");
             vowel = Convert.ToChar(Console.ReadLine());
            if (vowel == 'a' || vowel == 'i' || vowel == 'o')
            {
                Console.WriteLine("This is a vowel");
            }
            else
            {
                Console.WriteLine("not a vowel");

            }
        }

    }

}
