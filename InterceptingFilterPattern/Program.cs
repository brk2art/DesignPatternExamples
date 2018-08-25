namespace InterceptingFilterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FilterManager filterManager = new FilterManager(new Target());
            filterManager.setFilter(new AuthenticationFilter());
            filterManager.setFilter(new DebugFilter());

            Client client = new Client();
            client.setFilterManager(filterManager);
            client.sendRequest("HOME");
        }
    }
}
