using System;
using Refactored.Facades;

namespace Refactored.Commands
{
    public class CheckoutCommand : ICommand
    {
        public CheckoutCommand(CashRegister cashRegister)
        {
            _cashRegister = cashRegister;
        }

        readonly CashRegister _cashRegister;

        public string GetText()
        {
            return "Checkout";
        }

        public void Execute()
        {
            var total = _cashRegister.CheckOut();
            Console.WriteLine("Amount owed  = {0}", total.Total);

            var paymentDisplay = new DisplayOptions();
            paymentDisplay.AddChoice(new PayWithCashCommand(_cashRegister));
            paymentDisplay.MakeChoice();
        }

        public bool ShouldContinue()
        {
            return false;
        }
    }
}