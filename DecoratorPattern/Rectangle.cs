using System;

namespace DecoratorPattern
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
