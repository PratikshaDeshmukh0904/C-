using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Constructor
    {
        public Constructor()  //constructor have same class name,and constructor have return type
        {
            Console.WriteLine("Constructor");
        }
        static void Main(string[] args)
        {
            Constructor obj = new Constructor();
            Console.ReadLine();
        }
    }
}
