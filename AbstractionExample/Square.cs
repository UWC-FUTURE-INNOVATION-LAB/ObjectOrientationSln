using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    
    public class Square : Shape
    {
        private int _sideLength;

        public Square(int sideLength)
        {
            _sideLength = sideLength;
        }
        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
