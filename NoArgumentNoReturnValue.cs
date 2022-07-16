using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoArgumentNoReturnValue
{
    class NoArgumentNoReturnValue
    {

        void argument()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            NoArgumentNoReturnValue a = new NoArgumentNoReturnValue();
            a.argument();
        }
    }
}
