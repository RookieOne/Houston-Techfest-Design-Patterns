namespace Refactored.Commands
{
    public interface ICommand
    {
        string GetText();
        void Execute();
        bool ShouldContinue();
    }
}