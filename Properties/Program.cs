class Program
{
    static void Main()
    {
        //create three onjects for employee
        Employee emp1 = new Employee(); //constructor3
        emp1.EmpID = 10;
        emp1.EmployeeName = "Pratik";
        emp1.Job = "Manager";
        emp1.Tax = 1000;
        emp1.NativePlace = "New Delhi";
        Employee emp2 = new Employee(102, "allen"); //constructor 2
        Employee emp3 = new Employee(103, "Anna", "Clerk"); //constructor 1
        Employee emp4 = new Employee() { EmployeeName = "For", Job = "Executive" };

        //display fields
        System.Console.WriteLine("CompanyName", Employee.CompanyName);
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp2.EmployeeName);
        System.Console.WriteLine(emp1.Job);
        System.Console.WriteLine(emp1.Salary);
        System.Console.WriteLine(emp1.CalculateNetSalary());
        System.Console.WriteLine(emp2.NativePlace);
        System.Console.ReadKey();
    }
}