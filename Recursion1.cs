using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursion1
{
    class Recursion1
    {
        int num = 1;
        void counting()
        {
            if(num == 30)
            {
                return; //In Recursion Method must have an exit condition
            }
            Console.WriteLine(num);
            num++;
            counting();//recursion means method can call itself again & again
        }
        static void Main(string[] args)
        {
            Recursion1 count = new Recursion1();
            count.counting();
            Console.ReadLine();//Process is terminated due to StackOverflowException.
           

        }
    }
}
