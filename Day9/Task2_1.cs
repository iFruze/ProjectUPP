using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default
{
    internal class Task2_1
    {
        private DateTime date;
        public DateTime Date
        {
            get 
            { 
                return date; 
            }
            set 
            { 
                if(value.Year < 1991)
                {
                    Console.WriteLine("Нужен прериод после распада CCCР.");
                }
                else
                    date = value; 
            } 
        }
        public Task2_1() { }
        public Task2_1(int year = 2000, int month = 1, int day = 1)
        {
            this.date = new DateTime(year, month, day);
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
