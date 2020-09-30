using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLib
{
    public class Sphere : Shape3D
    {
        private float _radius;
        private Vector3 _center;
        public Sphere(Vector3 center, float radius)
        {
            _radius = radius;
            _center = center;
        }
        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }
        public override float Volume
        {
            get
            {
                return 4.0f * MathF.PI * MathF.Pow(_radius, 3.0f) / 3.0f;
            }
        }
        public override float Area
        {
            get
            {
                return 4f * MathF.PI * MathF.Pow(_radius, 2.0f);
            }
        }
        public override string ToString()
        {
            string output = $"sphere @({ _center.X:0.0}, { _center.Y:0.0}, { _center.Z:0.0}): r = {_radius:0.0}";
            return output;
        }
    }
}
