using System;

namespace Original
{
    public class CreditCardService
    {
        public void Process(CreditCard creditCard, decimal amount)
        {
            Console.WriteLine("Process CC {0} : {1}", creditCard.Name, creditCard.Number);
            Console.WriteLine("Charged => {0}", amount);
        }
    }
}