using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of Employee
            Employee emp1 = new Employee();
            emp1.EmployeeID = 101;
            emp1.EmployeeName = "Scott";
            emp1.Location = "Sangli";
            System.Console.WriteLine("Object of Parent Class Employee:");
            System.Console.WriteLine(emp1.EmployeeID);
            System.Console.WriteLine(emp1.Location);
            System.Console.WriteLine(emp1.EmployeeName);
            System.Console.WriteLine();

            //create object of Manager
            Manager mgr1 = new Manager();
            mgr1.EmployeeID = 102;
            mgr1.EmployeeName = "Scott";
            mgr1.Location = "Hyderabad";
            mgr1.DepartmentName = "Accounting";
            System.Console.WriteLine("Object of child class manager");
            System.Console.WriteLine (mgr1.EmployeeID);
            System.Console.WriteLine(mgr1.Location);
            System.Console.WriteLine(mgr1.EmployeeName);
            System.Console.WriteLine(mgr1.DepartmentName);
            System.Console.WriteLine();


            //create object of SalesMAn
            SalesMan s1 = new SalesMan();
            s1.EmployeeID = 102;
            s1.EmployeeName = "Scott";
            s1.Location = "Hyderabad";
            s1.Region = "Karad";
            System.Console.WriteLine("Object of child class SalesMan");
            System.Console.WriteLine(s1.EmployeeID);
            System.Console.WriteLine(s1.Location);
            System.Console.WriteLine(s1.EmployeeName);
            System.Console.WriteLine(s1.Region);
            System.Console.WriteLine();
        }
    }
}
