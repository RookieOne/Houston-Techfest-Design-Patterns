using System;

namespace Original
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter State?");
            var state = Console.ReadLine();

            var register = new CashRegister(state);
            var scanner = new WalmartAdapter(new WalmartScanner());
            scanner.SkuScannedEvent += (sender, a) => register.EnterSku(a.Sku);

            var displayOptions = new DisplayOptions();
            displayOptions.AddChoice("Enter Sku", new EnterSkuCommand(register));
            displayOptions.AddChoice("Scan Item", new ScanCommand(scanner));
            displayOptions.AddChoice("Checkout", new CheckoutCommand(register));
            displayOptions.MakeChoice();

            Console.WriteLine();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}