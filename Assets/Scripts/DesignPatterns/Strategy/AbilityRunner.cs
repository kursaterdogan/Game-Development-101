using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class AbilityRunner : MonoBehaviour
    {
        [SerializeField] IAbility _currentAbility = new RageAbility();

        public void UseAbility()
        {
            _currentAbility.Use(gameObject);
        }
    }

    public interface IAbility
    {
        void Use(GameObject currentGameObject);
    }

    public class RageAbility : IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("I'm always angry");
        }
    }

    public class HealAbility : IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("Here eat this!");
        }
    }

    public class FireballAbility : IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("Launch Fireball");
        }
    }
}