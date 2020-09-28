using System;
using System.Numerics;

namespace ShapeLib
{
    public class Triangle : Shape2D
    {
        Vector2 p1; //= new Vector2(3.0f, 1.0f);
        Vector2 p2; //= new Vector2(0.0f, 0.0f);
        Vector2 p3; //= new Vector2(6.0f, 0.0f);
        public Triangle(Vector2 center)
        {
            float Tyngdpunkt = ((p1.X + p2.X + p3.X) + (p1.Y + p2.Y + p3.Y)) / 3f;
        }
        public override float Area => MathF.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2f;
        public override Vector3 Center 
        {
            get
            {
                Vector3 CenterTemp = new Vector3(Center2D, 0f);
                return CenterTemp;

            }
        }
        public override float Circumference // p1=>p2 + p2=>p3 + p3=>p1
        {
            get => Circumference;
            set
            {
                //p1=>p3
                float AC = p3.X - p1.X;
                //p2=>p3
                float BC = p2.Y - p3.Y;
                //d2=(AC)2+(BC)2
                float hypotenusa = (AC * AC) + (BC * BC);
                //d = sqrt(d2)
                Circumference = MathF.Sqrt(hypotenusa);
                return;
            }
        }

    }
    public override string ToString()
    {

    }

}

