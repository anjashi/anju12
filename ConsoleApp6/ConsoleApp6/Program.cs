// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.ComponentModel;

namespace Consoleapp6
{
    class Parent
    {
        public void Add()
        {
            Console.WriteLine("Add in two number");
                }
        public Parent()
        {
            Console.WriteLine("Parent Constant");

        }
   }
    class Program: Parent
    {
        public void Sub()
        {
            Console.WriteLine(" Sun Function");
        }
        static Program()
        {
            Console.WriteLine("Static Program"); 
        }
      static void Main (string[] args)
        { 
            Child1 child2 = new Child1();
            Child2 child = new Child2();
        }
    }
    class Child2: Parent
    {
        public Child2(){ Console.WriteLine("Child2 Constr"); }
    }
}
  