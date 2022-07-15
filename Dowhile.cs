using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Dowhile
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);
            Console.ReadLine();
            
        }
    }
}
