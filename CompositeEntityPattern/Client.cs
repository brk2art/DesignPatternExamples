using System;

namespace CompositeEntityPattern
{
    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void printData()
        {
            for (int i = 0; i < compositeEntity.getData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.getData()[i]);
            }
        }

        public void setData(string data1, string data2)
        {
            compositeEntity.setData(data1, data2);
        }
    }
}
