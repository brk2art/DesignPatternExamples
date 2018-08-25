using System;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GUIFactory aFactory = GUIFactory.getFactory();
            Button aButton = aFactory.createButton();
            aButton.setCaption("Play");
            aButton.paint();
            Console.ReadKey();
        }
    }
}
