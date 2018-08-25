using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape):base(decoratedShape)
        {

        }

        public void draw()
        {
            decoratedShape.draw();
            SetRedBorder(decoratedShape);
        }
        private void SetRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
