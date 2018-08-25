using System;

namespace VisitorPattern
{
    public class ComputerPartDisplayVisitor : ComputerPartVisitor
    {
        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }
    }
}
