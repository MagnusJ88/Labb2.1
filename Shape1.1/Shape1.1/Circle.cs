using System;
using System.Numerics;

namespace ShapeLib
{
    public class Circle : Shape2D
    {
        private float _radius;
        public Circle(Vector2 center, float radius)
        {
            Center2D = center;
            _radius = radius;
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
                return 2 * MathF.PI * _radius;
            }
        }
        public override float Area
        {
            get
            {
                return MathF.PI * (_radius * _radius);
            }
        }
        public override string ToString()
        {
            string output = $"circle @({Center2D.X:0.0}, {Center2D.Y:0.0}): r = {_radius:0.0}";
            return output;
        }
    }
}
