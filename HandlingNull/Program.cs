using System;
class Person
{
    public int? NoOfChildren;
}
class Program
{
    static void Main()
    {
        //create object
        Person p1=new Person() { NoOfChildren=2};
        Person p2 = new Person() { NoOfChildren = null };
        Person p3 = null;
        //Console.WriteLine(p1.NoOfChildren);
        //if(p2.NoOfChildren.HasValue)
        //{
            //int x = p2.NoOfChildren.Value;
            Console.WriteLine(p2.NoOfChildren??0);
        //}




        System.Console.ReadKey();
    }
}
/*
 The 'null coalescing operator' checks whether the value is null or not.
 It returns the left-hand-side operand if the value is not null.
 It returns the right-hand-side operand if the value is null.

Simplifying the syntax of 'if statement' to check if the value is nu
**Null Coalescing Operator

variableName??valueIfNull

 
 */