using Refactored.Scanners;

namespace Refactored.Commands
{
    public class ScannerCommand : ICommand
    {
        public ScannerCommand(IScanner scanner)
        {
            _scanner = scanner;
        }

        readonly IScanner _scanner;

        public string GetText()
        {
            return "Use Scanner";
        }

        public void Execute()
        {
            _scanner.Scan();
        }

        public bool ShouldContinue()
        {
            return true;
        }
    }
}