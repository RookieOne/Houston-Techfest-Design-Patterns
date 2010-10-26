using System;
using System.Collections.Generic;

namespace Original
{
    public class SkuEventArgs : EventArgs
    {
        public string Sku { get; set; }

        public SkuEventArgs(string sku)
        {
            Sku = sku;
        }
    }

    public interface IConsumeSkus
    {
        void SkuScanned(string sku);
    }

    public interface IScanner
    {
        void Scan();
        event EventHandler<SkuEventArgs> SkuScannedEvent;
    }

    public class Scanner :IScanner
    {
        public event EventHandler<SkuEventArgs> SkuScannedEvent;

        public void Scan()
        {
            Console.WriteLine("Scan?");
            var sku = Console.ReadLine();
            if (String.IsNullOrEmpty(sku))
                Console.WriteLine("Bad Scan");
            else
            {
                Console.WriteLine("* beep *");
                SkuScannedEvent(this, new SkuEventArgs(sku));
            }
        }
    }
}