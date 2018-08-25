namespace CompositeEntityPattern
{
    public class CoarseGrainedObject
    {
        DependentObject1 do1 = new DependentObject1();
        DependentObject2 do2 = new DependentObject2();

        public void setData(string data1, string data2)
        {
            do1.setData(data1);
            do2.setData(data2);
        }

        public string[] getData()
        {
            return new string[] { do1.getData(), do2.getData() };
        }
    }
}
