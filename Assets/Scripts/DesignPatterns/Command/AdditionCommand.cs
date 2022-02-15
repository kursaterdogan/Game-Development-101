using UnityEngine;

namespace DesignPatterns.Command
{
    public class AdditionCommand : ICommand
    {
        private readonly int _randomNumber;

        public AdditionCommand()
        {
            _randomNumber = Random.Range(1, 100);
        }

        public void Execute()
        {
            NumberController.SharedInstance.Add(_randomNumber);
        }

        public void Undo()
        {
            NumberController.SharedInstance.Subtract(_randomNumber);
        }
    }
}