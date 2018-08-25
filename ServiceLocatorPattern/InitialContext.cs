using System;

namespace ServiceLocatorPattern
{
    public class InitialContext
    {
        public object lookup(string jndiName)
        {
            if (jndiName.Equals("SERVICE"))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else if (jndiName.Equals("SERVICE2"))
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }
}
