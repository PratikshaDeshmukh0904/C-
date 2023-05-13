using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.WriteLine("Do-While");
            index = 1;
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);
            Console.ReadLine();
        }
    }
}
