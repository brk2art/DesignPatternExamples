using System;

namespace StatePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            Console.WriteLine(context.getState().ToString());

            StopState stopState = new StopState();
            stopState.doAction(context);

            Console.WriteLine(context.getState().ToString());
        }
    }
}
