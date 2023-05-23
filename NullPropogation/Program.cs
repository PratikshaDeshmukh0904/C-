namespace NullPropogation
{
    class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main()
        {
            //p is null
            Person p1=new Person() { Age=20};
            //Console.WriteLine((p1==null)?null:Convert.ToString(p1.Age));
           
            Console.WriteLine(p1?.Age);
            Console.ReadKey();
        }
    }
}


/*
 Null Propagation Operator (?.) and (?[]) checks the value of
 left-hand operand whether it is null or not.

referenceVariable?.fieldName

--is same as  --

(referenceVariable == null) ? null : referenceVaiable.fieldName;
 
 */