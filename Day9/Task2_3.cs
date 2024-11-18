using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write
{
    internal class Task2_3
    {
        private DateTime date;
        public DateTime Date 
        { 
            set
            {
                date = value;
            }
        }
        public Task2_3() { }
        public Task2_3(int year = 2000, int month = 1, int day = 1)
        {
            Date = new DateTime(year, month, day);
        }
        public void task()
        {
            if (this.date.Year % 4 == 0)
            {
                Console.WriteLine("Год весокосный");
            }
            else
            {
                Console.WriteLine("Год не весокосный");
            }
            this.date = this.date.AddDays(5);
            Console.WriteLine("Дата увеличина на 5 дней.");
        }
        public override string ToString() => $"Заданная дата: {this.date.ToShortDateString()}";
    }
}
