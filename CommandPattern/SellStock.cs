namespace CommandPattern
{
    public class SellStock : Order
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void execute()
        {
            abcStock.sell();
        }
    }
}
