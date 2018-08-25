using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.sendMessage("Hi! John!");
            john.sendMessage("Hello! Robert!");
        }
    }
}
