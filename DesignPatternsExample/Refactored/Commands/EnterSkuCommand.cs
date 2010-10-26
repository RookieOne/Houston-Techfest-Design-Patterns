using System;

namespace Refactored.Commands
{
    public class EnterSkuCommand : ICommand
    {
        public EnterSkuCommand(CashRegister cashRegister)
        {
            _cashRegister = cashRegister;
        }

        readonly CashRegister _cashRegister;

        public string GetText()
        {
            return "Enter Sku";
        }

        public void Execute()
        {
            Console.WriteLine("Enter Sku?");
            var sku = Console.ReadLine();
            _cashRegister.EnterSku(sku);
        }

        public bool ShouldContinue()
        {
            return true;
        }
    }
}