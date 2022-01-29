using UnityEngine;

namespace OOPPrinciples.Encapsulation
{
    public class Encapsulation : MonoBehaviour
    {
        // Hiding the internal state and functionality of an object
        // and only allowing access through a public set of functions.

        private void Start()
        {
            Foo foo = new Foo();

            foo.SetName("Boo");
            Debug.Log(foo.GetName());
        }
    }

    public class Foo
    {
        private string _name;

        public void SetName(string name)
        {
            // Conditions
            _name = name;
        }

        public string GetName()
        {
            // Conditions
            return _name;
        }
    }
}