using System;

namespace InterceptingFilterPattern
{
    public class DebugFilter : Filter
    {
        public void execute(string request)
        {
            Console.WriteLine("request log: " + request);
        }
    }
}
