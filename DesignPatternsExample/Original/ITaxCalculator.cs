using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Original
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal pretaxtotal);
    }

    public class TexasCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal pretaxtotal)
        {
            return pretaxtotal * .08m;
        }
    }

    public class LousianaCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal pretaxtotal)
        {
            return pretaxtotal > 10
                       ? pretaxtotal*.05m
                       : pretaxtotal*.02m;
        }
    }


    public class OklahomaCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal pretaxtotal)
        {
            var amountToTax = pretaxtotal - 5;
            if (amountToTax > 0)
                return amountToTax * .15m;
            return 0;
        }
    }
}
