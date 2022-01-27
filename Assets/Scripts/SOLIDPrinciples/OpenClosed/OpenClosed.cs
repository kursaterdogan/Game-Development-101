using UnityEngine;

namespace SOLIDPrinciples.OpenClosed
{
    public class OpenClosed : MonoBehaviour
    {
        // Software entities (classes, modules, functions, components, etc.)
        // should be open for extension, but closed for modifications.

        private void Start()
        {
            Square square = new Square(5);
            Circle circle = new Circle(3);

            Debug.Log("Area = " + square.GetArea());
            Debug.Log("Area = " + circle.GetArea());
        }
    }

    public abstract class Shape
    {
        public abstract float GetArea();
    }

    public class Square : Shape
    {
        private float _length;

        public Square(float length)
        {
            _length = length;
        }

        public override float GetArea()
        {
            return Mathf.Pow(_length, 2);
        }
    }

    public class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float GetArea()
        {
            return Mathf.PI * Mathf.Pow(_radius, 2);
        }
    }
}