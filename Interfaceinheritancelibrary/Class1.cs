using System;

namespace Interfaceinheritancelibrary
{
    public class Class1
    {

    }
}

/*
 Interface Inheritance

interface Interface1
{
    public void Method1(param1,param2,..)
}
interface Interface2:interface1
{
    public void Method2(param1,param2,..)
}
class ChildClass:interface2
{
    public void Method1(param1,param2,...)
    {
    }
    public void Method2(param1,param2,...)
    {
    }
}
 
Interface1 c1 = new ChildClass();
c1.Method1(...);                       //calls ChildClass.Method1

Interface2 c2 = new ChildClass();
c2.Method1(...);   //calls ChildClass.Method1
c2.Method2(...);  //calls ChildClass.Method2

 */