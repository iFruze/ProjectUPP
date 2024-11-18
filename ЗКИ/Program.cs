int exit = 1;
while (exit != 0)
{
    try
    {
        Console.Write("\nЛабораторная работа №2\n1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\n0 - Выход\nПункт: ");
        int punct = Convert.ToInt32(Console.ReadLine());
        switch (punct)
        {
            case 0:
                exit = 0;
                break;
            case 1:
                int a, b, k;
                Console.Write("k: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Строка: ");
                string s = Console.ReadLine();
                Array mas = Array.CreateInstance(typeof(char), 32);
                char r = 'а';
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        Console.Write(" ");
                    }
                    else if ((int)s[i] >= 0 && (int)s[i] <= 128)
                    {
                        Console.Write(s[i]);
                    }
                    else
                    {
                        r = s[i];
                        r = Convert.ToChar(r + k);
                        Console.Write(r);
                    }
                }
                break;
            case 2:
                Console.Write("a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Строка: ");
                s = Console.ReadLine();
                mas = Array.CreateInstance(typeof(char), 32);
                r = 'а';
                for (int i = 0; i < 32; i++)
                {
                    mas.SetValue(Convert.ToChar(r++), i);
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        Console.Write(' ');
                    }
                    else if ((int)s[i] >= 0 && (int)s[i] <= 128)
                    {
                        Console.Write(s[i]);
                    }
                    else
                    {
                        int res;
                        int index = Array.FindIndex<char>((char[])mas, x => x == s[i]);
                        res = a * index + b;
                        if (res > 31)
                        {
                            res %= 32;
                        }
                        Console.Write($"{mas.GetValue(res)}");
                    }
                }
                break;
            case 3:
                Console.Write("k: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ключ слово: ");
                s = Console.ReadLine();
                Console.Write("Строка: ");
                string key = Console.ReadLine();
                mas = Array.CreateInstance(typeof(char), 32);
                r = 'а';
                for (int i = 0; i < 32; i++)
                {
                    mas.SetValue(Convert.ToChar(r++), i);
                }
                Array result = Array.CreateInstance(typeof(char), 32);
                int i1 = k;
                for (int i = 0; i < s.Length; i++)
                {
                    bool f = true;
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (s[i] == Convert.ToChar(result.GetValue(j)))
                        {
                            f = false;
                        }
                    }
                    if (f == false)
                    {
                        continue;
                    }
                    result.SetValue(s[i], i1++);
                }
                int pos = i1;
                char t = 'а';
                for (int i = i1; pos < result.Length; i++)
                {
                    bool f = true;
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (t == Convert.ToChar(result.GetValue(j)))
                        {
                            f = false;
                        }
                    }
                    if (f == false)
                    {
                        t++;
                    }
                    else
                    {
                        result.SetValue(t++, pos++);
                    }
                }
                pos = 0;
                for (int i = i1; pos < k; i++)
                {
                    bool f = true;
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (t == Convert.ToChar(result.GetValue(j)))
                        {
                            f = false;
                        }
                    }
                    if (f == false)
                    {
                        t++;
                    }
                    else
                    {
                        result.SetValue(t++, pos++);
                    }
                }
                foreach (char x in result) Console.Write(x + " ");
                Console.WriteLine();
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == ' ')
                    {
                        Console.Write(" ");
                    }
                    else if ((int)key[i] >= 0 && (int)key[i] <= 128)
                    {
                        Console.Write(s[i]);
                    }
                    else
                    {
                        int ind = Array.FindIndex<char>((char[])mas, x => x == key[i]);
                        Console.Write(result.GetValue(ind));
                    }
                }
                break;
            case 4:
                Console.Write("a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Строка: ");
                s = Console.ReadLine();
                mas = Array.CreateInstance(typeof(char), 32);
                r = 'а';
                for (int i = 0; i < 32; i++)
                {
                    mas.SetValue(Convert.ToChar(r++), i);
                }
                int temp;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        Console.Write(" ");
                    }
                    else if ((int)s[i] >= 0 && (int)s[i] <= 128)
                    {
                        Console.Write(s[i]);
                    }
                    else
                    {
                        int res;
                        int index = i;
                        temp = Array.FindIndex<char>((char[])mas, x => x == s[i]);
                        res = temp + (a * index + b);
                        if (res > 31)
                        {
                            res %= 32;
                        }
                        Console.Write($"{mas.GetValue(res)}");
                    }
                }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Введите число...");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Вышли за размерность..");
    }
    catch (Exception)
    {
        Console.WriteLine("Error");
    }
}
