// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Consoleapp2
{internal class program
    {
        static void main(string[]args)
        {
            //a e i o u
            char vowel;
            Console.WriteLine("Enter the character");
            vowel=Convert.ToChar(Console.ReadLine);
            if(vowel=='a'||vowel=='i'||vowel=='o')
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
