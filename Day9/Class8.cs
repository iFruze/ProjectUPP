
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Required
    {
        internal class Class8
        {
            private double number1;
            public double number2;
            public required double Number1{get;set;}
            public Class8() { }
            public Class8(double number1 = 23.67, double number2 = 3)
            {
                this.number1 = number1;
                this.number2 = number2;
            }
            public void Deconstruct(out double number1, out double number2)
            {
                number1 = this.number1;
                number2 = this.number2;
            }
            public double kvadrat()
            {
                return Math.Pow((this.Number1 + this.number2), 2);
            }
            public override string ToString()
            {
                return $"Границы диапазона: {this.Number1} и {number2}\nКвадрат длины диапазона: {kvadrat()}";
            }
        }
    }

