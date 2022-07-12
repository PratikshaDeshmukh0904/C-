using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        int num1;
        int num2;
        int result;

        public void addition()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
           
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.num1 = 10;
            obj.num2 = 20;
        
        
            obj.addition();

        }
    }
}
