using ShapeLib;
using System;
using System.Numerics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(new Vector2(1.0f, 1.0f), 2.0f);
            Console.WriteLine(c);

            Rectangle r = new Rectangle(new Vector2(2.0f, 2.0f), new Vector2(4.5f, 9.0f));
            Console.WriteLine(r);
        }
    }
}
