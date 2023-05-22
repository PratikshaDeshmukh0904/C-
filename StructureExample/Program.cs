// See https://aka.ms/new-console-template for more information
using StructureLibrary2;
class Program
{
    static void Main()
    {
        //create structure instance
        Structure1 structure1;
        structure1.x = 10;
        structure1.y = 20;

        //create object based on class
        Class1 class1;
        class1=new Class1();
        class1.x= 10;
        class1.y = 20;


        //create structure instance2
        Structure1 structure2=new Structure1();

        //copy data from structure1 to structure2
        structure2 = structure1;

        //modify data of structure2
        structure2.x = 100;
        structure2.y = 200;

        //print the value of structure1 and structure2
        System.Console.WriteLine(structure1.x);//10
        System.Console.WriteLine(structure1.y);//20
        System.Console.WriteLine(structure2.x);//100
        System.Console.WriteLine(structure2.y);//200
       
        //create reference variable of Class1
        Class1 class2;


        //copy refernce class1 to class2
        class2 = class1;

        //modify data of object through refernce  variable2
        class2.x = 1000;
        class2.y = 2000;

        System.Console.WriteLine(class1.x);//1000
        System.Console.WriteLine(class1.y);//2000
        System.Console.WriteLine(class2.x);//1000
        System.Console.WriteLine(class2.y);//2000
        System.Console.ReadKey();





    }
}
