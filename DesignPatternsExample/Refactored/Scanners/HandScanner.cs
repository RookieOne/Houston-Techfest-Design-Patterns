using System;

namespace Refactored.Scanners
{
    public class HandScanner : IScanner
    {
        IConsumeSkus _observer;

        public void Scan()
        {
            Console.WriteLine("Hand Scan?");
            var sku = Console.ReadLine();
            if (String.IsNullOrEmpty(sku))
                Console.WriteLine("Bad Scan");
            else
            {
                _observer.ConsumeSku(sku);
                Console.WriteLine("* boop *");
            }
        }

        public void AddObserver(IConsumeSkus observer)
        {
            _observer = observer;
        }
    }
}