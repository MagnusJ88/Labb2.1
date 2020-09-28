using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime;

namespace ShapeLib
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

    }

    public static GenerateShape(double min, double max) // todo ska det vara en public static Vector3 GenerateShape()?
    {
        
      
    //För att skapa random positioner
        min = 0.0;
        max = 100.0;
        Random rnd = new Random();
        double rndPoint = rnd.NextDouble() * (max - min) + min;

        //För att skapa random Shape
        int rndShape = rnd.Next(0 - 7);

        if (rndShape == 1)
        {
            Circle c = new Circle(new Vector2((float)rndPoint, (float)rndPoint), (float)rndPoint);
            Console.WriteLine(c);
            return;
        }
        if (rndShape == 2)
        {
            Rectangle r = new Rectangle(new Vector2((float)rndPoint, (float)rndPoint), new Vector2((float)rndPoint));
            Console.WriteLine(r);
            return;
        }
        

    }

}
