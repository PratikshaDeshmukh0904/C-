using System;
using InnerClassLibrary;
class Program
{
    static void Main()
    {
        //create an object of inner class
        InnerClassLibrary.MarksCalculation.CalculationHelper ch = new InnerClassLibrary.MarksCalculation.CalculationHelper();
        
        //call the inner class's method
        Console.WriteLine(ch.Multiply(10, 5));

        //call outer class's method
        InnerClassLibrary.MarksCalculation mc = new InnerClassLibrary.MarksCalculation();
        Student s = new Student() {SecuredMarks=35,MaxMarks=50};

        mc.CalculatePercentage(s);
        Console.WriteLine(s.Percentage);
        Console.ReadKey();
    }
}