class Sample
{
    public double Factorial(int number)
    {
        if(number == 0)
        {
            return 1;
        }
        else
        {
            return number*Factorial(number-1);
        }
    }
}
class Recursion
{
    static void Main()
    {
        //read number from keyboard
        System.Console.WriteLine("Enter a number: ");
        int n=int.Parse(System.Console.ReadLine());

        //create object
        Sample s = new Sample();

        //call Factorial method
        double fact=s.Factorial(n);


        System.Console.WriteLine("Factorial of Number is: "+ fact);
        System.Console.ReadKey();

    }
}






/*
 A method calls itself.
USeful in mathematic computations ,such as finding factorial of a number

----Recursive Method---

public void MethodName()
{
    if(condition)
    {
    MethodName(); //Calling same method
    }
}
 */