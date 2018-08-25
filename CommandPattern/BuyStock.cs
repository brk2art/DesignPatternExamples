namespace CommandPattern
{
    public class BuyStock : Order
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.buy();
        }
    }
}
