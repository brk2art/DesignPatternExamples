﻿namespace MementoPattern
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }
    }
}
