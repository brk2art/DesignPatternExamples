using System;

namespace InterceptingFilterPattern
{
    public class Target
    {
        public void execute(string request)
        {
            Console.WriteLine("Executing request: " + request);
        }
    }
}
