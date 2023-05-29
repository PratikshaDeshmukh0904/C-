namespace ECommerce
{
    /// <summary>
    /// Represents a Product in Ecommerce application
    /// </summary>
    public class Product
    {
        //properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }    
        public double Price { get;set; }

        public DateTime DateOfManufacture { get; set; }
    }
}