using System;

namespace Original
{
    public class CheckoutCommand : ICommand
    {
        readonly CashRegister _register;

        public CheckoutCommand(CashRegister register)
        {
            _register = register;
        }

        public void Execute()
        {
            var total = _register.CheckOut();

            Console.WriteLine("Amount owed  = {0}", total.Total);
            Console.WriteLine("Pay?");

            Console.WriteLine("1 : Cash");
            Console.WriteLine("2 : Credit Card");
            var paymentChoice = Console.ReadLine();

            Receipt receipt = null;

            switch (paymentChoice)
            {
                case "1":
                    Console.WriteLine("How much?");
                    var payment = Convert.ToDecimal(Console.ReadLine());

                    decimal change;
                    receipt = _register.Pay(payment, out change);
                    receipt.Print();

                    Console.WriteLine("Change = {0}", change);
                    break;
                case "2":
                    Console.WriteLine("Name on credit card?");
                    var name = Console.ReadLine();
                    Console.WriteLine("Number on credit card?");
                    var number = Console.ReadLine();
                    var card = new CreditCard(name, number);
                    receipt = _register.PayWithCreditCard(card);
                    break;
            }
            receipt.Print();
        }

        public bool ShouldContinue()
        {
            return false;
        }
    }
}