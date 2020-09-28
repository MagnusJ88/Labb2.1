using System;
using System.Numerics;

namespace ShapeLib
{
    public class Triangle : Shape2D
    {
        private Vector2 p1, p2, p3;
        public Triangle(Vector2 P1, Vector2 P2, Vector2 P3)
        {
            p1 = P1;
            p2 = P2;
            p3 = P3;
        }

        public override Vector3 Center
        {
            get
            {
                Vector3 Tyngdpunkt = new Vector3(((p1.X + p2.X + p3.X) / 3f), ((p1.Y + p2.Y + p3.Y) / 3f), 0f);
                return Tyngdpunkt;
            }
        }
        public override float Area
        {
            get
            {
                return MathF.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2f;
            }
        }
        public override float Circumference
        {
            get
            {
                return Vector2.Distance(p1, p2) + Vector2.Distance(p2, p3) + Vector2.Distance(p3, p1);
            }
        }
        public override string ToString()
        {
            string output = $"triangle @({((p1.X + p2.X + p3.X) / 3f):0.0}, {((p1.Y + p2.Y + p3.Y) / 3f):0.0)}: p1({p1.X:0.0}, {p1.Y:0.0}), p2({p2.X:0.0}, {p2.Y:0.0}), p3({p3.X:0.0}, {p3.Y:0.0})";
            return output;
        }
    }
}

