using System.Collections.Generic;

namespace CommandPattern
{
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void takeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {
            foreach (Order order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
