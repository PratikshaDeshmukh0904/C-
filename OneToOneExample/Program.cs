using System;
using College;

namespace OneToOneExample
{
    class Program
    {
        static void Main()
        {
            //student class's object
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Scott";
            student.Email = "Scott@gmail.com";
            

            //branch class's object
            Branch branch = new Branch();
            branch.BranchName = "Compute Science";
            branch.NoOfSemesters = 8;

            //one-to-one relation
            student.branch = new Branch();
            student.branch.BranchName = "Computer Science";
            student.branch.NoOfSemesters = 8;

            //display
            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.NoOfSemesters);
            Console.WriteLine(student.branch.BranchName);

            Console.ReadKey();
        }
    }
}