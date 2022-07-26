using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    class method3
    {
        
        static void Main(string[] args)
        {
            

            int no1 = 10;
            int no2 = 20;
            method3 maxno = new method3();
             int c=maxno.Findmax(no1,no2);
            Console.WriteLine( c);
            Console.ReadLine();
           
        }

        public int Findmax(int no1,int no2)
        {
            int result;
           
            if(no1>no2)
            {
                result = no1;
            }
            else
            {
                result = no2;
            }
            return result;
            
        }
    }
}
