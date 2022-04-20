using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public class Circle : Shape
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
           return  Math.PI * _radius * _radius;  
        }
    }
}
