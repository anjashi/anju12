using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class sample
    {
        int i;
        double k;
        public sample (int ii,double kk)
        {
            i = ii;
            k = kk;
            double j = (i) + (k);
            Console.WriteLine (j);
        }
        ~sample()
        {
            double j = i - k;
            Console.WriteLine (j);
        }
    }
    class progrm
    {
        static void Main(string[]args)
        {
            sample s = new sample(8, 2.5);
            Console.ReadLine();
        }
    }
}
