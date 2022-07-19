using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Continue
    {
        static void Main(string[] args)
        {

            
            for(int a=10;a<=20;a--)
            {
                Console.WriteLine(a);
                if(a==5)
                {
                    continue;//it force to loop to go next iteration
                }
                Console.ReadLine();
            }
        }
    }
}
