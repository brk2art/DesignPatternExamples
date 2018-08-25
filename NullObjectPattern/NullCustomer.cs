namespace NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        public override string getName()
        {
            return "Not Available in Customer Database";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
