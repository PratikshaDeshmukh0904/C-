using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Encapsulation
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            int c= myAccount.accountBalance = 100;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
    class Account
    {
        public int accountBalance = 10000;
    }
}
