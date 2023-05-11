using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32("45");
            Console.WriteLine(num+6);

            Console.WriteLine("Enter a Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+ num2);
            Console.ReadLine();

        }
    }
}
