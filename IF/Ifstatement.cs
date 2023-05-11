using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    internal class Ifstatement
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
            Console.ReadLine();
        }
    }
}
