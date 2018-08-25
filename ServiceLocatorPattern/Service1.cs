using System;

namespace ServiceLocatorPattern
{
    public class Service1 : Service
    {
        public void execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string getName()
        {
            return "Service1";
        }
    }
}
