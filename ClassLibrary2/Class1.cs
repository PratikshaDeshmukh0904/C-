using System.Security.Cryptography.X509Certificates;

public class Product
{
    
    private int productId;
    protected string productName;
    private protected double cost;
    internal int quantityStock;
    protected internal double priceStock;
    public string productLocation;

    //Static Field
    public static int TotalNoProduts;

    //Constatnt Field
    public const string CategoryName = "Electronics";

    //ReadOnly Field
    public readonly string dateofPurchase;

    //Local Variable
    const string developerName="Pratiksha";

    //Constructor
    public Product()
    {
        dateofPurchase=System.DateTime.Now.ToShortDateString();
    }
}


public class DomesticProduct:Product
{
    public void Method1()
    {
        productId//not valid
        productName="abc"; //accessible
        cost=0.0;//accessible
        quantityStock = 10;//accessible
        priceStock= 10; //accessible
        productLocation = "Kadegoan"; //accessible

        //Static Field directly accessible in same class 
        TotalNoProduts = 0;


        //ReadOnly Field



    }
}
public class OtherClass
{

    public void Method1()
    {
        Product product= new Product();
        product.productId;    //not valid
        product.productName = "abc"; // not accessible
        product.cost = 2000;//not valid
        product.quantityStock = 10; //accessible
        product.priceStock = 10; //accessible
        product.productLocation = "Kadegoan"; //accessible

        
    }
}