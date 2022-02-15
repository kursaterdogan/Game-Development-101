using UnityEngine;

namespace DesignPatterns.Commander
{
    public class MultiplicationCommand : ICommand
    {
        private readonly int _randomNumber;

        public MultiplicationCommand()
        {
            _randomNumber = Random.Range(2, 11);
        }

        public void Execute()
        {
            NumberController.SharedInstance.Multiply(_randomNumber);
        }

        public void Undo()
        {
            NumberController.SharedInstance.Divide(_randomNumber);
        }
    }
}