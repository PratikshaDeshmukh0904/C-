// See https://aka.ms/new-console-template for more information

using static System.Console;
using Warehouse;
class Program
{
    static void Main()
    {
        //create object of Partial class
        Product product = new Product();

        //access properties 
        product.ProductID = 1;
        product.Cost = 11000;

        //access method
        // WriteLine(product.GetTax());
        Console.WriteLine(product.CallGetTax);
            ReadKey();
    }
}


//Partial class is a class that splits into multiple files.

/*
 file.cs

partial class ClassName
{
    member1
}
file2.cs

partial class ClassName
{
    member2
}
 */

