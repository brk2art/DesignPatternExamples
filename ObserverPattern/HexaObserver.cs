using System;

namespace ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Octal String: " + subject.getState().ToString("X"));
        }
    }
}
