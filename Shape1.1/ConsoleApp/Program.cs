using ShapeLib;
using System;
using System.Numerics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Circle c = new Circle(new Vector2(1.0f, 1.0f), 3.0f);
            Console.WriteLine(c);
            Console.WriteLine(c.Area);
            Console.WriteLine(c.Circumference);

            Rectangle r = new Rectangle(new Vector2(2.0f, 2.0f), new Vector2(4.7f, 12.0f));
            Console.WriteLine(r);
            Console.WriteLine(r.Area);
            Console.WriteLine(r.Circumference);

            Triangle t = new Triangle(new Vector2(2.0f, 3.0f), new Vector2(5.0f, 10.0f), new Vector2(15.0f, 5.0f));
            Console.WriteLine(t);
            Console.WriteLine(t.Area);
            Console.WriteLine(t.Circumference);
            
            Cuboid cub = new Cuboid(new Vector3(1.0f, 2.0f, 1.0f), new Vector3(3.0f, 5.0f, 8.0f));
            Console.WriteLine(cub);
            Console.WriteLine(cub.Area);
            Console.WriteLine(cub.Volume);*/

            Sphere s = new Sphere(new Vector3(1.0f, 2.0f, 3.0f), 11f);
            Console.WriteLine(s);
            Console.WriteLine(s.Area);
            Console.WriteLine(s.Volume);

            Shape.GenerateShape(new Vector3(3.0f, 4.0f, 5.0f));

        }
    }
}
