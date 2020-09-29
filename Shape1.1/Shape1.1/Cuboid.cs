using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLib
{
    public class Cuboid : Shape3D
    {
        private bool _isCube = false;
        private Vector3 _center;
        private Vector3 _size;
        private float _width;
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
            if (size.X == size.Y && size.Y == size.Z)
            {
                _isCube = true;
            }
        }
        public Cuboid(Vector3 center, float width)
        {
            _isCube = true;
            _center = center;
            _width = width;
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
                if (_width > 0)
                {
                    return MathF.Pow(_width, 3);
                }
                else
                {
                    return _size.X * _size.Y * _size.Z;
                }
            }
        }
        public override float Area
        {
            get
            {
                if (_width > 0)
                {
                    return 6f * _width * _width;
                }
                else
                {
                    return 2f * ((_size.X * _size.Y) + (_size.X * _size.Z) + (_size.Y * _size.Z));
                }
            }
        }
        public override string ToString()
        {
            string output;
            if (_isCube)
            {
                if (_width > 0)
                {
                    output = $"cube @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): w = {_width:0.0}, h = {_width:0.0}, l = {_width:0.0}";
                    return output;
                }
                else
                {
                    output = $"cube @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): w = {_size.X:0.0}, h = {_size.Y:0.0}, l = {_size.Z:0.0}";
                    return output;
                }
            }
            else
            {
                output =  $"cuboid @({ _center.X:0.0}, { _center.Y:0.0}, { _center.Z:0.0}): w = { _size.X:0.0}, h = { _size.Y:0.0}, l = { _size.Z:0.0}";
                return output;
            }
        }
    }
}
