using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseladder
{
    class ifElseladder
    {
        static void Main(string[] args)
        {
            int marks = 40;

            if (80 <= marks)
            {
                Console.WriteLine("Distinction");
            }
            else if (70 <= marks)
            {
                Console.WriteLine("First Class");
            }
            else if (50 <= marks)
            {
                Console.WriteLine("Second Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.ReadLine();
        }
    }
}
