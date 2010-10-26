using System;
using System.Collections.Generic;
using System.Linq;
using Refactored.Scanners;

namespace Refactored
{
    public class CashRegister : IConsumeSkus
    {
        public CashRegister()
        {
            _checkoutProducts = new List<Product>();
            _total = null;
        }

        readonly List<Product> _checkoutProducts;
        string _state = "TX";
        CheckoutTotal _total;

        public void ConsumeSku(string sku)
        {
            EnterSku(sku);
        }

        public void SetState(string state)
        {
            _state = state;
        }

        public void EnterSku(string sku)
        {
            var product = Products.Find(sku);
            if (product == null)
            {
                Console.WriteLine("Bad SKU / Product not found");
            }
            else
            {
                _checkoutProducts.Add(product);
            }
        }

        public CheckoutTotal CheckOut()
        {
            var preTaxTotal = _checkoutProducts.Sum(p => p.Price);
            _total = new CheckoutTotal(preTaxTotal);
            _total.CalculateTax(_state);
            return _total;
        }

        public Receipt Pay(decimal cash, out decimal change)
        {
            change = cash - _total.Total;
            return new Receipt(_checkoutProducts, _total);
        }
    }
}