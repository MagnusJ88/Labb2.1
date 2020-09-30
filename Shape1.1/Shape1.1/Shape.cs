using System;
using System.Numerics;

namespace ShapeLib
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        private static Random rnd = new Random();
        public static Shape GenerateShape(Vector3 center)
        {
            float rndX = (float)rnd.NextDouble() * 10;
            float rndY = (float)rnd.NextDouble() * 10;
            float rndZ = (float)rnd.NextDouble() * 10;
            //todo en rnd för width?
            Vector2 center2D = new Vector2(center.X, center.Y);

            int rndShape = rnd.Next(0, 7);
            switch (rndShape)
            {
                case 0:
                    return new Circle(center2D, rndX);
                case 1:
                    return new Rectangle(center2D, rndX);
                case 2:
                    return new Rectangle(center2D, new Vector2(rndX, rndY));
                case 3:
                    Vector2 p1 = new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10);
                    Vector2 p2 = new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10);
                    return new Triangle(p1, p2, new Vector2(center2D.X * 3 - p1.X - p2.X, center2D.Y * 3 - p1.Y - p2.Y));
                case 4:
                    return new Cuboid(center, rndX);
                case 5:
                    return new Cuboid(center, new Vector3(rndX, rndY, rndZ));
                default:
                    return new Sphere(center, rndX);
            }
        }
        public static Shape GenerateShape()
        {
            float rndX = (float)rnd.NextDouble() * 10;
            float rndY = (float)rnd.NextDouble() * 10;
            float rndZ = (float)rnd.NextDouble() * 10;
            float rndX2 = (float)rnd.NextDouble() * 10;
            float rndY2 = (float)rnd.NextDouble() * 10;
            float rndZ2 = (float)rnd.NextDouble() * 10;

            int rndShape = rnd.Next(0, 7);
            switch (rndShape)
            {
                case 0:
                    return new Circle(new Vector2(rndX, rndY), rndZ);
                case 1:
                    return new Rectangle(new Vector2(rndX, rndY), rndZ);
                case 2:
                    return new Rectangle(new Vector2(rndX, rndY), new Vector2(rndX2, rndY2));
                case 3:
                    return new Triangle(new Vector2(rndX, rndY), new Vector2(rndZ, rndX2), new Vector2(rndY2, rndZ2));
                case 4:
                    return new Cuboid(new Vector3(rndX, rndY, rndZ), rndX2);
                case 5:
                    return new Cuboid(new Vector3(rndX, rndY, rndZ), new Vector3(rndX2, rndY2, rndZ2));
                default:
                    return new Sphere(new Vector3(rndX, rndY, rndZ), rndX2);
            }
        }
    }
}
