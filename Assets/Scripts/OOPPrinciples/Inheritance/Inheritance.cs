using UnityEngine;

namespace OOPPrinciples.Inheritance
{
    public class Inheritance : MonoBehaviour
    {
        // Ability to create new abstractions based on existing abstractions.

        private void Start()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.Yell();
            dog.Yell();
            cat.Yell();
        }
    }

    public class Animal
    {
        public virtual void Yell()
        {
            Debug.Log("I am an animal!");
        }
    }

    public class Dog : Animal
    {
        public override void Yell()
        {
            Debug.Log("I am a dog!");
        }
    }

    public class Cat : Animal
    {
        public override void Yell()
        {
            base.Yell();
            Debug.Log("I am a cat!");
        }
    }
}