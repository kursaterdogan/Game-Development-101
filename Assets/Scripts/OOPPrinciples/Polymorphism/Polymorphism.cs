using UnityEngine;
using Object = System.Object;

namespace OOPPrinciples.Polymorphism
{
    public class Polymorphism : MonoBehaviour
    {
        // Ability to implement inherited properties or methods in different ways across multiple abstractions.

        private void Start()
        {
            // Not every Animal is a Cat.
            // Cat cat = new Animal();

            Upcasting();
            Downcasting();
            ReferenceToWrongSubtype();
            AnimalsArray();
        }

        private void Downcasting()
        {
            // Downcasting extends methods and attributes available to this object.

            Animal animal = new Cat();
            ((Cat)animal).Meow();
        }

        private void Upcasting()
        {
            // Upcasting narrows methods and attributes available to this object. 

            Cat cat = new Cat();
            Animal animal = cat;
            animal.Eat();
        }

        private void ReferenceToWrongSubtype()
        {
            Object o = new Animal();
            ((Animal)o).Eat();

            // It is legal to cast a reference to the wrong subtype; 
            // However, this will compile but crash when the program runs.
            // ((Cat)o).Eat();
            // ((Cat)o).Meow();
        }

        private void AnimalsArray()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            // We can use different subclasses as the same base class.
            Animal[] animals = { dog, cat };

            foreach (Animal animal in animals)
            {
                animal.Eat();
            }
        }
    }

    public class Animal
    {
        public virtual void Eat()
        {
            Debug.Log("Animal is eating!");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.Log("Dog is eating!");
        }

        public void Bark()
        {
            Debug.Log("BARK!");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Debug.Log("Cat is eating!");
        }

        public void Meow()
        {
            Debug.Log("MEOW!");
        }
    }
}