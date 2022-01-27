using UnityEngine;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class SingleResponsibility : MonoBehaviour
    {
        // A class should have one and only one reason to change, meaning that a class should have only one job.

        private void Start()
        {
            Square square = new Square(5);
            Circle circle = new Circle(3);

            AreaCalculator areaCalculator = new AreaCalculator();

            Debug.Log("Area = " + areaCalculator.CalculateArea(square));
            Debug.Log("Area = " + areaCalculator.CalculateArea(circle));
        }
    }

    public abstract class Shape
    {
    }

    public class Square : Shape
    {
        private float _length;

        public Square(float length)
        {
            _length = length;
        }

        public float GetLength()
        {
            return _length;
        }
    }

    public class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public float GetRadius()
        {
            return _radius;
        }
    }

    public class AreaCalculator
    {
        public float CalculateArea(Shape shape)
        {
            switch (shape)
            {
                case Square square:
                    return Mathf.Pow(square.GetLength(), 2);
                case Circle circle:
                    return Mathf.PI * Mathf.Pow(circle.GetRadius(), 2);
                default:
                    return 0;
            }
        }
    }
}