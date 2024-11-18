using Day9;
using Default;
using Auto;
using Write;
using Read;
using Reduction;
using Requaired;
using Calcualte;
using Init;
using Required;
int year, month, day;
while (true)
{
    try
    {
        int punct = -1;
        punct = Convert.ToInt32(Console.ReadLine());
        switch (punct)
        {
            case 1:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_1 task2_1 = new Task2_1();
                task2_1.Date=new DateTime(year, month, day);
                Console.WriteLine(task2_1);
                task2_1.task();
                Console.WriteLine(task2_1);
                break;
            case 2:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_2 task2_2 = new Task2_2(year, month, day);
                Console.WriteLine(task2_2);
                task2_2.task();
                Console.WriteLine(task2_2);
                break;
            case 3:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_3 task2_3 = new Task2_3();
                task2_3.Date=new DateTime(year, month, day);
                Console.WriteLine(task2_3);
                task2_3.task();
                Console.WriteLine(task2_3);
                break;
            case 4:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_4 task2_4 = new Task2_4(year, month, day);
                Console.WriteLine(task2_4);
                task2_4.task();
                Console.WriteLine(task2_4);
                break; 
            case 5:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_5 task2_5 = new Task2_5(year, month, day);
                Console.WriteLine(task2_5);
                task2_5.task();
                Console.WriteLine(task2_5);
                break;
            case 6:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_6 task2_6 = new Task2_6(year, month, day);
                Console.WriteLine(task2_6);
                task2_6.task();
                Console.WriteLine(task2_6);
                break;
            case 7:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_7 task2_7 = new Task2_7(year, month, day);
                Console.WriteLine(task2_7);
                task2_7.task();
                Console.WriteLine(task2_7);
                break;
            case 8:
                Console.Write("Год: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("День: ");
                day = Convert.ToInt32(Console.ReadLine());
                Task2_8 task2_8 = new Task2_8{ Date = new DateTime(year, month, day) };
                Console.WriteLine(task2_8);
                task2_8.task();
                Console.WriteLine(task2_8);
                break;
            case 9:
                Console.Write("Число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Class8 task2_9 = new Class8 { Number1 = num1, number2 = num2};
                Console.WriteLine(task2_9);
                task2_9.kvadrat();
                Console.WriteLine(task2_9);
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("такого задания нет.");
                break;

        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error");
    }
}












//Circle c = new Circle();
//Console.WriteLine(c);
//Circle1 c1 = new(1);
//Console.WriteLine(c1);
//c1 = new(10, 10);
//Console.WriteLine(c1);
//c1 = new(10, 10, 10);
//Console.WriteLine(c1);
//Circle2 c2 = new Circle2();
//Console.WriteLine(c2);
//Circle3 c3 = new(1);
//Console.WriteLine(c3);
//Circle4 c4 = new(){ x = 5, y = 5, r = 5 };
//Console.WriteLine(c4);
//(int x, int y, int r) = c2;
//Console.WriteLine($"{x}, {y}, {r}");
//(_, int y1, int r1) = c2;
//Console.WriteLine($"{y1}, {r1}");
//(_, _, int r2) = c2;
//Console.WriteLine($"{r2}");
//try
//{
//    int nom, count;
//    Console.Write("Номинал: ");
//    nom = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Количество купюр: ");
//    count = Convert.ToInt32(Console.ReadLine());
//    Task1 task1 = new Task1(nom, count);
//    Console.WriteLine(task1);
//    int year, month, day;
//    Console.Write("Год: ");
//    year = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Месяц: ");
//    month = Convert.ToInt32(Console.ReadLine());
//    Console.Write("День: ");
//    day = Convert.ToInt32(Console.ReadLine());
//    Task2 task2 = new Task2(year, month, day);
//    Console.WriteLine(task2);
//    task2.task();
//    Console.WriteLine(task2);
//}
//catch (FormatException)
//{
//    Console.WriteLine("Введите число.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Вы вышли за размерность.");
//}
//catch (Exception)
//{
//    Console.WriteLine("Вы где-то ошиблись.");
//}