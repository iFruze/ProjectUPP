using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Task1
    {
        private int nom;
        private int count;
        public Task1() { }
        public Task1(int nom = 1, int count = 5)
        {
            this.nom = nom;
            this.count = count;
        }
        public override string ToString() => $"Номинал - {this.nom}\nКоличество - {this.count}\nСумма купюр - {this.nom*this.count}";

    }
}
