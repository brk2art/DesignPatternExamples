namespace CompositeEntityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();
            client.setData("Test", "Data");
            client.printData();
            client.setData("Second Test", "Data1");
            client.printData();
        }
    }
}
