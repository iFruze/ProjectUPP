using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Circle1 (double x, double y, double r)
    {
        public Circle1():this(3, 3, 3) { }
        public double area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double length()
        {
            return Math.PI * r;
        }
        public void Deconstruct(out double x1, out double y1, out double r1)
        {
            x1 = x;
            y1 = y;
            r1 = r;
        }
        public override string ToString() => $"Окружность с центром в точке ({x:f1}, {y:f1}) и радиусом {r:f2}.\nПлощадь окружности равна {this.area():f2} см квадратных.\nДлина окружности равна {this.length():f2} см";
    }
}
