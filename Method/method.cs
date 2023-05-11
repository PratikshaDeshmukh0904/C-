using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class method
    {
        static void Main(string[] args)
        {
            SayHi("Pratiksha",22);
            SayHi("Aarti",21);
            SayHi("PD",23);
            Console.ReadLine();
        }
        static void SayHi( string name,int age)
        {
            Console.WriteLine("Hello User "+name+" your age is " +age);
        }
    }
}
