using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentButNoReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Program sum = new Program();
            sum.sum();
        }
        void sum()
        {
            int a = 29;
            int b = 45;
            int add;
            add = a + b;
            Console.WriteLine(add);
            Console.ReadLine();
        }
    }
}
