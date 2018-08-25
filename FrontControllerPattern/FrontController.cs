using System;

namespace FrontControllerPattern
{
    public class FrontController
    {
        private Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        private void trackRequest(string request)
        {
            Console.WriteLine("Page requested: " + request);
        }

        public void dispatchRequest(string request)
        {
            //log each request
            trackRequest(request);

            //authenticate the user
            if (isAuthenticUser())
            {
                dispatcher.dispatch(request);
            }
        }
    }
}
