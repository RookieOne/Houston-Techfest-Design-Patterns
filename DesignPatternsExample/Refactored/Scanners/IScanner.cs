namespace Refactored.Scanners
{
    public interface IScanner
    {
        void Scan();
        void AddObserver(IConsumeSkus observer);
    }

    public interface IConsumeSkus
    {
        void ConsumeSku(string sku);
    }
}