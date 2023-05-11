using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            string characterName = "Pratiksha";
            int characterAge;
            characterAge = 23;

            Console.WriteLine("There once was a man named "+ characterName);
            Console.WriteLine("He was "+ characterAge +" years old");

            
            characterName = "Aarti";
            Console.WriteLine("He really liked the name "+ characterName);
            Console.WriteLine("But didn't like being "+ characterAge);
            Console.ReadLine();
        }
    }
}
