namespace Refactored.TaxStrategies
{
    public interface ITaxCalculatorFactory
    {
        ICalculateTax GetTaxCalculator(string state);
    }
}