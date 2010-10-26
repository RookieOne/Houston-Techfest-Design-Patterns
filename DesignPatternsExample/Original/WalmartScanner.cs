using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Original
{
    public class WalmartAdapter : IScanner
    {
        public WalmartScanner Scanner { get; set; }

        public WalmartAdapter(WalmartScanner scanner)
        {
            Scanner = scanner;
        }

        public void Scan()
        {
            var sku = Scanner.SuperCoolScan();
            SkuScannedEvent(this, new SkuEventArgs(sku));
        }

        public event EventHandler<SkuEventArgs> SkuScannedEvent;
    }

    public class WalmartScanner
    {
        public string SuperCoolScan()
        {
            
        }
    }
}
