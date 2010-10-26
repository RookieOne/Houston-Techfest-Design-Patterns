using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Original
{
    public interface ICommand
    {
        void Execute();
        bool ShouldContinue();
    }
}
