using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach
{
    class forEach
    {
        int[] no = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
        static void Main(string[] args)
        {
            forEach obj = new forEach();
            obj.numbers();

        }

        public void numbers()
        {
            foreach(int  Num in no )
            {
                Console.WriteLine(Num);
                Console.ReadLine();
            }
        }
    }
}
