using System;  //Default Class


namespace method1 //namespace
{
    class method1 //class
    {
        
        
        public int Findmax(int num1,int num2)//pass parameters
        {
            int result;
            if(num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static void Main(string[] args) //default method
        {
            method1 obj = new method1();
            obj.Findmax(10,20);   //pass arguments

        }
    }
}
