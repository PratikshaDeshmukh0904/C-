class Program
{
    static void Main()
    {
        //create object
        Sample sample = new Sample();
        Employee emp=new Employee() { Salary=1000};
        Student student = new Student() { Marks = 80 };

        //call the generic method
        sample.PrintData<Employee>(emp);
        sample.PrintData<Student>(student);
        System.Console.ReadKey();
    }
}



/*
 * Generic Method is a method that has one or more generic parameters
 * 
 * You can restrict what type of data types(class names)allowed to be passed while creating object.
 */