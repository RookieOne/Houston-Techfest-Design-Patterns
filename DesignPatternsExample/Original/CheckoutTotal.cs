namespace Original
{
    public class CheckoutTotal
    {
        public CheckoutTotal(decimal preTaxTotal)
        {
            PreTaxTotal = preTaxTotal;
        }

        public decimal PreTaxTotal { get; protected set; }
        public decimal Tax { get; protected set; }
        public decimal Total
        {
            get { return PreTaxTotal + Tax; }
        }

        public void CalculateTax(string state)
        {
            switch (state)
            {
                case "TX":
                    Tax = new TexasCalculator().CalculateTax(PreTaxTotal);
                    break;
                case "LA":
                    Tax = new LousianaCalculator().CalculateTax(PreTaxTotal);
                    break;
                case "OK":
                    Tax = new OklahomaCalculator().CalculateTax(PreTaxTotal);
                    break;
                default:
                    Tax = PreTaxTotal * .1m;
                    break;
            }
        }
    }
}