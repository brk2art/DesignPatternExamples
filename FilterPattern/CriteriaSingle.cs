using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person person in singlePersons)
            {
                if (person.getGender().Equals("SINGLE"))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}
