using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoArgumentButReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {

            Program sum = new Program();
            sum.Sum();
            Console.WriteLine(sum.Sum());
            Console.ReadLine();
        }

        int Sum()
        {
            int Add;
            int a = 10;
            int b = 20;
            Add = a + b;
            return Add;
        }
        
       

    }
}
