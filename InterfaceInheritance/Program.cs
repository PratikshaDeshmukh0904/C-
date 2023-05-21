using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp;

            emp = new Manager();
            emp.DateOfBirth = System.Convert.ToDateTime("1990-07-18");
            System.Console.WriteLine(emp.GetAge());
           
            
            
            
            
            System.Console.ReadKey();
        }
    }
}
