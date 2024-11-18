using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Circle3(int x, int y, int r)
    {
        public Circle3(int x):this(x, 2, 3) { }
        public override string ToString()=>$"Окружность с центром в точке ({x},{y}) и радиусом {r}";
    }
}
