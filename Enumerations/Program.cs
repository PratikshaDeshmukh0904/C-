// See https://aka.ms/new-console-template for more information
using enumLibrary;
using System;
class Program
{
    static void Main()
    {
        //create object of Person class
        Person person = new Person();
        person.PersonName = "John";
        person.Email = "john1@gmail.com";
        person.AgeGroup = AgeGroupEnumeration.Adult;

        Console.WriteLine(person.AgeGroup);
        Console.ReadKey();
    }
}




/*
* Enumeration is a collection of constants.
    
*Enumerations is used to specify the list of options allowed to be stored
    in a field/variable.

* use enumeration if you dont want to allow other developers to assign other value into a field/variable,other than the list of values
specified in the enumeration.

*EnumerationName.ConstantName 

enum EnumerationName
{
    Constant1,constant2,...
}
 
 */