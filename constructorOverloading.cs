using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorOverloading
{
    class constructorOverloading
    {

        
    }
    class car
    {
        string carModel;
        int carYear;
        public car(string Model,int Year)
        {
             carModel = Model;
             carYear = Year;

        }
        public car(int Year,string Model)
        {
             carModel = Model;
            carYear = Year;

        }
        static void Main(string[] args)
        {
            car myCar = new car("BMW", 2022);
            Console.WriteLine("Model:"+myCar.carModel);
            Console.WriteLine("Year:" + myCar.carYear);
            Console.ReadLine();
        }
    }

}   

