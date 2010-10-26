using System;
using Refactored.Commands;
using Refactored.Facades;
using Refactored.Scanners;

namespace Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var register = new CashRegister();

            var display = new DisplayOptions();
            display.AddChoice(new ChangeStateCommand(register));
            display.AddChoice(new EnterSkuCommand(register));
            var scanner = new NormalScanner();
            scanner.AddObserver(register);
            display.AddChoice(new ScannerCommand(scanner));
            display.AddChoice(new CheckoutCommand(register));
            display.MakeChoice();

            Console.WriteLine();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}