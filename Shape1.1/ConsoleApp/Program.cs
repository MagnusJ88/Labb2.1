using ShapeLib;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                shapeList.Add(Shape.GenerateShape());
            }


        }
    }
}
