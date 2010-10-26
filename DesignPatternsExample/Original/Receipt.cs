using System;
using System.Collections.Generic;

namespace Original
{
    public class Receipt
    {
        public Receipt(IEnumerable<Product> products, CheckoutTotal total)
        {
            _products = products;
            _total = total;
        }

        readonly IEnumerable<Product> _products;
        readonly CheckoutTotal _total;

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Awesome Grocery Store");
            Console.WriteLine("Checkout Date {0}", DateTime.Today);
            Console.WriteLine("=====================");

            foreach(var product in _products)
            {
                Console.WriteLine("{0}......{1}", product.Name, product.Price);
            }
            Console.WriteLine("PreTax = {0}", _total.PreTaxTotal);
            Console.WriteLine("Tax    = {0}", _total.Tax);
            Console.WriteLine("Total  = {0}", _total.Total);
        }
    }
}