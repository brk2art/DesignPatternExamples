using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> circleMap = new Dictionary<string, Shape>();

        public static Shape getCircle(string color)
        {
            Circle circle = (Circle)circleMap[color];
            if(circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circle;
        }
    }
}
