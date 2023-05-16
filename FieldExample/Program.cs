using System.Net.Http.Headers;

class Sample
{
    static void Main()
    {
        //create objects
        Product product1 , product2 ;
        product1 = new Product();
        Product.TotalNoProduts++; //1
        product2 = new Product();
        Product.TotalNoProduts++; //2

        //initialize fields
        product1.productId = 1001;
        product1.productName = "Mobile";
        product1.cost = 12000;


        product2.productId = 1002;
        product2.productName = "Laptop";
        product2.cost = 32000;

        System.Console.WriteLine(product1.productName);
        System.Console.WriteLine(product2.productName);

        System.Console.WriteLine(product1.cost);
        System.Console.WriteLine(product2.cost);

        System.Console.WriteLine("Total No of Products"+Product.TotalNoProduts) //3
        
        System.Console.WriteLine("CategoryName"+Product.CategoryName); ;

        System.Console.WriteLine("Date of Purchase" + product1.dateofPurchase);

        System.Console.WriteLine("Developer" + developerName);
        System.Console.ReadKey();

    }
}
public class InternationalProduct : Product
{

    public void Method1()
    {
       productId = 1;    //not valid
       productName = "abc"; // accessible
        cost = 2000;//not valid
        quantityStock = 10;// not accessible
        priceStock = 10;//accessible
        productLocation = "Kadegoan";//accessible
    }
}
public class OtherClass2
{
    public void Method1()
    {
        Product product = new Product();
        product.productId;    //not valid
        product.productName = "abc"; // not accessible
        product.cost = 2000;//not valid
        product.quantityStock = 10;//not valid
        product.priceStock = 10; //not accessible
        product.productLocation = "Kadegoan"; //accessible

    }

}