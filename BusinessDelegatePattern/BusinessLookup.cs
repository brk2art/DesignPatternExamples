namespace BusinessDelegatePattern
{
    public class BusinessLookup
    {
        public BusinessService getBusinessService(string serviceType)
        {
            if (serviceType.Equals("EJB"))
            {
                return new EJBService();
            }
            else
            {
                return new JMSService();
            }
        }
    }
}
