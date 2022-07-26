using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method2
{
    class method2
    {
        public int max(int a, int b)
        {
            int result;
            if(a>b)
                {
                result = a;
                }
            else
            {
                result = b;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            method2 max = new method2();
            max.max(a,b);
            Console.WriteLine(max.max(a, b));
            Console.ReadLine();
        }
    }
}
