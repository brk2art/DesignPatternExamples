using System;

namespace StatePattern
{
    public class StartState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.setState(this);
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
