class Student
{
    public void DisplyaMArks(int m1, int m2, int m3)
    {
        double avgMarks = getAverageMarks(m1,m2,m3);
        System.Console.WriteLine("Marks1: " + m1);
        System.Console.WriteLine("Marks2: " + m2);
        System.Console.WriteLine("Marks3: " + m3);
        System.Console.WriteLine("Average MArks: " + avgMarks);

        //create local functions
       static double getAverageMarks(int mark1,int mark2,int mark3)
        {
            //create local variable of local function
            double avg;
            avg = (double)(mark1 + mark2 + mark3) / 3;
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
        s.DisplyaMArks(45, 67, 89);

        System.Console.ReadKey();
    }
}
