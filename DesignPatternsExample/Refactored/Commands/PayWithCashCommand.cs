using System;

namespace Refactored.Commands
{
    public class PayWithCashCommand : ICommand
    {
        public PayWithCashCommand(CashRegister cashRegister)
        {
            _cashRegister = cashRegister;
        }

        readonly CashRegister _cashRegister;

        public string GetText()
        {
            return "Pay with Cash";
        }

        public void Execute()
        {
            Console.WriteLine("Amount Paid?");
            var payment = Convert.ToDecimal(Console.ReadLine());

            decimal change;
            var receipt = _cashRegister.Pay(payment, out change);
            receipt.Print();

            Console.WriteLine("Change = {0}", change);
        }

        public bool ShouldContinue()
        {
            return false;
        }
    }
}