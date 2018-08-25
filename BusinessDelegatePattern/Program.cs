namespace BusinessDelegatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.setServiceType("EJB");

            Client client = new Client(businessDelegate);
            client.doTask();

            businessDelegate.setServiceType("JMS");
            client.doTask();
        }
    }
}
