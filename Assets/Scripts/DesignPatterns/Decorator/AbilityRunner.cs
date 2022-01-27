using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class AbilityRunner : MonoBehaviour
    {
        [SerializeField] IAbility _currentAbility = new DelayedDecorator(new RageAbility());

        public void UseAbility()
        {
            _currentAbility.Use(gameObject);
        }
    }

    public interface IAbility
    {
        void Use(GameObject currentGameObject);
    }

    public class DelayedDecorator : IAbility
    {
        private IAbility _wrappedAbility;

        public DelayedDecorator(IAbility wrappedAbility)
        {
            _wrappedAbility = wrappedAbility;
        }

        public void Use(GameObject currentGameObject)
        {
            // Some delaying functionality
            _wrappedAbility.Use(currentGameObject);
        }
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