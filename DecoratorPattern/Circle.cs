using System;

namespace DecoratorPattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
