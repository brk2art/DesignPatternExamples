using System;

namespace StatePattern
{
    public class StopState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
