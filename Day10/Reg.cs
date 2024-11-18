using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day10
{
    internal class Reg
    {
        private Regex r;
        private string text;
        public Regex R
        {
            set 
            { 
                if(value.ToString() == "")
                {
                    throw new InvalidOperationException();
                }
                else r = value; 
            }
            get { return r; }
        }
        public Regex this[int i]
        {
            get
            {
                if(i == 0)
                {
                    return r;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public string T
        {
            set 
            { 
                if(value == "")
                {
                    throw new InvalidOperationException();
                }
                else text = value;
            }
            get { return text; }
        }
        public void match()
        {
            MatchCollection matches = this.r.Matches(text);
            Console.WriteLine("Фрагменты текста, соответствующие шаблону поля: ");
            foreach(Match t in matches)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public void delete()
        {
            this.T = Regex.Replace(this.T, this.R.ToString(), "");
            Console.WriteLine("Изменённая строка: ");
            Console.WriteLine(this.T);
        }
        public void is_match()
        {
            Console.WriteLine($"Соостветствие строки шаблону: {this.R.IsMatch(this.T)}");
        }
        public Reg(){}
        public Reg(string text, string reg)
        {
            this.T = text;
            this.R = new Regex(reg);
        }
        public override string ToString() => $"Регулярное выражение: {this.R}\nСтрока: {this.T}";

    }
}