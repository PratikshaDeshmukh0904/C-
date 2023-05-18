class Student
{
    public void DisplyaMArks(int m1,int m2,int m3)
    {
        double avgMarks =getAverageMarks();
        System.Console.WriteLine("Marks1: " + m1);
        System.Console.WriteLine("Marks2: "+m2);
        System.Console.WriteLine("Marks3: "+m3);
        System.Console.WriteLine("Average MArks: "+avgMarks);

        //create local functions
        double getAverageMarks()
        {
            //create local variable of local function
            double avg;
            avg =(double)(m1+m2+m3)/3;
            return avg;
        }
    }
}

class Program
{
    static void Main()
    {
        //create object for Student Class
        Student s = new Student();

        //call displaymarks
        s.DisplyaMArks(45,67,89);

        System.Console.ReadKey();
    }
}








/*
1. Local Functions are functions to do some small process which is written inside a method
e.g calculate student percnetage


2.local functions are not of the class;they cant be called directly through reference variable.
3.Local functions dont support "accessModifiers" and "modifiers"
4.Local functions support parameters ,return

public void methodname(param1,param2,...)
{
LocalFuncname();  //Calling the LocalFunction

ReturnDatatype LocalFuncname(param1,param2,...)
{
 //Local Function Body Here
}
 
 */