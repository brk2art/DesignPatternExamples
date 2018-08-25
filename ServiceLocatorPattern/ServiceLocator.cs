﻿namespace ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private static Cache cache;

        public static Service getService(string jndiName)
        {
            Service service = cache.getService(jndiName);

            if(service != null)
            {
                return service;
            }

            InitialContext context = new InitialContext();
            Service service1 = (Service)context.lookup(jndiName);
            cache.addService(service1);
            return service1;
        }
    }
}
