using System;

namespace PrototypePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeCache.loadCache();

            Shape clonedShape = ShapeCache.getShape("1");
            Console.WriteLine("Shape : " + clonedShape.getType());

            Shape clonedShape2 = ShapeCache.getShape("2");
            Console.WriteLine("Shape : " + clonedShape2.getType());

            Shape clonedShape3 = ShapeCache.getShape("3");
            Console.WriteLine("Shape : " + clonedShape3.getType());
        }
    }
}
