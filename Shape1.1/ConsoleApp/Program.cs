using ShapeLib;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

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
            Console.WriteLine($"The total circumference of all triangles in the list is: {totalCircumferenceTriangle}");
            Console.WriteLine($"The average area of all shapes is: {totalArea / shapeList.Count}");
            Console.WriteLine($"The shape with the largest volume is a {shapeList[indexOfMaxVolume]} with a volume of {maxVolume:0.0}");
        }
    }
}
