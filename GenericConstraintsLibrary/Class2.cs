public abstract class Student
{
    public abstract int Marks { get; set; }
}
public class GraduateStudent : Student
{
    public override int Marks { get; set; }
}
public class PostGraduation : Student
{
    public override int Marks { get; set; }
}
//generic class
public class MarksPrinter<T> where T : Student
{
    public T stu;
    public void PrintMarks()
    {
        Student temp=(Student)stu;
        System.Console.WriteLine(temp.Marks);
    }
}