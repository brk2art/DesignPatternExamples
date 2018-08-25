using System;

namespace InterceptingFilterPattern
{
    public class AuthenticationFilter : Filter
    {
        public void execute(string request)
        {
            Console.WriteLine("Authenticating request: " + request);
        }
    }
}
