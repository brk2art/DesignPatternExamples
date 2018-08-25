namespace AbstractFactoryPattern
{
    public abstract class GUIFactory
    {
        public static GUIFactory getFactory()
        {
            int sys = 0;
            //int sys = readFromConfigFile("OS_TYPE");
            if(sys == 0)
            {
                return (new WinFactory());
            }
            else
            {
                return (new OSXFactory());
            }
        }
        public abstract Button createButton();
    }

    class WinFactory : GUIFactory
    {
        public override Button createButton()
        {
            return (new WinButton());
        }
    }
    class OSXFactory : GUIFactory
    {
        public override Button createButton()
        {
            return (new OSXButton());
        }
    }
}
