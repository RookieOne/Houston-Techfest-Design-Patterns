namespace Original
{
    public class CreditCard
    {
        public CreditCard(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Number { get; private set; }
        public string Name { get; private set; }
    }
}