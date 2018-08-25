using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person person in femalePersons)
            {
                if (person.getGender().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}
