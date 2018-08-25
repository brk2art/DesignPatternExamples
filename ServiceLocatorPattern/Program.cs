namespace ServiceLocatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Service service = ServiceLocator.getService("Service1");
            service.execute();
            service = ServiceLocator.getService("Service2");
            service.execute();
            service = ServiceLocator.getService("Service1");
            service.execute();
            service = ServiceLocator.getService("Service2");
            service.execute();
        }
    }
}
