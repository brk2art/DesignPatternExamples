namespace FrontControllerPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.dispatchRequest("HOME");
            frontController.dispatchRequest("STUDENT");
        }
    }
}
