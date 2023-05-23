using System;
using System.ComponentModel;
using IDisposalLibrary;

namespace IDisposal
{
    class Program
    {
        static void Work()
        {
            //create object using declaration
            using Sample s = new Sample();
            
               s.DisplayDataFromDatabase();
            
        }//Dispose gets called here
        static void Main()
        {
            Work();
            //create object using "using structure"
           /* using(Sample s= new Sample())
            {
                s.DisplayDataFromDatabase();
            }*/
            Console.WriteLine("Some other work here");

            Console.ReadKey();
        }
    }
}
