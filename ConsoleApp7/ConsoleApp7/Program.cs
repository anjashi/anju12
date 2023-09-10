// See https://aka.ms/new-console-template for more i
using System;
namespace ConsoleApp7
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
        void Add ();
    }
    public interface Abc:Car
    {
        void sub (); 
    }
    internal class program:Abc
    {
        public void add ()
        {
            Console.WriteLine("add function");
            
            }
        public void SUB ()
        {
            Console.WriteLine("SUB FUNCTION");
        }
        static void Main(string[] args)
        {
            
            
            
        }
    }
}