using System;

namespace ServiceLocatorPattern
{
    public class Service2 : Service
    {
        public void execute()
        {
            Console.WriteLine("Executing Service2");
        }

        public string getName()
        {
            return "Service2";
        }
    }
}
