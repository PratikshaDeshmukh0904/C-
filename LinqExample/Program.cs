using System;
using System.Linq;

namespace LinqExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }

        public string City { get;set; }
        public double Salary { get; set; }
    }
    class Temporary
    {
        public bool Check(Employee emp)
        {
            return emp.Job == "Manager";
        }
    }
    class Person
    {
        public string PersonName { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=101,EmpName="Henry",Job="Designer",City="Boston",Salary=7223},
                new Employee(){EmpID=102,EmpName="Jack",Job="Developer",City="New York",Salary=4500},
                new Employee(){EmpID=103,EmpName="Gabriel",Job="Analyst",City="Tokyo",Salary=1296},
                new Employee(){EmpID=104,EmpName="William",Job="Manager",City="New York",Salary=6232},

            };
            //var result= employees.Where(emp=>emp.Job=="Manager");
            
            IEnumerable<Employee> result = employees.Where(emp => emp.City == "New York");
            
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID + "," + item.EmpName);
            }

            //Order By
            IOrderedEnumerable<Employee>sortedEmployee=employees.OrderBy(emp => emp.Job).ThenBy(emp=>emp.EmpName);
            foreach(Employee item in sortedEmployee)
            {
                Console.WriteLine(item.EmpID+"," + item.EmpName);
            }

            //first
            List<Employee> filteredEmployees =employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(filteredEmployees[0].EmpID + "," + filteredEmployees[0].EmpID);

            //FirstOrDefault
            Employee firstManager2 = employees.FirstOrDefault(emp => emp.Job == "Clerk");
            if(firstManager2 != null)
            {
                Console.WriteLine(firstManager2.EmpID + "," + firstManager2.EmpName);

            }
            else
            {
                Console.WriteLine("No clerk in the list");
            }

            //Last
            List<Employee> filteredEmployees1 = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(filteredEmployees1[filteredEmployees1.Count - 1].EmpID + "," + filteredEmployees1[filteredEmployees1.Count - 1].EmpName + "," + filteredEmployees1[filteredEmployees1.Count-1].Job);

            //Last
           Employee lastemployee= employees.Last(emp => emp.Job == "Manager");

            Console.WriteLine(lastemployee.EmpID+","+lastemployee.EmpName);

            //LastOrDefault
            Employee lastemployee2 = employees.LastOrDefault(emp => emp.Job == "Clerk");

            if (lastemployee2 != null)
            {
                Console.WriteLine(lastemployee2.EmpID + "," + lastemployee2.EmpName);
            }
            else
            {
                Console.WriteLine("No Clerk found");
            }

            //ElementAt
            Employee resultEmp=employees.Where(emp => emp.Job == "Manager").ElementAt(1);
            Console.WriteLine(resultEmp.EmpID+","+resultEmp.EmpName);


            //ElementAtDefault
            Employee resultEmp2 = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
            if(resultEmp2!=null)
            {
                Console.WriteLine(resultEmp2.EmpID + "," + resultEmp2.EmpName);
            }
            else
            {
                Console.WriteLine("No manager at index 4");
            }

            //Single
           Employee firstEmployee= employees.Single(emp => emp.EmpID == 102);

            if(firstEmployee!=null)
            {
                Console.WriteLine(firstEmployee.EmpID + "," + firstEmployee.EmpName);

            }

            //SingleOrDefault
            Employee firstEmployee1 = employees.SingleOrDefault(emp => emp.Job == "Manager");

            if (firstEmployee1 != null)
            {
                Console.WriteLine(firstEmployee1.EmpID + "," + firstEmployee1.EmpName);

            }
            else
            {
                Console.WriteLine("No matching employee");
            }


            //select
            List<Person> result1 = employees.Select(emp => new Person() { PersonName=emp.EmpName}).ToList();
            foreach(Person item in result1)
            {
                Console.WriteLine(item);
            }


            //Min,Max,Sum,Average,Count
            double min= employees.Min(emp => emp.Salary);
            double max = employees.Max(emp => emp.Salary);
            double sum = employees.Sum(emp => emp.Salary);
            double avg=employees.Average(emp => emp.Salary);
            double cnt = employees.Count();

            Console.WriteLine("Min:" + min);
            Console.WriteLine("Max :" + max);
            Console.WriteLine("Sum :" + sum);
            Console.WriteLine("avg :" + avg);
            Console.WriteLine("Count :" + cnt);
            Console.ReadKey();
        }
    }
}