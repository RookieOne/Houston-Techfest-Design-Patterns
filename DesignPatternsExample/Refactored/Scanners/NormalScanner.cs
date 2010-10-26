using System;

namespace Refactored.Scanners
{
    public class NormalScanner : IScanner
    {
        IConsumeSkus _observer;

        public void Scan()
        {
            Console.WriteLine("Scan?");
            var sku = Console.ReadLine();
            if (String.IsNullOrEmpty(sku))
                Console.WriteLine("Bad Scan");
            else
            {
                _observer.ConsumeSku(sku);
                Console.WriteLine("* beep *");
            }
        }

        public void AddObserver(IConsumeSkus observer)
        {
            _observer = observer;
        }
    }
}