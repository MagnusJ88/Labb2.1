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
            float totalCircumferenceTriangle = 0f;
            float totalArea = 0f;
            float maxVolume = 0f;
            int indexOfMaxVolume = 0;

            for (int i = 0; i < 20; i++)
            {
                shapeList.Add(Shape.GenerateShape());
                Console.WriteLine(shapeList[i]);
                if (shapeList[i] is Triangle)
                {
                    totalCircumferenceTriangle += (shapeList[i] as Triangle).Circumference;
                }
                totalArea += shapeList[i].Area;
                if (shapeList[i] is Shape3D)
                {
                    if ((shapeList[i] as Shape3D).Volume > maxVolume)
                    {
                        maxVolume = (shapeList[i] as Shape3D).Volume;
                        indexOfMaxVolume = i;
                    }
                }

            }
            Console.WriteLine($"The total circumference of all triangles in the list is: {totalCircumferenceTriangle:0.0}");
            Console.WriteLine($"The average area of all shapes is: {totalArea / shapeList.Count:0.0}");
            Console.WriteLine($"The shape with the largest volume is a {shapeList[indexOfMaxVolume]} with a volume of {maxVolume:0.00}");

            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));

            int count = 1;
            foreach (Vector2 v in t)
            {
                Console.WriteLine($"Triangle {count} position is:{v.X:0.0}, {v.Y:0.0}");
                count++;
            }


        }
    }
}
