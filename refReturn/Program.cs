class Student
{
    //public field
    public int grade=2;


    //public method
    public void PrintGrade()
    {
        System.Console.WriteLine("Grade: " + grade);
    }

    //public method with ref return
    public ref int DoWork()
    {
        return ref grade;
    }
}
class Program
{
    static void Main()
    {
        //creating object of Student
        Student student = new Student();
        
        //Call PrintGrade
        student.PrintGrade();


        //Call Dowork
        ref int g =ref student.DoWork();


        //Update the value of ref return
        g = 5;

        //call PrintGrade after updating the value of 'ref return'
        student.PrintGrade();

        System.Console.ReadKey();
    }
}