using System.ComponentModel.DataAnnotations;
using ObjectClassLibrary;
class Program
{
    static void Main()
    {
        //create an object of PErson class
        System.Object obj = new Person() { PersonName ="Scott",Email="scott2@gmail.com"};
        
        //access methods
        Console.WriteLine(obj.Equals(new Person()));//False
                                                    
        Console.WriteLine(obj.Equals(new Person() { PersonName = "Scott", Email = "scott2@gmail.com" }));
        Console.WriteLine(obj.GetHashCode());
        Console.WriteLine(obj.ToString());
        Console.WriteLine(obj.GetType().ToString());
        Console.ReadKey();
    }
}

/*
 1.All C# classes,structures,interfaces,enumerations are children of System.Object class.
2.Every method defined in the Object class is available in all objects in the system as all classes in .Net Framework are derived from Object class
 
 
 */