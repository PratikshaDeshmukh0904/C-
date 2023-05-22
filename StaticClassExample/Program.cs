// See https://aka.ms/new-console-template for more information

/*
 1.static class is a class that can contain only "static members".
 
 2.if you don't want even single 'instance member'
    then use 'static class'.

 3.we can avoid accidental creation of object for the class,by making it as "static class".

 
 */

class Program
{
    static void Main()
    {
        //access static field
        Console.WriteLine(Country.CountryName);
        Console.WriteLine(Country.NoOfState);
        Console.WriteLine(Country.GetNoOfUnionTerritories());

        Console.ReadKey();
    }
}