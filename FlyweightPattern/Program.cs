using System;

namespace FlyweightPattern
{
    public class Program
    {
        private static string[] colors = { "Red", "Green", "Blue", "White", "Black"};
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.setRadius(100);
                circle.draw();
            }
        }
        private static string getRandomColor()
        {
            return colors[(new Random().Next() * colors.Length)];
        }
        private static int getRandomX()
        {
            return (new Random().Next() * 100);
        }
        private static int getRandomY()
        {
            return (new Random().Next() * 100);
        }
    }
}
