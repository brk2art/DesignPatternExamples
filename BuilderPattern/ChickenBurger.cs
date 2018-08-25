namespace BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override float price()
        {
            return 50.5f;
        }
        public override string name()
        {
            return "Chicken Burger";
        }
    }
}
