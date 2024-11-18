using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Data
    {
        private DateTime date;
        public DateTime Date
        {
            set
            {
                if (value.ToString() == "") throw new ArgumentException();
                else date = value;
            }
            get { return date; }
        }
        public DateTime this[int i]
        {
            get
            {
                if (i == 0) return this.Date.AddDays(i);
                else return this.Date.AddDays(i);
            }
        }
        public override string ToString() => $"Заданная дата: {this.Date.ToShortDateString()}";
        public Data()
        {
            this.Date = new DateTime(2020,1,1);
        }
        public Data(DateTime date) 
        {
            this.Date = date;
        }
        public void prev()
        {
            Console.WriteLine($"Предыдущий день: {this.Date.AddDays(-1).ToShortDateString()}");
        }
        public void next()
        {
            Console.WriteLine($"Следующий день: {this.Date.AddDays(1).ToShortDateString()}");
        }
        public void days()
        {
            Console.WriteLine($"До конца месяца осталось {DateTime.DaysInMonth(Date.Year, Date.Month) - this.Date.Day} дней");
        }
        public static bool operator !(Data data)
        {
            if (data.Date.Day == DateTime.DaysInMonth(data.Date.Year, data.Date.Month))
            {
                return false;
            }
            else return true;
        }
        public static bool operator true(Data data)
        {
            if(data.Date.Day == 1 && data.Date.Month == 1) return true;
            else return false;
        }
        public static bool operator false(Data data)
        {
            if (data.Date.Day == 1 && data.Date.Month == 1) return true;
            else return false;
        }
        public static bool operator &(Data data1, Data data2)
        {
            if(data1.Date.ToShortDateString() == data2.Date.ToShortDateString()) return true;
            else return false;
        }
    }
}
