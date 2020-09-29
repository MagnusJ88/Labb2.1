using System.Numerics;

namespace ShapeLib
{
    public class Rectangle : Shape2D
    {
        private float _width;
        private Vector2 _size;
        private bool _isSquare = false;
        public Rectangle(Vector2 center, float width)
        {
            Center2D = center;
            _width = width;
            _isSquare = true;
        }
        public Rectangle(Vector2 center, Vector2 size)
        {
            Center2D = center;
            _size = size;
            if (size.X == size.Y)
            {
                _isSquare = true;
            }
        }
        public bool IsSquare
        {
            get => _isSquare;
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
                if (_width > 0)
                {
                    return _width * 4f;
                }
                else
                {
                    return (_size.X * 2f) + (_size.Y * 2f);
                }
            }
        }
        public override float Area
        {
            get
            {
                if (_width > 0)
                {
                    return _width * _width;
                }
                else
                {
                    return _size.X * _size.Y;
                }
            }
        }
        public override string ToString()
        {
            string output;
            if (IsSquare)
            {
                if (_width > 0)
                {
                    output = $"square @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {_width.ToString("0.0")}, h = {_width.ToString("0.0")}";
                    return output;
                }
                else
                {
                    output = $"square @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {_size.X.ToString("0.0")}, h = {_size.Y.ToString("0.0")}";
                    return output;
                }
            }
            else
            {
                output = $"rectangle @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {_size.X.ToString("0.0")}, h = {_size.Y.ToString("0.0")}";
                return output;
            }
        }
    }
}
