using System;

namespace Refactored.Commands
{
    public class ChangeStateCommand : ICommand
    {
        public ChangeStateCommand(CashRegister cashRegister)
        {
            _cashRegister = cashRegister;
        }

        readonly CashRegister _cashRegister;

        public string GetText()
        {
            return "Change State";
        }

        public void Execute()
        {
            Console.WriteLine("Enter State?");
            var state = Console.ReadLine();
            _cashRegister.SetState(state);
        }

        public bool ShouldContinue()
        {
            return true;
        }
    }
}