using System;
using System.Collections.Generic;
using Bank.CommandControler;

namespace Bank.Commands
{
    public class CommandProcessor
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commands.Push(command);
        }

        public void UndoCommand()
        {
            var command = commands.Pop();
            Console.WriteLine($"Undoing command: {command.GetType().Name}");
            command.Undo();
        }
    }
}