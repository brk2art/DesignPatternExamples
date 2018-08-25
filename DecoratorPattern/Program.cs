using System;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.draw();
        }
    }
}
