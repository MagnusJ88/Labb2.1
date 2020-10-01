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
            float rndWidth = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);
            float rndHeight = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);
            float rndDepth = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);

            Vector2 center2D = new Vector2(center.X, center.Y);

            int rndShape = rnd.Next(0, 7);
            switch (rndShape)
            {
                case 0:
                    return new Circle(center2D, rndWidth);
                case 1:
                    return new Rectangle(center2D, rndWidth);
                case 2:
                    return new Rectangle(center2D, new Vector2(rndWidth, rndHeight));
                case 3:
                    Vector2 p1 = new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10);
                    Vector2 p2 = new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10);
                    return new Triangle(p1, p2, new Vector2(center2D.X * 3 - p1.X - p2.X, center2D.Y * 3 - p1.Y - p2.Y));
                case 4:
                    return new Cuboid(center, rndWidth);
                case 5:
                    return new Cuboid(center, new Vector3(rndWidth, rndHeight, rndDepth));
                default:
                    return new Sphere(center, rndWidth);
            }
        }
        public static Shape GenerateShape()
        {
            float rndX = (float)rnd.NextDouble() * 10;
            float rndY = (float)rnd.NextDouble() * 10;
            float rndZ = (float)rnd.NextDouble() * 10;
            float rndWidth = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);
            float rndHeight = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);
            float rndDepth = (float)(rnd.NextDouble() * (10d - 0.1d) + 0.1d);

            int rndShape = rnd.Next(0, 7);
            switch (rndShape)
            {
                case 0:
                    return new Circle(new Vector2(rndX, rndY), rndWidth);
                case 1:
                    return new Rectangle(new Vector2(rndX, rndY), rndWidth);
                case 2:
                    return new Rectangle(new Vector2(rndX, rndY), new Vector2(rndWidth, rndHeight));
                case 3:
                    return new Triangle(new Vector2(rndX, rndY),
                            new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10),
                            new Vector2((float)rnd.NextDouble() * 10, (float)rnd.NextDouble() * 10));
                case 4:
                    return new Cuboid(new Vector3(rndX, rndY, rndZ), rndWidth);
                case 5:
                    return new Cuboid(new Vector3(rndX, rndY, rndZ), new Vector3(rndWidth, rndHeight, rndDepth));
                default:
                    return new Sphere(new Vector3(rndX, rndY, rndZ), rndWidth);
            }
        }
    }
}



