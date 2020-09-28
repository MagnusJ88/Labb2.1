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
            double min = 0.0d;
            double max = 100.0d;
            double rndX = rnd.NextDouble() * (max - min) + min;
            double rndY = rnd.NextDouble() * (max - min) + min;
            double rndZ = rnd.NextDouble() * (max - min) + min;

            Vector2 center2D = new Vector2(center.X, center.Y);

            int rndShape = rnd.Next(0 - 7);
            switch (rndShape)
            {
                case 0:
                    return new Circle(center2D, (float)rndX); //todo byta ut till (float)Math.Round(rnd.NextDouble() * 10, 1) ???
                case 1:
                    return new Rectangle(center2D, (float)rndX);
                case 2:
                    return new Rectangle(center2D, new Vector2((float)rndX, (float)rndY));
                case 3:
                    Vector2 p1 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                    Vector2 p2 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                    return new Triangle(p1, 
                                        p2,
                                        new Vector2(MathF.Round(center2D.X * 3 - p1.X - p2.X, 1),
                                                    MathF.Round(center2D.Y * 3 - p1.Y - p2.Y, 1)));
                case 4:
                    return new Cuboid(center, (float)rndX);
                case 5:
                    return new Cuboid(center, new Vector3((float)rndX, (float)rndY, (float)rndZ));
                case 6:
                    return new Sphere(center, (float)rndX);
            }
           
        }
       /* public static Shape GenerateShape()
        {
            return;
        }*/
    }
}
