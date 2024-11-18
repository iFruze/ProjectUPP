using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Circle
    {
        private int x;
        private int y;
        private int r;
        public Circle() { }
        public override string ToString() => $"Окружность с центром в точке ({x},{y}) и радиусом {r}";
    }
}
