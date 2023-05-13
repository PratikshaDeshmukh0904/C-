using System;

class Bank
{
    //Application execution start here
    static void Main()
    {
        //Display Title
        System.Console.WriteLine("**********Pratiksha Bank***********");
        System.Console.WriteLine("::Login Page::");

        //declare variables to store username and Password;
        string userName = null, password = null;

        //read userNAme from keyboard
        System.Console.WriteLine("Username:");
        userName=System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if(userName != "")
        {
            System.Console.WriteLine("Password:");
            password = System.Console.ReadLine();

        }
        //check username and password
        if(userName=="system" && password == "manager")
        {
            int mainMenuChoice = -1;
            do
            {
                //declare variable to store menu choice
               
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Funds Transfer");
                System.Console.WriteLine("4.Funds Transfer Statement");
                System.Console.WriteLine("5.Account Statements");
                System.Console.WriteLine("0.Exit");

                System.Console.WriteLine("Enter choice:");
                mainMenuChoice = Convert.ToInt32(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        customerMenu();
                        break;
                    case 2:
                        accountMenu();
                        break;
                    case 3:
                        System.Console.WriteLine("");
                        break;
                    case 4:
                        System.Console.WriteLine("");
                        break;
                    case 5:
                        System.Console.WriteLine("");
                        break;
                    case 0:
                        System.Console.WriteLine("");
                        break;
                    default:
                        System.Console.WriteLine("Menu not available");
                        break;
                }
            }
            while (mainMenuChoice !=0);
            
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }

        //To exit 
        System.Console.WriteLine("Thank you!visit again.");
        System.Console.ReadKey();
       
    }
    static void customerMenu()
    {
        //variable to store customer menu choice
        int customerMenuChoice = -1;

        //do-while loop starts
        do
        {
            System.Console.WriteLine("\n:::Customers menu:::");
            System.Console.WriteLine("1.Add Customer");
            System.Console.WriteLine("2.Update Customer");
            System.Console.WriteLine("3.Delete Customer");
            System.Console.WriteLine("4.View Customer");
            System.Console.WriteLine("Back to Main Menu");


            //accept customers menu choice
            System.Console.Write("Enter Choice:");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        }
        while(customerMenuChoice !=0);
        
    }


    //Account Method
    static void accountMenu()
    {
        //variable to store customer menu choice
        int customerMenuChoice = -1;

        //do-while loop starts
        do
        {
            System.Console.WriteLine("\n:::Account menu:::");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2.Update Account");
            System.Console.WriteLine("3.Delete Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("Back to Main Menu");


            //accept customers menu choice
            System.Console.Write("Enter Choice:");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        }
        while (customerMenuChoice != 0);

    }
}