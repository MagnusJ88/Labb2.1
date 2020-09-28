using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLib
{

    public abstract class Shape2D : Shape
    {
        public abstract float Circumference { get; }
        public Vector2 Center2D { get; set; }
    }
}
