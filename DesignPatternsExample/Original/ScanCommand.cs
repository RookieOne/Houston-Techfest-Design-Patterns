using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Original
{
    public class ScanCommand : ICommand
    {
        readonly IScanner _scanner;

        public ScanCommand(IScanner scanner)
        {
            _scanner = scanner;
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
