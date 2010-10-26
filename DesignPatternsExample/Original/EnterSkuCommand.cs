using System;

namespace Original
{
    public class EnterSkuCommand :ICommand
    {
        readonly CashRegister _register;

        public EnterSkuCommand(CashRegister register)
        {
            _register = register;
        }
        
        public void Execute()
        {
            Console.WriteLine("Enter Sku?");
            var sku = Console.ReadLine();
            _register.EnterSku(sku);
        }

        public bool ShouldContinue()
        {
            return true;
        }
    }


}