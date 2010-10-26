using System;

namespace Refactored.TaxStrategies
{
    public class LousianaTaxCalculator : ICalculateTax
    {
        public decimal CalculateTax(decimal total)
        {
            Console.WriteLine("LA Taxes");
            return total > 10
                       ? total*.05m
                       : total*.02m;
        }
    }
}