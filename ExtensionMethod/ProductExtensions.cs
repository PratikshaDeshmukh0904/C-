using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodLibrary;

namespace ExtensionNamespace
{
    //static class for extension method
    public static class ProductExtensions
    {
        //extension method for Product class
        public static double GetDiscount(this Product product)
        {
            return product.ProductCost * product.DiscountPercentage / 100;
        }
    }
}
