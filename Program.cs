using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestedif
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if(a==10)
            {
                if(b==20)
                {
                    Console.WriteLine("value of a is 10 and b is 20");
                }
            }
            Console.ReadLine();
        }
    }
}
