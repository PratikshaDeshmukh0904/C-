namespace InnerClassLibrary
{
    public class Student
    {
        public double SecuredMarks;
        public double MaxMarks;
        public double Percentage;
    }
    //outer class
    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            //create object of inner class
            CalculationHelper ch = new CalculationHelper();
            //s.Percentage = s.SecuredMarks / s.MaxMarks * 100;
            s.Percentage = s.SecuredMarks / ch.Multiply(s.MaxMarks,100);
        }
        //inner class
       public class CalculationHelper
        {
            public double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }
        }
    }
}