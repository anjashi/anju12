using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<20; i++)
            {
                if(i==8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
