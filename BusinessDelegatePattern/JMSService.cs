using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    public class JMSService : BusinessService
    {
        public void doProcessing()
        {
            Console.WriteLine("Processing task by invoking JMS Service");
        }
    }
}
