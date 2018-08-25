namespace BuilderPattern
{
    public interface Item
    {
        string name();
        Packing packing();
        float price();
    }
}
