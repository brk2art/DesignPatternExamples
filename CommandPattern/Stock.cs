using System;

namespace CommandPattern
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine("Stock [ Name: " + name + ",Quantity: " + quantity +" ] bought");
        }
        public void sell()
        {
            Console.WriteLine("Stock [ Name: " + name + ",Quantity: " + quantity +" ] sold");
        }
    }
}
