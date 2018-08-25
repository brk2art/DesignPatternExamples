using System;

namespace TemplatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Cricket();
            game.play();
            Console.WriteLine();
            game = new Football();
            game.play();
        }
    }
}
