/*
 Boxing =Conversion of value type to reference type

 */
class Program
{
    static void Main()
    {
        //primitive variable
        int x = 10;

        //boxig value type to refernce type
        object obj = x;
        System.Console.WriteLine(x);//10
        System.Console.WriteLine(obj);//10

        //refernce type into value type
        object obj1 = 20;

        //unboxing
        int y =(int)obj;

        System.Console.WriteLine(y);
        System.Console.WriteLine(obj1);

        System.Console.ReadKey();
    }
}