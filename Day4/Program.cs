try
{
    int exit = 1;
    while (exit == 1)
    {
        Console.Write("1 - Мишень\n2 - Ряд Тейлора\n3 - Лабораторная Шаляпина\n0 - Выход\nПункт: ");
        int p = Convert.ToInt32(Console.ReadLine());
        switch (p)
        {
            case 0:
                exit = 0;
                break;
            case 1:
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Попытка №{i}");
                    double x, y, r;
                    Console.Write("Введите х: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите у: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите радиус окружности: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    if ((x > 0 && y > 0 && y >= x && Math.Pow(x, 2) + Math.Pow(y, 2) <= r * r) || ((x < 0 && y < 0 && y <= x && Math.Pow(x, 2) + Math.Pow(y, 2) <= r * r)))
                    {
                        Console.WriteLine("Вы попали!");
                    }
                    else
                    {
                        Console.WriteLine("Вы не попали.");
                    }
                }
                break;
            case 2:
                Console.Write("Введите количество итераций: ");
                int iter = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число x: ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                double sum = 1;
                for (int i = 1; i <= iter; i++)
                {
                    double fac = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        fac *= j;
                    }
                    sum += Math.Pow(x1, i) / fac;
                }
                Console.WriteLine($"Ответ: {Math.Round(sum, 3)}");
                break;
            case 3:
                double a, b, h;
                do 
                {
                    Console.Write("Введите значение a (начало отсчёта): ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите значение b (начало отсчёта): ");
                    b = Convert.ToDouble(Console.ReadLine());
                } while (b<=a);
                do
                {
                    Console.Write("Введите шаг: ");
                    h = Convert.ToDouble(Console.ReadLine());
                }while(b-a<=h);
                int n;
                do
                {
                    Console.Write("Введите количество итераций: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n <= 0);
                double s=0, y2=0;
                Console.Write("x\tS(x)\tY(x)\tY(x)-S(x)\n");
                for(double x2 = a; x2<=b;x2+=h)
                {
                    s = 0;
                    for(int i = 0; i < n; i++)
                    {
                        double fac = 1;
                        for (int j = 1; j <= 2*i+1; j++)
                        {
                            fac *= j;
                        }
                        s += Math.Pow(-1, i) * (Math.Pow(x2, 2 * i + 1) / fac);
                    }
                    y2 = Math.Sin(x2);
                    Console.Write($"{Math.Round(x2,3)}\t{Math.Round(s, 3)}\t{Math.Round(y2,3)}\t{Math.Round(Math.Abs(y2-s), 3)}\n");
                }
                break;
            default:
                Console.WriteLine("Такого задания нет");
                break;
        }
    }
}
catch(FormatException)
{
    Console.WriteLine("Error");
}
catch(OverflowException)
{
    Console.WriteLine("Error");
}