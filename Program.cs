using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgymentAndReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Obj = new Program();
            Obj.sum(10,20);
        }
        int sum(int num1 , int num2)
        {
            int result;
           
            result = num1 + num2;
            return result;
        }
    }
}
