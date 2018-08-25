using System;

namespace AbstractFactoryPattern
{
    public abstract class Button
    {
        private string caption;
        public abstract void paint();
        public string getCaption()
        {
            return caption;
        }
        public void setCaption(string caption)
        {
            this.caption = caption;
        }
    }

    class WinButton : Button
    {
        public override void paint()
        {
            Console.WriteLine("I'm a WinButton: " + getCaption());
        }
    }

    class OSXButton : Button
    {
        public override void paint()
        {
            Console.WriteLine("I'm a OSXButton: " + getCaption());
        }
    }
}
