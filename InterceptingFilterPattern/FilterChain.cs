using System.Collections.Generic;

namespace InterceptingFilterPattern
{
    public class FilterChain
    {
        private List<Filter> filters = new List<Filter>();
        private Target target;

        public void addFilter(Filter filter)
        {
            filters.Add(filter);
        }

        public void execute(string request)
        {
            foreach (Filter filter in filters)
            {
                filter.execute(request);
            }
            target.execute(request);
        }

        public void setTarget(Target target)
        {
            this.target = target;
        }
    }
}
