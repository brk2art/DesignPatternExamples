namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());
        }
    }
}
