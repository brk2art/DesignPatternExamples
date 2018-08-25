using System.Collections.Generic;

namespace BuilderPattern
{
    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void addItem(Item item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }
        public void showItems()
        {
            string result = "";
            foreach (Item item in items)
            {
                result += "Item : " + item.name();
                result += "Packing : " + item.packing().pack();
                result += "Price : " + item.price();
            }
        }
    }
}
