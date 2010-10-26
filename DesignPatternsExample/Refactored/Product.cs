namespace Refactored
{
    public class Product
    {
        public Product(string sku, string name, decimal price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }

        public string Sku { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}