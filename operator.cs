using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class @operator
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine("Addiion:"+result);//Addition Operator

            if(a>b)                        //Substraction
            {
                 result = b - a;
                Console.WriteLine("Substraction:"+result);
            }
            else
            {
                result = a - b;
                Console.WriteLine("Negative"+result);
            }


            //Multiplication
            result = a * b;
            Console.WriteLine("Multilpication:"+result);


            //Division
            result = a / b;
            Console.WriteLine("Division:" + result);




            //prefix
            int x = 30;
            int y;
            y = ++x;  //a=a+1;
            Console.WriteLine("x"+x);
            Console.WriteLine("y"+y);


            //postfix

            y = x++;
            Console.WriteLine("x" + x);
            Console.WriteLine("y" + y);

            Console.ReadLine();
        }
    }
}
