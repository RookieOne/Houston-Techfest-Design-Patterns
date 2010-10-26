using System;

namespace Refactored.TaxStrategies
{
    public class DefaultTaxCalculator : ICalculateTax
    {
        public decimal CalculateTax(decimal total)
        {
            Console.WriteLine("Default Taxes");
            return total*.1m;
        }
    }
}