namespace Bank.CommandControler
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}