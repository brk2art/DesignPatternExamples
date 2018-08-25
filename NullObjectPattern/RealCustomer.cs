namespace NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
