using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceone
{
 
        public class Demo
        {
            public virtual void horn()
            {
                Console.WriteLine("Prap prap");
            }
        }
        public interface Car
        {
            void Add();
        }
        public interface Abc : Car
        {
            void sub();
        }
        internal class Program:Abc
        {
            public void Add()
            {
                Console.WriteLine("add function");

            }
            public void sub()
            {
                Console.WriteLine("SUB FUNCTION");
            }
            static void Main(string[] args)
            {
            


            }
        }
    }
   
        
   

