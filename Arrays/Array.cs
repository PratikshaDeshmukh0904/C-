using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };

            Console.WriteLine(luckyNumbers[0]); //1
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);//900

            string[] friends = new string[100];//how many elements stored in array
            friends[0] = "Aarti";
            friends[1] = "Pratiksha";
            Console.WriteLine(friends[1]);

            Console.ReadLine();
        }
    }
}
