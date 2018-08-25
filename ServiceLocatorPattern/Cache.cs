using System;
using System.Collections.Generic;

namespace ServiceLocatorPattern
{
    public class Cache
    {
        private List<Service> services;

        public Cache()
        {
            services = new List<Service>();
        }

        public Service getService(string serviceName)
        {

            foreach (Service service in services)
            {
                if (service.getName().Equals(serviceName))
                {
                    Console.WriteLine("Returning cached  " + serviceName + " object");
                    return service;
                }
            }
            return null;
        }

        public void addService(Service newService)
        {
            bool exists = false;

            foreach (Service service in services)
            {
                if (service.getName().Equals(newService.getName()))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                services.Add(newService);
            }
        }
    }
}
