using System.Collections.Generic;

namespace FilterPattern
{
    public interface Criteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
