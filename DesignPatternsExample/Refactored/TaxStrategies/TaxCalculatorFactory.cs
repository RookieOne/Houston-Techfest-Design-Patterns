using System.Collections.Generic;

namespace Refactored.TaxStrategies
{
    public class TaxCalculatorFactory : ITaxCalculatorFactory
    {
        public TaxCalculatorFactory()
        {
            _calculators = new Dictionary<string, ICalculateTax>();
            _calculators.Add("TX", new TexasTaxCalculator());
            _calculators.Add("LA", new LousianaTaxCalculator());
            _calculators.Add("OK", new OklahomaTaxCalculator());
        }

        readonly Dictionary<string, ICalculateTax> _calculators;

        public ICalculateTax GetTaxCalculator(string state)
        {
            return _calculators.ContainsKey(state)
                       ? _calculators[state]
                       : new DefaultTaxCalculator();
        }
    }
}