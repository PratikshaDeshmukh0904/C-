/*
 The variable that are declared with 'var' keyword are called as 'implicitly-typed variables'
var variableName=value;
 
 */

namespace ImplicitlyTyped
{
    class Program
    {
        static void Main()
        {
           // namespace1.namespace2.namespace3.Person p;
           var p= new namespace1.namespace2.namespace3.Person() { PersonName = "Pratiksha" };

            var p2="Harsha".ToUpper();

            Console.WriteLine(p.PersonName);
            Console.ReadKey();
        }
    }
}