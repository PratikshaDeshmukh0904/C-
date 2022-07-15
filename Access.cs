using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Access
    {
        
    }
    class car
    {
        private string model;
        private string color;
        private int price;

        private void printinfo()
        {
            Console.WriteLine("Model:" + model);
            model = Console.ReadLine();
            Console.WriteLine("Color:" + color);
            color = Console.ReadLine();
            Console.WriteLine("Price:" + price);
            price = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            car obj = new car();
            obj.printinfo();            //To run program add main method in same class 
        }
    }
}
