using System;

namespace BusinessDelegatePattern
{
    public class EJBService : BusinessService
    {
        public void doProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service");
        }
    }
}
