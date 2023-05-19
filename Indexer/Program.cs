class Program
{
    static void Main()
    {
        //create an object of Car class
        Car c = new Car();

        //call get accessor of index
        System.Console.WriteLine(c[0]); //output BMW
        System.Console.WriteLine(c[1]);
        System.Console.WriteLine(c[2]);

        System.Console.WriteLine(c["first"]); //BMW


        //call set accessor of index
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]); //Nissan
        System.Console.ReadKey();
    }
}






















/*
 Receive a number/string .Search for the particular item among a group of
 items;set or get value into the group of items.

It provides shorter syntax to access a group of items.

Indexer is a special member of class,which contains set-accessor
and get-accessor to access a group of items/elements.

class Car
{
    private string _brands="brand1,brand2,brand3";
    public string this[int index]
    {
        set
        {
            this._brands=value;
        }
        get
        {
            return _brands;
        }

    }
}

Indexer are always created 'this' keyword


 */