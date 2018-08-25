namespace BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private BusinessLookup lookupService = new BusinessLookup();
        private BusinessService businessService;
        private string serviceType;

        public void setServiceType(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void doTask()
        {
            businessService = lookupService.getBusinessService(serviceType);
            businessService.doProcessing();
        }
    }
}
