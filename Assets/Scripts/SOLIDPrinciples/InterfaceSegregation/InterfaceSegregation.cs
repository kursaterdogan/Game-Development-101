using UnityEngine;

namespace SOLIDPrinciples.InterfaceSegregation
{
    public class InterfaceSegregation : MonoBehaviour
    {
        // Clients should not be forced to depend on methods that they do not use.

        private void Start()
        {
            Square square = new Square(10);
            Cube cube = new Cube(10);

            Debug.Log("Area = " + square.GetArea());
            Debug.Log("Volume = " + cube.GetVolume());
        }
    }

    public interface ITwoDimensionalShape
    {
        float GetArea();
    }

    public interface IThreeDimensionalShape
    {
        float GetVolume();
    }

    public class Square : ITwoDimensionalShape
    {
        private float _length;

        public Square(float length)
        {
            _length = length;
        }

        public float GetArea()
        {
            return Mathf.Pow(_length, 2);
        }
    }

    public class Cube : IThreeDimensionalShape
    {
        private float _length;

        public Cube(float length)
        {
            _length = length;
        }

        public float GetVolume()
        {
            return Mathf.Pow(_length, 3);
        }
    }
}