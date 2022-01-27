using System.Collections.Generic;
using UnityEngine;

namespace SOLIDPrinciples.LiskovSubstitution
{
    public class LiskovSubstitution : MonoBehaviour
    {
        // Subtypes must be behaviorally substitutable for their base types.

        private void Start()
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            List<Rectangle> rectangles = new List<Rectangle> { rectangle, square };

            foreach (var r in rectangles)
            {
                r.SetHeight(10);
                r.SetWidth(7);

                Debug.Log("Area = " + r.GetArea());
            }
        }
    }


    public class Rectangle
    {
        protected float Height;
        protected float Width;

        public virtual void SetHeight(float height)
        {
            Height = height;
        }

        public virtual void SetWidth(float width)
        {
            Width = width;
        }

        public float GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override void SetHeight(float height)
        {
            Height = height;
            Width = height;
        }

        public override void SetWidth(float width)
        {
            Width = width;
            Height = width;
        }
    }
}