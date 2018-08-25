namespace CompositeEntityPattern
{
    public class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void setData(string data1, string data2)
        {
            cgo.setData(data1, data2);
        }

        public string[] getData()
        {
            return cgo.getData();
        }
    }
}
