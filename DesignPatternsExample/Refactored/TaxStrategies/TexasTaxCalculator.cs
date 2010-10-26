using System;

namespace Refactored.TaxStrategies
{
    public class TexasTaxCalculator : ICalculateTax
    {
        public decimal CalculateTax(decimal total)
        {
            Console.WriteLine("TX Taxes");
            return total*.08m;
        }
    }
}