using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentButNoReturnValue
{
    class ArgumentNoReturnValue
    {
        static void Main(string[] args)
        {
            ArgumentNoReturnValue sum = new ArgumentNoReturnValue();
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
