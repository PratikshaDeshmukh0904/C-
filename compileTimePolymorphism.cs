using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//method overloading class can have multiple methods having same name
namespace compileTimePolymorphism//static Polymorphism
{
    class compileTimePolymorphism
    {
        static void Main(string[] args)
        {
            compileTimePolymorphism obj = new compileTimePolymorphism();
            obj.sum(10.8f, 20.9f);
            Console.ReadLine();                                 //all the methods should have same name
        }                                                      //all the methods should have same class
        void sum(int a,int b)                                  //but should have different parameters
        {
            Console.WriteLine(a + b);
        }
        void sum(float a,float b)
        {
            Console.WriteLine(a + b);
           
        }
       
    }
    
}
