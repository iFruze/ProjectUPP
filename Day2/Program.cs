Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.Write("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\n5 - Задание 5\n6 - Задание 6\nПункт: ");
int punct = Convert.ToInt32(Console.ReadLine());
if (punct == 1)
{
    bool A = true, B = false, C = false;
    Console.Write($"a) {(A | !A & B) | C}\nб) {!A | A&(B|C)}\nв) {(A|B&!C) & C}");
}
else if (punct == 2)
{
    int a, b, c;
    Console.Write("Введите число A: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число C: ");
    c = Convert.ToInt32(Console.ReadLine());
    if(a % 2 == 0 || b % 2 == 0)
    {
        Console.WriteLine("Только одно из чисел A и B четное.");
    }
    else
    {
        Console.WriteLine("Числа A и B нечётные.");
    }
    if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0)
    {
        Console.WriteLine("Каждое из чисел A, B, C кратно трём.");
    }
    else
    {
        Console.WriteLine("Числа A, B, C не кратны трём.");
    }
}
else if (punct == 3)
{
    double x, y;
    Console.Write("Введиите точку x: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введиите точку y: ");
    y = Convert.ToDouble(Console.ReadLine());
    if(x > 0 && y > 0)
    {
        Console.WriteLine($"Точка ({x}, {y}) пренадлежит первой четверти.\nВ этой четверти работают следующие уравнения:\n1) x = 1\n2) y = 1\n3) y = -x+1");
        if(y <= 1 && x <= 1)
        {
            if (y >= -x + 1)
            {
                Console.WriteLine("Точка входит в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область.");
            }
        }
        else
        {
            Console.WriteLine("Точка не входит в заштрихованную область.");
        }
    }
    else if(y < 0 && x > 0)
    {
        Console.WriteLine($"Точка ({x}, {y}) пренадлежит четвёртой четверти.\nВ этой четверти работают следующие уравнения:\n1) x = 1\n2) y = -1\n3) y = x+1");
        if (y >= -1 && x <= 1)
        {
            if (y <= x + 1)
            {
                Console.WriteLine("Точка входит в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область.");
            }
        }
        else
        {
            Console.WriteLine("Точка не входит в заштрихованную область.");
        }
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine($"Точка ({x}, {y}) пренадлежит третьей четверти.\nВ этой четверти работают следующие уравнения:\n1) x = -1\n2) y = -1\n3) y = -x-1");
        if (y >= -1 && x >= -1)
        {
            if (y <= -x - 1)
            {
                Console.WriteLine("Точка входит в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область.");
            }
        }
        else
        {
            Console.WriteLine("Точка не входит в заштрихованную область.");
        }
    }
    else
    {
        Console.WriteLine($"Точка ({x}, {y}) пренадлежит второй четверти.\nВ той четверти работают следующие уравнения:\n1) x = -1\n2) y = 1\n3) y = x+1");
        if (y <= 1 && x >= -1)
        {
            if (y >= x + 1)
            {
                Console.WriteLine("Точка входит в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка не входит в заштрихованную область.");
            }
        }
        else
        {
            Console.WriteLine("Точка не входит в заштрихованную область.");
        }
    }
}
else if (punct == 4) 
{
    int c1, c2;
    Console.Write("Введите первое число: ");
    c1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    c2 = Convert.ToInt32(Console.ReadLine());
    double sum_of_kvad = Math.Pow(c1, 2) + Math.Pow(c2, 2);
    double kvad_of_sum = Math.Pow(c1+c2, 2);
    if (sum_of_kvad > kvad_of_sum) 
    {
        Console.WriteLine("Сумма квадратов больше квадрата суммы");
    }
    else if(sum_of_kvad < kvad_of_sum)
    {
        Console.WriteLine("Сумма квадратов меньше квадрата суммы");
    }
    else
    {
        Console.WriteLine("Сумма квадратов равна квадрату суммы");
    }
}
else if (punct == 5)
{
    int c1, c2;
    Console.Write("Введите первое число: ");
    c1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    c2 = Convert.ToInt32(Console.ReadLine());
    double polu_sum = (Math.Abs(c1) + Math.Abs(c2))/2;
    double pr_mod = Math.Sqrt(Math.Abs(c1) * Math.Abs(c2));
    Console.WriteLine($"Полусумма абсолютных величин этих чисел = {polu_sum}\nКвадратный корень произведения модулей этих чисел = {pr_mod}");
}
else if(punct == 6)
{
    double a, b, c;
    Console.Write("Введите коэфициент a, a не равно 0: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 0)
    {
        Console.WriteLine("а не должно быть равно 0.");
    }
    else
    {
        Console.Write("Введите коэфициент b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите коэфициент c: ");
        c = Convert.ToInt32(Console.ReadLine());
        double d = ((b * b) - (4 * a * c));
        if(d > 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
        }
        else if (d == 0)
        {
            double x = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("Корней нет.");
        }
    }
}
else
{

    Console.WriteLine("y = -x\nТакого пункта нет.");
}
