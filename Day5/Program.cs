static double min_znach(double a, double b)
{
    return (a < b) ? a : b;
}
static double min_reference(ref double res, double a, double b)
{
    return (a < b) ? res = a : res = b;
}
static double min_out(out double res, double a, double b)
{
    return (a < b) ? res = a : res = b;
}
static void f_znach(double a, double b, double h = 0.1)
{
    double res = 0;
    for(;a < b; a+=h)
    {
        if (a >= 0.9) res = 1 / Math.Pow(0.1 + a, 2);
        else if (a >= 0) res = 0.2 * a + 0.1;
        else res= Math.Pow(a, 2) + 0.2;
        Console.WriteLine($"{a:f1}:{res:f3}");
    }
}
static void f_ref(ref double res, double a, double b, double h = 0.1)
{
    res = 0;
    for(;a < b; a+=h)
    {
        if (a >= 0.9) res = 1 / Math.Pow(0.1 + a, 2);
        else if (a >= 0) res = 0.2 * a + 0.1;
        else res = Math.Pow(a, 2) + 0.2;
        Console.WriteLine($"{a:f1}:{res:f3}");
    }
}
static double task1_znach(int t)
{
    double res = 0;
    for(int i = 5; i < t; i+=7)
    {
        res += (Math.Sqrt(i)+i) / 2;
    }
    return res;
}
static void task1_ref(ref double r, int t)
{
    for(int i = 5; i < t; i+=7)
    {
        r += (Math.Sqrt(i)+i) / 2;
    }
}
static void task1_out(out double r, int t)
{
    r = 0;
    for(int i = 5; i < t; i+=7)
    {
        r += (Math.Sqrt(i)+i) / 2;
    }
}
static void f_out(out double res, double a, double b, double h = 0.1)
{
    res = 0;
    for(;a < b; a+=h)
    {
        if (a >= 0.9) res = 1 / Math.Pow(0.1 + a, 2);
        else if (a >= 0) res = 0.2 * a + 0.1;
        else res = Math.Pow(a, 2) + 0.2;
        Console.WriteLine($"{a:f1} : {res:f3}");
    }
}
static void perevod(int number)
{
    if (number > 0)
    {
        perevod(number / 2);
        Console.Write(number % 2);
    }
    else
    {
        return;
    }
}
static void perevod_ref(ref int iter, int number, ref int[] s)
{
    if (number > 0)
    {
        perevod(number / 2);
        s[iter++] = number % 2;
    }
    else
    {
        return;
    }
}
static void perevod_out(ref int iter, int number, out int[] s)
{
    s = new int[1];
    if (number > 0)
    {
        perevod(number / 2);
        s[iter++] = number % 2;
    }
}
static int fact1_znach(int n)
{
    if(n<=0)
    {
        return 1;
    }
    else
    {
        return n * fact1_znach(n - 1);
    }
}
static int fact2_znach(int n)
{
    if(n<=0)
    {
        return 1;
    }
    else
    {
        return n * fact2_znach(n - 2);
    }
}
static void fact1_ref(ref int n)
{
    n = fact1_znach((int)n);
}
static void fact2_ref(ref int n)
{
    n = fact2_znach((int)n);
}
static void fact1_out(out int n, int num)
{
    n = fact1_znach(num);
}
static void fact2_out(out int n, int num)
{
    n = fact2_znach(num);
}
int exit = 1;
int task, method;
while(exit!=0)
{
    try
    {
        Console.Write("\n1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\n5 - Задание 5\n0 - Выход\nПункт: ");
        task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 1:
                Console.Write("\n1 - По значению\n2 - Через ref\n3 - Через out\nПункт: ");
                method = Convert.ToInt32(Console.ReadLine());
                double a, b, res1 = 0, res2 = 0, z;
                switch (method)
                {
                    case 1:
                        Console.Write("a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        z = min_znach(3 * a, 2 * b) + min_znach(a - b, b + a);
                        Console.WriteLine($"Result: {z}");
                        break;
                    case 2:
                        Console.Write("a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        z = min_reference(ref res1, 3 * a, 2 * b) + min_reference(ref res2, a - b, b + a);
                        Console.WriteLine($"Result: {z}");
                        break;
                    case 3:
                        Console.Write("a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        z = min_out(out res1, 3 * a, 2 * b) + min_out(out res2, a - b, b + a);
                        Console.WriteLine($"Result: {z}");
                        break;
                    default:
                        Console.WriteLine("Такого метода нет.");
                        break;
                }
                break;
            case 2:
                Console.Write("\n1 - По значению\n2 - Через ref\n3 - Через out\nПункт: ");
                method = Convert.ToInt32(Console.ReadLine());
                double x = 0, y = 0, h = 0, r = 0;
                switch (method)
                {
                    case 1:
                        Console.Write("x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        do
                        {
                            Console.Write("h: ");
                            h = Convert.ToDouble(Console.ReadLine());
                        } while (h <= 0);
                        f_znach(x, y, h);
                        break;
                    case 2:
                        Console.Write("x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        f_ref(ref r, x, y);
                        break;
                    case 3:
                        Console.Write("x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        f_out(out double result, x, y);
                        break;
                    default:
                        Console.WriteLine("Такого метода нет.");
                        break;
                }
                break;
            case 3:
                Console.Write("\n1 - По значению\n2 - Через ref\n3 - Через out\nПункт: ");
                method = Convert.ToInt32(Console.ReadLine());
                int gran = 0;
                switch (method)
                {
                    case 1:
                        Console.Write("Граница: ");
                        gran = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {task1_znach(gran)}");
                        break;
                    case 2:
                        Console.Write("Граница: ");
                        gran = Convert.ToInt32(Console.ReadLine());
                        double res_task1 = 0;
                        task1_ref(ref res_task1, gran);
                        Console.WriteLine($"Результат: {res_task1}");
                        break;
                    case 3:
                        Console.Write("Граница: ");
                        gran = Convert.ToInt32(Console.ReadLine());
                        task1_out(out double res1_task1, gran);
                        Console.WriteLine($"Результат: {res1_task1}");
                        break;
                    default:
                        Console.WriteLine("Такого метода нет.");
                        break;
                }
                break;
            case 4:
                Console.Write("\n1 - По значению\n2 - Через ref\n3 - Через out\nПункт: ");
                method = Convert.ToInt32(Console.ReadLine());
                int number;
                switch (method)
                {
                    case 1:
                        Console.Write("Число: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        perevod(number);
                        break;
                    case 2:
                        Console.Write("Число: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        int iter = 0;
                        int[] s = new int[1];
                        perevod_ref(ref iter, number, ref s);
                        foreach(int i in s) Console.Write(i);
                        break;
                    case 3:
                        Console.Write("Число: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        int iter1 = 0;
                        int[] s1 = new int[1];
                        perevod_out(ref iter1, number, out s1);
                        foreach (int i in s1) Console.Write(i);
                        break;
                    default:
                        Console.WriteLine("Такого метода нет.");
                        break;
                }
                break;
            case 5:
                Console.Write("\n1 - По значению\n2 - Через ref\n3 - Через out\nПункт: ");
                method = Convert.ToInt32(Console.ReadLine());
                int num;
                switch (method)
                {
                    case 1:
                        Console.Write("Число: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Факториал: {fact1_znach(num)}\nДвойной факториал: {fact2_znach(num)}");
                        break;
                    case 2:
                        Console.Write("Число: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        int num1 = num;
                        fact1_ref(ref num);
                        fact2_ref(ref num1);
                        Console.WriteLine($"Факториал: {num}\nДвойной факториал: {num1}");
                        break;
                    case 3:
                        Console.Write("Число: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        fact1_out(out int res3, num);
                        fact2_out(out int res4, num);
                        Console.WriteLine($"Факториал: {res3}\nДвойной факториал: {res4}");
                        break;
                    default:
                        Console.WriteLine("Такого метода нет.");
                        break;
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
        Console.WriteLine("Введите корректные данные.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Введите корректные данные.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex}");
    }
}