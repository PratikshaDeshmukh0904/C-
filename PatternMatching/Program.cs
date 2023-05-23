/*
 It allows you to declare a variable,while checking the data type(class)of a reference varaible
 */

using PatternMatchingLibrary;
using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference variable of parent class
            ParentClass pc;

            //object of child class
            pc = new ChildClass() { x = 10, y = 20 };

            //access parent class member
            if(pc is ChildClass cc)
            {
                //ChildClass cc = (ChildClass)pc;
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }
           

            Console.ReadKey();
        }
    }
}