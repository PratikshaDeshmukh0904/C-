class Program
{
    static void Main()
    {
        //create object of generic class
        User<int,int> user = new User<int,int>();
        User<bool,string> user1 = new User<bool,string>();

        //set value into generic field
        user.Registrationstatus = 1234;
        user1.Registrationstatus = false;

        user.Age = 22;
        user1.Age = "35-40";
        System.Console.WriteLine(user.Registrationstatus);
        System.Console.WriteLine(user1.Registrationstatus);

        System.Console.WriteLine(user.Age);
        System.Console.WriteLine(user1.Age);
        System.Console.ReadKey();   

    }
}

/*
 *Generic class is a class,which contains one or more "type parameters".
 *
 class ClassName<T>
 {
    public T FieldName;
 }
*object of Generic class

ClassName<int> referenceVariable = new ClassName<int>();
 */