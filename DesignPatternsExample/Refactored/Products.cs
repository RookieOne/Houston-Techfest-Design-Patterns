using System.Collections.Generic;
using System.Linq;

namespace Refactored
{
    internal static class Products
    {
        static Products()
        {
            _products = new List<Product>
                            {
                                new Product("1", "Red Apple", .10m),
                                new Product("2", "Loaf of Bread", 3m),
                                new Product("3", "Banana", .5m)
                            };
        }

        static readonly List<Product> _products;

        public static Product Find(string sku)
        {
            return _products.FirstOrDefault(p => p.Sku == sku);
        }
    }
}