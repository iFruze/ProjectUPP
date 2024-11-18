using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    internal class Book
    {
        private string name;
        private string author;
        private int year;
        private string category;
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Cat { get; set; }
        public Book() { }
        public Book(string name, string author, int year, string category) 
        { 
            this.Name = name;
            this.Author = author;
            this.Year = year;
            this.Cat = category;
        }
    }
}
