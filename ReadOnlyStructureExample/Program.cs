// See https://aka.ms/new-console-template for more information
using ReadOnlyLibrary;

class Program
{
    static void Main()
    {
        //create structure instance
        Marvel m=new Marvel("Thanos");

        //invoke the properties and methods
        System.Console.WriteLine(m.CharacterName);
        m.PrintCharacterName();
        System.Console.ReadKey();
    }
}
