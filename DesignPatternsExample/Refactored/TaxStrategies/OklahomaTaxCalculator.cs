using System;

namespace Refactored.TaxStrategies
{
    public class OklahomaTaxCalculator : ICalculateTax
    {
        public decimal CalculateTax(decimal total)
        {
            Console.WriteLine("OK Taxes");

            var amountToTax = total - 5;

            return amountToTax > 0
                       ? amountToTax*.15m
                       : 0;
        }
    }
}