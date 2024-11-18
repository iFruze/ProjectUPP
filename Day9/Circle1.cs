using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Circle1
    {
        private int x;
        private int y;
        private int r;
        public Circle1() { this.x = 1; this.y = 1; this.r = 1; }
        public Circle1(int x) { this.x = x; }
        public Circle1(int x, int y) { this.x = x; this.y=y; }
        public Circle1(int x, int y, int r) { this.x = x; this.y = y; this.r = r; }
        public override string ToString() => $"Окружность с центром в точке ({x},{y}) и радиусом {r}";
    }
}
