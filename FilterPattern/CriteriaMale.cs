using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaMale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person person in malePersons)
            {
                if (person.getGender().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
