using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    internal class Task2_2
    {
        private DateTime date;
        public DateTime Date{ get; set; }
        public Task2_2() { }
        public Task2_2(int year = 2000, int month = 1, int day = 1)
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
            Date = Date.AddDays(5);
            Console.WriteLine("Дата увеличина на 5 дней.");
        }
        public override string ToString() => $"Заданная дата: {Date.ToShortDateString()}";
    }
}
