class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for(int i = 0;i < subjects.Length; i++)
        {
            System.Console.WriteLine(subjects[i]);
        }
       
    } 
}
class Program
{
    static void Main()
    {
        //create object of StudentClass
        Student s = new Student();

        //access DisplaySubjects method
        s.DisplaySubjects("php","C#","java","python");
        System.Console.ReadKey();
    }
}

















//All the set of arguments wiil be at-a-time received as an array into
//the parameter

/*
 * Method Definition
accessmodifier modifier returndatatype methodname(param datatype[] parameter1,..)
{
Parameter1[index] //To access value based on index
}
*/
/*
 * MEthod Calling
 methodname(Argument1,argument2,argument3)
 */

//if we dont no how many values received then use param
