using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class method
    {
        int a = 10;
        int b = 20;
        int result;

        void add()
        {
            result = a + b;
            displayresult();

        }

        void displayresult()
        {
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            method obj = new method();
            obj.add();

        }
    }
}
