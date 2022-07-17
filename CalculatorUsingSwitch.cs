using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUsingSwitch
{
    class CalculatorUsingSwitch
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Symbol (+,-,*,/");
           string symbol = Console.ReadLine();
           
            
            switch(symbol)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Addition:"+result);
                  
                    Console.ReadLine();
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Substraction:" + result);
                    Console.ReadLine();
                    break;


                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Multiplication:" + result);
                    Console.ReadLine();
                    break;


                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Division:" + result);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
