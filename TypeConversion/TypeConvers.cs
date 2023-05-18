//Implicit Type Conersion
class Program
{
    static void Main()
    {
        //char 
        sbyte a = 10;
        char c = 'a';
        //int
        int b;

        //copy the value from 'a' to 'b'

        b = a;
        b= c;

        System.Console.WriteLine(a); //output:10
        System.Console.WriteLine(b); //output:10
        System.Console.WriteLine(c);




        //Explicit Casting
        //Synatx   (DestinationDataType)SourceValue
        int d = 100;
        float e;

        //int to float
        e= d;

        System.Console.WriteLine(d);//100
        System.Console.WriteLine(e);//100

        e=(float)d;
        System.Console.WriteLine(d);//100
        System.Console.WriteLine(e);//100



        //Parsing
        /*string -> int
         * 
         * Syntax: DestinationDataType.Parse(SourceValue)
         */

        string f = "100";

        int g=int.Parse(f);

        System.Console.WriteLine(f);//Output "100" as string
        System.Console.WriteLine(g);//Outpur  100 as int

        //Try Parse
        /*
         syantax : bool variable = DestinationType.TryParse(Sourcevake,out DestinationVariable)
         */

        string s;
        System.Console.WriteLine("enter a number");
        s=System.Console.ReadLine();


        //Try Parse
        bool h =int.TryParse(s, out int n);

        if (h == true)
        {
            System.Console.WriteLine("Conversion is Successfull");
        }
        else
        {
            System.Console.WriteLine("Conversion failed");
        }


        /*
         * Conversion methods
         * type destinationVariable = Convert.ConversionMethod(SourceValue)
         */

        int o = 10000;
        string p;

        p=System.Convert.ToString(o);
        System.Console.WriteLine(o);
        System.Console.WriteLine(p);
        System.Console.ReadKey();
    }
}








/*
 * 'Type Conversion' is a process of convert a value from one type to another type 
 * Implicit Casting === from lower-numerical-type to higher-numerical-type
 * Explicit Casting === from higher-numerical-type to lower-numerical-type
 * Parsing / TryParse === from string to numerical type
 * Conversion Methods === from any-primitive-type to any=primitive-type
 */