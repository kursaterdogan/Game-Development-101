namespace DesignPatterns.Commander
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}