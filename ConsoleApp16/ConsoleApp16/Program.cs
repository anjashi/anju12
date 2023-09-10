using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp16
{
    class Demo
    {
        public void Connection()
         
        {
          //  try
            {
                SqlConnection con = new SqlConnection("server=DESKTOP-6FQ9581\\MSSQLSERVER01;integrated security=true; initial catalog=P");
                con.Open();
                Console.WriteLine("Establish connection");
            }
           // catch(Exception ex)
           // {
             //   Console.WriteLine("ex.Messaege");
           // }
        }

        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Connection();
            Console.ReadLine();
        }
    }
}
