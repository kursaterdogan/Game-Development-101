using UnityEngine;

namespace OOPPrinciples.Abstraction
{
    public class Abstraction : MonoBehaviour
    {
        // Enables large systems to be built without increasing the complexity of code and understanding.

        private void Start()
        {
            GameFactory gameFactory = new GameFactory();

            gameFactory.MakeGame("Love of Wisdom");
        }
    }

    public class GameFactory
    {
        public void MakeGame(string gameName)
        {
            CreateStory();
            CreateDesign();
            CreateCode();
            CreateArt();
            CreateAudio();

            Debug.Log(gameName + " created.");
        }

        private void CreateStory()
        {
            Debug.Log("Create Story!");
        }

        private void CreateDesign()
        {
            Debug.Log("Create Design!");
        }

        private void CreateCode()
        {
            Debug.Log("Create Code!");
        }

        private void CreateArt()
        {
            Debug.Log("Create Art!");
        }

        private void CreateAudio()
        {
            Debug.Log("Create Audio!");
        }
    }
}