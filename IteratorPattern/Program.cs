using System;

namespace IteratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NameRepository namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.getIterator(); iter.hasNext();)
            {
                string name = (string)iter.next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
