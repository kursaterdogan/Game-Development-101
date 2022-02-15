using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Commander
{
    public class Commander : MonoBehaviour
    {
        public static Commander SharedInstance { get; private set; }

        private Stack<ICommand> _pastCommands = new Stack<ICommand>();
        private Stack<ICommand> _futureCommands = new Stack<ICommand>();

        private void Awake()
        {
            SharedInstance = this;
        }

        public void AddCommand(ICommand command)
        {
            command.Execute();
            _pastCommands.Push(command);

            if (_futureCommands.Count > 0)
                _futureCommands.Clear();
        }

        public void Undo()
        {
            if (_pastCommands.Count == 0)
                return;

            ICommand command = _pastCommands.Pop();
            command.Undo();

            _futureCommands.Push(command);
        }

        public void Redo()
        {
            if (_futureCommands.Count == 0)
                return;

            ICommand command = _futureCommands.Pop();
            command.Execute();

            _pastCommands.Push(command);
        }
    }
}