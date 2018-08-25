﻿namespace BuilderPattern
{
    public abstract class ColdDrink : Item
    {
        public abstract string name();

        public Packing packing()
        {
            return new Bottle();
        }

        public abstract float price();
    }
}
