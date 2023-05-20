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
            Employee emp2 = new Employee(103, "P", "k");

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
            Manager mgr2 = new Manager(104, "a", "n", "Accounting");
            System.Console.WriteLine("Object of child class manager");
            System.Console.WriteLine(mgr1.EmployeeID);
            System.Console.WriteLine(mgr1.Location);
            System.Console.WriteLine(mgr1.EmployeeName);
            System.Console.WriteLine(mgr1.DepartmentName);
            System.Console.WriteLine(mgr1.GetFullDepartmentName());
            System.Console.WriteLine(mgr1.GetHealthInsuranceMethod());//it will execute child class method o/p will be 1500
            System.Console.WriteLine(mgr1.GetHealthInsuranceMethod1());//it execute parent class method 1st and then child class

            System.Console.WriteLine();


            //create object of SalesMAn
            SalesMan s1 = new SalesMan();
            s1.EmployeeID = 102;
            s1.EmployeeName = "Scott";
            s1.Location = "Hyderabad";
            s1.Region = "Karad";
            SalesMan s2 = new SalesMan(12, "g", "g", "j");
            System.Console.WriteLine("Object of child class SalesMan");
            System.Console.WriteLine(s1.EmployeeID);
            System.Console.WriteLine(s1.Location);
            System.Console.WriteLine(s1.EmployeeName);
            System.Console.WriteLine(s1.Region);
            System.Console.WriteLine();
        }
    }
}


/*
 *creating parent class
 
class ParentClassName
{
    public virtual void MethodName(parameter)
    {
    }
}

*creating child class

class Childclass1:ParentClassName
{
    public sealed override void MethodName()
    {
    }
}

*creating child class2

class ChildClass2:ChildClass1
{
    public override void MethodName() //Doesn't compile
    {
    }
}
 

Sealed Methods must be "override methods";which can;t be overridden in the corresponding child classes.
 
used sealed methods to prevent overriding that particular methods in the corresponding child classes
 
sealed method are opposite to virtual method
 */
