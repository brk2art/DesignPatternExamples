﻿using System;

namespace PrototypePattern
{
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
