using System;
using System.Collections.Generic;
using System.Linq;

namespace Original
{
    public class CashRegister : IConsumeSkus
    {
        public CashRegister(string state)
        {
            _state = state;
            _checkout_products = new List<Product>();
            _total = null;
            _creditCardService = new CreditCardService();
        }

        protected readonly List<Product> _checkout_products;
        readonly string _state;
        CheckoutTotal _total;
        CreditCardService _creditCardService;

        public void EnterSku(string sku)
        {
            var product = Products.Find(sku);
            if (product == null)
            {
                Console.WriteLine("Bad SKU / Product not found");
            }
            else
            {
                _checkout_products.Add(product);
            }
        }

        public CheckoutTotal CheckOut()
        {
            var preTaxTotal = _checkout_products.Sum(p => p.Price);
            _total = new CheckoutTotal(preTaxTotal);
            _total.CalculateTax(_state);
            return _total;
        }

        public Receipt Pay(decimal cash, out decimal change)
        {
            change = cash - _total.Total;
            return new Receipt(_checkout_products, _total);
        }

        public Receipt PayWithCreditCard(CreditCard creditCard)
        {
            _creditCardService.Process(creditCard, _total.Total);
            return new Receipt(_checkout_products, _total);
        }

        public void SkuScanned(string sku)
        {
            EnterSku(sku);
        }
    }
}