using System;
using System.Numerics;

namespace ShapeLib
{
    public class Triangle : Shape2D
    {
        private Vector2 _p1, _p2, _p3;
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;
        }
        public override Vector3 Center
        {
            get
            {
                Vector3 center = new Vector3((_p1.X + _p2.X + _p3.X) / 3f, (_p1.Y + _p2.Y + _p3.Y) / 3f, 0f);
                return center;
            }
        }
        public override float Area
        {
            get
            {
                return MathF.Abs(_p1.X * (_p2.Y - _p3.Y) + _p2.X * (_p3.Y - _p1.Y) + _p3.X * (_p1.Y - _p2.Y)) / 2f;
            }
        }
        public override float Circumference
        {
            get
            {
                return Vector2.Distance(_p1, _p2) + Vector2.Distance(_p2, _p3) + Vector2.Distance(_p3, _p1);
            }
        }
        public override string ToString()
        {
            string output = $"triangle @({((_p1.X + _p2.X + _p3.X) / 3f):0.0}, {((_p1.Y + _p2.Y + _p3.Y) / 3f):0.0)}: p1({_p1.X:0.0}, {_p1.Y:0.0}), p2({_p2.X:0.0}, {_p2.Y:0.0}), p3({_p3.X:0.0}, {_p3.Y:0.0})";
            return output;
        }
    }
}

