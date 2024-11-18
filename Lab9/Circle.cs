using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Circle
    {
        private double x;
        private double y;
        private double r;
        public double R
        {
            get { return r; }
            set 
            { 
                if(value > 9)
                {
                    throw new ArgumentException();
                }
                else r = value; 
            } 
        }
        public Circle() { }
        public Circle(double x1, double y1, double r1)
        {
            this.x = x1;
            this.y = y1;
            this.R = r1;
        }
        public static Circle operator ++(Circle t)
        {
            t.r++;
            return t;
        }
        public double area()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public double length()
        {
            return Math.PI * this.R;
        }
        public double length(double pi)
        {
            return pi * this.R;
        }
        public void Deconstruct(out double x1, out double y1, out double r1)
        {
            x1 = this.x;
            y1 = this.y;
            r1 = this.R;
        }
        public override string ToString() => $"Окружность с центром в точке ({this.x:f1}, {this.y:f1}) и радиусом {this.r:f2}.\nПлощадь окружности равна {this.area():f2} см квадратных.\nДлина окружности равна {this.length():f2} см";
    }
}
