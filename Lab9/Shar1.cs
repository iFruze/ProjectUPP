using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Shar1(double r)
    {
        
            public Shar1() : this(1) { }
            public double Area()
            {
                return 4 * Math.PI * Math.Pow(r, 2);
            }
            public double Volume()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            }
        public void Deconstruct(out double x1, out double r1)
        {
            x1 = 1;
            r1 = r;
        }
        public override string ToString()
            { return $"Шар с радиусом {r:f2}.\nПлощадь окружности равна {this.Area():f2} см квадратных.\nОбъем шара равен {this.Volume():f2} см кубических"; }

        
    }

    
    
}
