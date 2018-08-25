﻿using System;

namespace PrototypePattern
{
    public class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }

        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw() method");
        }
    }
}
