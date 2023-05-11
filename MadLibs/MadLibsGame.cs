using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    internal class MadLibsGame
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color= Console.ReadLine();

            Console.WriteLine("Enter a Plural ");
            pluralNoun= Console.ReadLine();

            Console.WriteLine("Enter a celebrity");
            celebrity= Console.ReadLine();

            Console.WriteLine("Roses are "+color);
            Console.WriteLine(pluralNoun +"are blue");
            Console.WriteLine("I Love "+celebrity);
            Console.ReadLine();
        }
    }
}
