using System;
using ECommerce;
using System.Collections.Generic;

namespace CollectionofObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create an empty collection
            List<Product> products = new List<Product>();

            //loop to read data from user
            string choice;
            do
            {
                Console.WriteLine("Enter Product ID: ");
                int pid=int.Parse(Console.ReadLine());
                
                Console.WriteLine("enter Product Name:");
                string pname = Console.ReadLine();

                Console.WriteLine("Enter Price");
                double unitPrice=double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Date of Manufacture(yyyy-MM-dd) :");
                DateTime dom= DateTime.Parse(Console.ReadLine());

                //create a new object of Prodcut class
                Product product = new Product() { ProductID=pid,ProductName=pname,Price=unitPrice,DateOfManufacture=dom};

                //Add Product object to the collection
                products.Add(product);

                //Ask the user to continue
                Console.WriteLine("Product Added.\n");
                Console.WriteLine("Do you want to continue to next product?(Y/N)");

                choice = Console.ReadLine();


            } while (choice != "No" || choice != "no" || choice != "n" || choice!="N");

            //foreach
            Console.WriteLine("\n Products");
            foreach(Product item in products)
            {
                Console.WriteLine(item.ProductID+" ,"+item.ProductName+","+item.Price+","+item.DateOfManufacture.ToShortDateString());
            }


            Console.ReadKey();
        }
    }
}