using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    internal class Library
    {
        private Book[] books;
        private int n;
        private int quantity;
        public Book this[int i]
        {
            get
            {
                if (books[i] != null)
                {
                    return books[i];
                }
                else
                {
                    throw new Exception("Книги с заданным индексом нет.");
                }
            }
            set
            {
                if (value != null)
                {
                    books[i] = value;
                }
                else
                {
                    throw new Exception("Информация о книге отсутствует.");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("\nСписок книг:\n");
            for(int i = 0; i < quantity; i++)
            {
                sb.Append($"Название книги: {books[i].Name}\n");
                sb.Append($"Автор книги: {books[i].Author}\n");
                sb.Append($"Категория книги: {books[i].Cat}\n");
                sb.Append($"Год выпуска книги книги: {books[i].Year}\n");
                sb.Append($"\n");
            }
            return Convert.ToString(sb); 
        }
        public Library() 
        {
            books = new Book[1];
            n = 1;
            quantity = 1;
        }
        public Library(int n)
        {
            this.n = n;
            this.quantity = n;
            this.books = new Book[n];
        }
        public string Search(string author)
        {
            StringBuilder sb = new StringBuilder("\nРезультаты поиска:\n");
            for (int i = 0; i < quantity; i++)
            {
                if (books[i].Author == author)
                {
                    sb.Append($"Название книги: {books[i].Name}\n");
                    sb.Append($"Автор книги: {books[i].Author}\n");
                    sb.Append($"Категория книги: {books[i].Cat}\n");
                    sb.Append($"Год выпуска книги книги: {books[i].Year}\n");
                    sb.Append($"\n");
                }
            }
            if(sb.ToString() == "\nРезультаты поиска:\n")
            {
                sb.Append("Книг не найдено.\n");
            }
            return Convert.ToString(sb);
        }
        public void Delete(int index)
        {
            if (this.books[index] == null)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = index; i < quantity - 1; i++)
                {
                    this.books[i] = this.books[i + 1];
                }
                quantity--;
                Console.WriteLine($"Книга с индексом {index} была удалена.");
            }
        }
    }
}
