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
            get => Circumference;
            set => Circumference = MathF.PI * (Radius * 2);
        }
        public override string ToString()
        {

            string output = $"circle @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): r = {Radius.ToString("0.0")}";
            return output;
        }
        public override float Area
        {
            get
            {
                float AreaCircle = MathF.PI * Radius * Radius;
                return AreaCircle;
            }

        }
    }
}
