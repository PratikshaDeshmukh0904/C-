using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setget2
{
    class setget2
    {
        static void Main(string[] args)
        {
            Account myaccount = new Account();
            myaccount.balance = 3000000;
            Console.WriteLine("Your Account Balance is :" + myaccount.balance);
            Console.ReadLine();

        }
    }
    class Account
    {
        int accountbalance = 10000;
        public int balance
        {
            set
            {
                
                if (value<0)
                {
                    Console.WriteLine("Your Account Balance is :"+value);
                }
                else
                {
                    accountbalance = value;
                }
            }
            get
            {
                return accountbalance;
            }
        }
    }
}
