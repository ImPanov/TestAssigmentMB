using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapes
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
