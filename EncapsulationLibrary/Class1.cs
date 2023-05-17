

public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityStock;
    public static int totalNoProducts;
    public const string categoryName = "Electronics";
    public readonly string dateofPurchase;

    //Constructor
    public Product()
    {
        dateofPurchase = System.DateTime.Now.ToShortDateString();
    }


    //set method for productID
    public void SetProductID(int value)
    {
        productID = value;
    }

    //Get method for productID
    public int GetProductID()
    {
        return productID;
    }

    //set method for productName
    public void setProductName(string value)
    {
        productName = value;
    }
    //Get method for productname
    public string GetProductName()
    {
        return productName;
    }
    //Set method for cost
    public void SetCost(double value)
    {
        cost = value;
    }
    //Get Method for cost
    public double GetCost()
    {
        return cost;
    }
    //set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }
    //Get Method for tax
    public double GetTax()
    {
        return tax;
    }

    //Calculate Tax
    public void CalculateTax()
    {
        //create local variables
        double t;
        if (cost <= 20000)
        {
            t = cost * 10 / 1000;
        }
        else
        {
            t = cost * 12.5 / 100;
        }
        tax = t;
    }

    //set method for quantityInStock
    public void SetQuantityStock(int value)
    {
        quantityStock = value;
    }
    //get method for quantityInStock
    public int GetQuantityStock()
    {
        return quantityStock;
    }

    //Get method for date of purchase
    public string GetDateOfPurchase()
    {
        return dateofPurchase;
    }
}