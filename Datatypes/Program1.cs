using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //float,double,decimal,bool,string ,char,int
            string phrase = "Pratiksha Deshmukh";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine(true);
            Console.WriteLine("My Name is "+phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("P")); //True Contains method used for is string contains character or not
            Console.WriteLine(phrase.Contains("Z"));//False
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[10]);
            Console.WriteLine(phrase.IndexOf("Deshmukh"));//Starting index position Deshmukh
                                                          //string starts from index 10 so o/p will be 10
            Console.WriteLine(phrase.IndexOf('x'));//-1 always shows that character does not present
            Console.WriteLine(phrase.Substring(8));//return string from index which is as given parameter
                                                   //a Deshmukh
            Console.WriteLine(phrase.Substring(8,3));//a D
            //return 3 character from 8th index 
            Console.ReadLine();
        }
    }
}
