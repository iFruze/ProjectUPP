using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Circle4
    {
        public int x;
        public int y;
        public int r;
        public Circle4() { }
        public Circle4(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public override string ToString() => $"Окружность с центром в точке ({x},{y}) и радиусом {r}";
    }
}
