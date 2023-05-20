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
           /* Employee emp1 = new Employee();
            emp1.EmployeeID = 101;
            emp1.EmployeeName = "Scott";
            emp1.Location = "Sangli";
            Employee emp2 = new Employee(103, "P", "k");

            System.Console.WriteLine("Object of Parent Class Employee:");
            System.Console.WriteLine(emp1.EmployeeID);
            System.Console.WriteLine(emp1.Location);
            System.Console.WriteLine(emp1.EmployeeName);
            System.Console.WriteLine();*/

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
            System.Console.WriteLine(mgr1.GetHealthInsuranceMethod());//abstract method of manager class
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
            System.Console.WriteLine(s2.GetHealthInsuranceMethod()); //abstract ethod
            System.Console.WriteLine();
        }
    }
}

/*
 Abstract class is a parent class,for which ,we cant create object;
but we can create child classes.

abstract class AbstractClassName
{
    Abstract Class Members here
}
 
class ChildClassName:AbstractClassName
{
    childClass Members here
}


// The main intention of abstract class is to provide common set of fields and methods
   to all of ites child classes of a specific group.


 
 */


//Abstract Methods

/*
 Abstract methods are declared in parent class,with "abstract" keyword;
 implemented in child classes,with  "override" keyword.


When the parent class dont want to peovide the definition of a method;
it wants to let child classes to implement the method.


Abstract methods contain "method declaration" only ;but not "method body"

    abstract void changeGear(int gearNumber)
 
Child class  must provide method body for abstract methods

 */