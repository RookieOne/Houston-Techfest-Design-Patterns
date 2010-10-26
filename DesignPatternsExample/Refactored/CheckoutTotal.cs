using Refactored.TaxStrategies;

namespace Refactored
{
    public class CheckoutTotal
    {
        public CheckoutTotal(decimal preTaxTotal)
        {
            PreTaxTotal = preTaxTotal;
        }

        readonly ITaxCalculatorFactory _calculatorFactory = new TaxCalculatorFactory();

        public decimal PreTaxTotal { get; private set; }
        public decimal Tax { get; private set; }

        public decimal Total
        {
            get { return PreTaxTotal + Tax; }
        }

        public void CalculateTax(string state)
        {
            var calculator = _calculatorFactory.GetTaxCalculator(state);
            Tax = calculator.CalculateTax(PreTaxTotal);
        }
    }
}