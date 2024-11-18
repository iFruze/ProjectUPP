using Day10;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
while (true)
{
    try
    {
        Console.Write("0 - Выход\n1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\nПункт: ");
        int punct = Convert.ToInt32(Console.ReadLine());
        switch (punct)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                string text, reg;
                Console.Write("Строка: ");
                text = Console.ReadLine();
                Console.Write("Регулярное выражение: ");
                reg = Console.ReadLine();
                try
                {
                    Reg reg1 = new Reg(text, reg);
                    Console.WriteLine(reg1);
                    Console.Write("Новая строка: ");
                    text = Console.ReadLine();
                    Console.Write("Новоее регулярное выражение: ");
                    reg = Console.ReadLine();
                    reg1.T = text;
                    reg1.R = new Regex(reg);
                    Console.WriteLine(reg1);
                    reg1.is_match();
                    reg1.match();
                    reg1.delete();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Путсая строка.");
                }
                break;
            case 2:
                try
                {
                    int year, month, day;
                    Console.Write("Год: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Месяц: ");
                    month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("День: ");
                    day = Convert.ToInt32(Console.ReadLine());
                    Data temp = new Data();
                    Data date = new Data(new DateTime(year, month, day));
                    Console.WriteLine(date);
                    date.Date = DateTime.Now;
                    Console.WriteLine($"Сейчас {date.Date.ToShortDateString()}");
                    date.next();
                    date.prev();
                    date.days();
                    Console.Write("Введите i-й день: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"I-я дата: {date[i].ToShortDateString()}");
                    Console.WriteLine($"Дата не является концом месяца: {!date}");
                    if(date)
                    {
                        Console.WriteLine("Начало года.");
                    }
                    else
                    {
                        Console.WriteLine("Не начало года.");
                    }
                    if(date & temp)
                    {
                        Console.WriteLine("Даты равны");
                    }
                    else
                    {
                        Console.WriteLine("Даты не равны");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Введите корректные данные.");
                }
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Введите корректные данные.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Вы вышли за размерность.");
    }
    catch (Exception)
    {
        Console.WriteLine("Ошибка.");
    }
}