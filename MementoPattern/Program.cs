using System;

namespace MementoPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.setState("State #1");
            originator.setState("State #2");
            careTaker.Add(originator.saveStateToMemento());

            originator.setState("State #3");
            careTaker.Add(originator.saveStateToMemento());

            originator.setState("State #4");
            Console.WriteLine("Current State: " + originator.getState());

            originator.getStateFromMemento(careTaker.Get(0));
            Console.WriteLine("First saved State: " + originator.getState());
            originator.getStateFromMemento(careTaker.Get(1));
            Console.WriteLine("Second saved State: " + originator.getState());
        }
    }
}
