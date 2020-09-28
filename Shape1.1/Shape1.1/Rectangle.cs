using System.Numerics;

namespace ShapeLib
{
    public class Rectangle : Shape2D
    {
        private float Width;
        private Vector2 Size;
        private bool _IsSquare = false;

        public Rectangle(Vector2 center, float width)
        {
            Center2D = center;
            Width = width;
            _IsSquare = true;
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            Center2D = center;
            Size = size;
            if (size.X == size.Y)
            {
                _IsSquare = true;
            }
        }

        public bool IsSquare
        {
            get => _IsSquare;
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
                if (Width > 0)
                {
                    return Width * 4f;
                }
                else
                {
                    return (Size.X * 2f) + (Size.Y * 2f);
                }
            }
        }
        public override float Area
        {
            get
            {
                if (Width > 0)
                {
                    return Width * Width;
                }
                else
                {
                    return Size.X * Size.Y;
                }
            }

        }
        public override string ToString()
        {
            string output;
            if (IsSquare)
            {
                if (Width > 0)
                {
                    output = $"square @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {Width.ToString("0.0")}, h = {Width.ToString("0.0")}";
                    return output;
                }
                else
                {
                    output = $"square @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {Size.X.ToString("0.0")}, h = {Size.Y.ToString("0.0")}";
                    return output;
                }
            }
            else
            {
                output = $"rectangle @({Center2D.X.ToString("0.0")}, {Center2D.Y.ToString("0.0")}): w = {Size.X.ToString("0.0")}, h = {Size.Y.ToString("0.0")}";
                return output;
            }
        }
    }
}
