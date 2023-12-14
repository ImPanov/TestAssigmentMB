using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapes
{
    public class Triangle : Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            _a = a;
            _b = b;
            _c = c;
            Validate();
        }

        // не стал выносить периметр в отдельный метод или свойство, т.к. библиотека для вычисления площади YAGNI. 
        public override double Area()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }    
        // проверку в абстрактном родители не указал
        public bool IsRight()
        {
            var maxSide = Math.Max(Math.Max(_a, _b),_c);

            if(maxSide == _a)
                return CheckRight(_a, _b, _c);
            if(maxSide == _b)
                return CheckRight(_b, _a, _c);
            if(maxSide == _c)
                return CheckRight(_c, _b, _a);
            return false;
            
        }
        
        //чтобы не делать конструкцию громоздкой и просто вводить 3 числа для проверки
        private bool CheckRight(double maxSide, double a, double b)
        {
            return maxSide * maxSide == a * a + b * b;
        }

        private void Validate()
        {
            if ( !(_a < _b + _c || _b < _a + _c || _c < _a + _b) )
            {
                throw new Exception("Triangle does not exists");
            }
        }
    }
}
