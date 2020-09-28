using System;
using System.Numerics;

namespace ShapeLib
{
    public class Circle : Shape2D
    {
        private float Radius;

        public Circle(Vector2 center, float radius)
        {
            Center2D = center;
            Radius = radius;
        }
        public override Vector3 Center
        {

            get
            {
                Vector3 CenterTemp = new Vector3(Center2D, 0f);
                return CenterTemp;
            }

        }
        public override float Circumference
        {
            get
            {
                return 2 * MathF.PI * Radius;
            }
        }
        public override float Area
        {
            get
            {
                return MathF.PI * (Radius * Radius);
            }

        }
        public override string ToString()
        {

            string output = $"circle @({Center2D.X:0.0}, {Center2D.Y:0.0}): r = {Radius:0.0}";
            return output;
        }
    }
}
