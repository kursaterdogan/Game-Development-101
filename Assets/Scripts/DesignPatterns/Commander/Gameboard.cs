using UnityEngine;

namespace DesignPatterns.Commander
{
    public class Gameboard : MonoBehaviour
    {
        public void Add()
        {
            Commander.SharedInstance.AddCommand(new AdditionCommand());
        }

        public void Multiply()
        {
            Commander.SharedInstance.AddCommand(new MultiplicationCommand());
        }

        public void Undo()
        {
            Commander.SharedInstance.Undo();
        }

        public void Redo()
        {
            Commander.SharedInstance.Redo();
        }
    }
}