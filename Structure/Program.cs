// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        //structure instances
        Category category=new Category();

        //initialize fields through properties
        category.CategoryID = 20;
        category.CategoryName = "Test";

        //parameterized constructor

        Category category1 = new Category(101,"a");

        //access methods
        Console.WriteLine(category.CategoryID);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetcategoryNameLength());
        Console.ReadKey();
    }
}


/*
 structure is a "type" ,similar to "class" ,which can contain fields,methods,parameterized constructor,properties,events.
 
 
 */