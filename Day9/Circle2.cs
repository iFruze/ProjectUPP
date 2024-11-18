using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Circle2
    {
        private int x;
        private int y;
        private int r;
        public Circle2():this(2) { }
        public Circle2(int x):this(x, 3) { }
        public Circle2(int x, int y):this(x, y, 4) { }
        public Circle2(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public void Deconstruct(out int x1, out int y1, out int r1)
        {
            x1 = x;
            y1 = y;
            r1 = r;
        }
        public override string ToString() => $"Окружность с центром в точке ({x},{y}) и радиусом {r}";
    }
}
