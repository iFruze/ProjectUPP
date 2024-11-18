using System.Reflection.Metadata;
using System.Runtime.InteropServices;
int exit = 1;
while (exit == 1)
{
    try
    {
        Console.Write("1 - Задание 1 \n2 - Задание 2 \n3 - Задание 3 \n0 - Выход \nПункт: ");
        int p = Convert.ToInt32(Console.ReadLine());
        switch (p)
        {
            case 1:
                int a, n;
                Console.Write("Введите число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите степень: ");
                n = Convert.ToInt32(Console.ReadLine());
                int res = a;
                for(int i = 1; i < n; i++)
                {
                    res *= a;
                }
                Console.WriteLine($"Ответ: {res}\n");
                Console.WriteLine("Дюймы\tСантимертры");
                for(int i = 1; i <= 20; i++)
                {
                    Console.WriteLine($"{i}\t{Math.Round(i*2.54, 3)}");
                }
                Console.Write("Введите натуральное число: ");
                n = Convert.ToInt32(Console.ReadLine());
                double mersson = 0;
                int g;
                for(int i = 2; i <= n; i++)
                {
                    bool f = true;
                    for(int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if(i%j == 0)
                        {
                            f = false;
                        }
                    }
                    if(f == true)
                    {
                        mersson = Math.Pow(2, i) - 1;
                        if(mersson < n)
                        {
                            Console.WriteLine($"Число Мерссена, меньшее {n}: {Math.Round(mersson, 3)}");
                        }
                    }
                }
                
                break;
            case 2:
                Console.Write("Введите количество итераций: ");
                int iter = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double sum = 1;
                for(int i = 1; i<=iter; i++)
                {
                    double fac = 1;
                    for(int j = 1; j <= i; j++)
                    {
                        fac *= j;
                    }
                    sum += Math.Pow(x, i) / fac;
                }
                Console.WriteLine($"Ответ: {Math.Round(sum,3)}");
                break;
            case 3:
                double y;
                double shag;
                do
                {
                    Console.Write("Введите шаг: ");
                    shag = Convert.ToDouble(Console.ReadLine());
                } while(2.1-0.1 < shag || shag <= 0);
                Console.WriteLine("Значение x\tРезультат");
                for(double i = 0.1; i < 2.2; i += shag)
                {
                    y = Math.Pow(i, 2) + Math.Sin(5 * i);
                    Console.Write($"{Convert.ToDecimal(i)}\t\t{Math.Round(y, 3)}\n");
                }
                do
                {
                    Console.Write("Введите шаг: ");
                    shag = Convert.ToDouble(Console.ReadLine());
                } while (9 * Math.PI / 5 - (-Math.PI / 5) < shag || shag <= 0);
                Console.WriteLine("\nЗначение x\tРезультат");
                for (double i = -Math.PI/5; i <= 9*Math.PI/5; i+=shag)
                {
                    if(i < 0)
                    {
                        y = 2 - i;
                    }
                    else if(i >= 0 && i <= 2.5)
                    {
                        y = 1 - 3 * Math.Log(Math.Abs(1 - i));
                    }
                    else
                    {
                        y = Math.Sin(2.3 * i - 1);
                    }
                    Console.WriteLine($"{Math.Round(i, 3)}\t\t{Math.Round(y, 3)}");
                }
                break;
            case 0:
                exit = 0;
                break;
            default:
                Console.WriteLine("Такого задания нет.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Неверные данные");
    }
    catch(OverflowException)
    {
        Console.WriteLine("Неверные данные");
    }
}