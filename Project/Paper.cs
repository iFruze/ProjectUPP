using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeFrame;
namespace Project
{
    internal class Paper
    {
        public string Publication { get; set; }
        public Person Info {  get; set; }
        public DateTime Date { get; set; }

        public override string ToString() => $"Название: {this.Publication}\nАвтор: {this.Info.ToShortString()}\nДата публикации: {this.Date.ToShortDateString()}";
    }
}
