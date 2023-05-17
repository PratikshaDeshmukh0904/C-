class Sample
{
    static void Main()
    {
        //create objects
        Product product1, product2;
        product1 = new Product();
        Product.TotalNoProduts++; //1
        product2 = new Product();
        Product.TotalNoProduts++; //2

        //initialize fields
        product1.SetProductID(1001);
        product1.setProductName("Mobile");
        product1.SetCost(12000);


        product2.SetProductID(1002);
        product2.setProductName("Laptop");
        product2.SetCost(32000);

        System.Console.WriteLine(product1.GetProductName());
        System.Console.WriteLine(product2.GetProductName());

        System.Console.WriteLine(product1.GetCost());
        System.Console.WriteLine(product2.GetCost());

        System.Console.WriteLine("Total No of Products" + Product.TotalNoProduts) //3


        System.Console.WriteLine("CategoryName" + Product.CategoryName); ;

        System.Console.WriteLine("Date of Purchase" + product1.GetDateOfPurchase());

        System.Console.WriteLine("Developer" + developerName);
        System.Console.ReadKey();

    }
}