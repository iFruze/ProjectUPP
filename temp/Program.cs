////try
////{
////    double x, e, b, h;
////    do
////    {
////        Console.Write("Введите x (x > 0): ");
////        x = Convert.ToDouble(Console.ReadLine());
////    } while (x <= 0);
////    Console.Write("Введите b: ");
////    b = Convert.ToDouble(Console.ReadLine());
////    Console.Write("Введите h: ");
////    h = Convert.ToDouble(Console.ReadLine());
////    Console.Write("Введите e: ");
////    e = Convert.ToDouble(Console.ReadLine());
////    while (x < b)
////    {
////        double ch = 1, sum = 0;
////        for (int c = 0; Math.Abs(ch) > e; c++)
////        {
////            ch *= 2 * (Math.Pow(x - 1, 2 * c + 1) / ((2 * c + 1) * (Math.Pow(x + 1, 2 * c + 1))));
////            sum += ch;
////        }
////        Console.WriteLine($"{Math.Round(x, 3)}\t{Math.Round(sum, 3)}\t{Math.Round(Math.Log(x), 3)}\t{Math.Round(Math.Log(x) - sum, 3)}");
////        x += h;
////    }
////}
////catch (FormatException)
////{
////    Console.WriteLine("Error");
////}
////catch (OverflowException)
////{
////    Console.WriteLine("Error");
////}
////Console.WriteLine(String.Format("{0,10:0.0}", 123.4567)); // " 123.5"

////Console.WriteLine(String.Format("{0,-10:0.0}", 123.4567)); // "123.5 "

////Console.WriteLine(String.Format("{0,10:0.0}", -123.4567)); // " -123.5"

////Console.WriteLine(String.Format("{0,-10:0.0}", -123.4567)); // "-123.5 "





////Сортировка массива по строкам в порядке увеличения их суммы
////Random r = new Random();
////int[,] arr = new int[5, 4];
////for(int i = 0; i < 5; i++)
////{
////    for(int j = 0; j < 4; j++)
////    {
////        arr[i, j] = r.Next(1,10);
////    }
////}
////for(int i = 0; i < 5; i++)
////{
////    for(int j = 0; j < 4; j++)
////    {
////        Console.Write(arr[i,j] + "\t");
////    }
////    Console.WriteLine();
////}
////for(int i = 0;i < 5-1; i++)
////{

////    for(int k = 0; k < 5-1-i;k++)
////    {
////        int sum1 = 0;
////        for (int j = 0; j < 4; j++)
////        {
////            sum1 += arr[k, j];
////        }
////        int sum2 = 0;
////        for(int h = 0; h < 4; h++)
////        {
////            sum2+= arr[k+1,h];
////        }
////        if (sum1 > sum2)
////        {
////            int[] mas = new int[4];
////            for (int t = 0; t < 4; t++)
////            {
////                mas[t] = arr[k, t];
////            }
////            for (int t = 0; t < 4; t++)
////            {
////                arr[k, t] = arr[k + 1, t];
////            }
////            for(int t = 0; t < 4; t++)
////            {
////                arr[k + 1, t] = mas[t];
////            }
////        }
////    }
////}
////Console.WriteLine("Sorted:");
////for (int i = 0; i < 5; i++)
////{
////    for (int j = 0; j < 4; j++)
////    {
////        Console.Write(arr[i, j] + "\t");
////    }
////    Console.WriteLine();
////}






////Задание 1
////int n = Convert.ToInt32(Console.ReadLine());
////int[] arr = new int[n];
////Random rand = new Random();
////for (int j = 0; j < arr.Length; j++)
////{
////    arr[j] = rand.Next(1, 10);
////}
////foreach (int g in arr)
////{
////    Console.Write("{0,5:0}", g);
////}
////int minI = 0, maxI = 0;
////for (int t = 0; t < arr.Length; t++)
////{
////    if (arr[t] < arr[minI])
////    {
////        minI = t;
////    }
////    if (arr[t] > arr[maxI])
////    {
////        maxI = t;
////    }
////}
////if (minI > maxI)
////{
////    int temp = minI;
////    minI = maxI;
////    maxI = temp;
////}
////int pr = 1;
////for (int j = minI + 1; j < maxI; j++)
////{
////    pr *= arr[j];
////}
////Console.WriteLine($"\nПроизведение: {pr}");
///////////////////////////////////////////////////////////////////////////////////////
////int n = Convert.ToInt32(Console.ReadLine());
////Array arr = Array.CreateInstance(typeof(int), n);
////for (int i = 0; i < arr.Length; i++)
////{
////    Console.Write($"arr[{i}] = ");
////    int t = Convert.ToInt32(Console.ReadLine());
////    arr.SetValue(t, i);
////}
////int iMax = 0, iMin = 0;
////for (int i = 0; i < arr.Length; i++)
////{
////    if (Convert.ToInt32(arr.GetValue(i)) > Convert.ToInt32(arr.GetValue(iMax))) iMax = i;
////    if (Convert.ToInt32(arr.GetValue(i)) < Convert.ToInt32(arr.GetValue(iMin))) iMin = i;
////}
////if (iMin > iMax)
////{
////    int temp = iMin;
////    iMin = iMax;
////    iMax = temp;
////}
////int pr = 1;
////foreach (int i in new ArraySegment<int>((int[])arr, iMin + 1, iMax - 1)) pr *= i;
////Console.WriteLine($"Произведение = {pr}");

////Задание 2
////Console.Write("Размерность массива: ");
////int n = Convert.ToInt32(Console.ReadLine());
////int[] arr = new int[n];
////int plus = 0, minus = 0, nol = 0;
////Random rand = new Random();
////for (int i = 0; i < n; i++)
////{
////    arr[i] = rand.Next(-10, 10);
////    if (arr[i] > 0)
////    {
////        plus++;
////    }
////    else if (arr[i] < 0)
////    {
////        minus++;
////    }
////    else if (arr[i] == 0)
////    {
////        nol++;
////    }
////}
////int[] polozh = new int[plus];
////int[] otr = new int[minus];
////int[] nole = new int[nol];
////int iter1 = 0;
////int iter2 = 0;
////int iter3 = 0;
////for (int i = 0; i < arr.Length; i++)
////{
////    if (arr[i] > 0)
////    {
////        polozh[iter1++] = arr[i];
////    }
////    else if (arr[i] < 0)
////    {
////        otr[iter2++] = arr[i];
////    }
////    else
////    {
////        nole[iter3++] = arr[i];
////    }
////}
////int k = 0;
////int[] mas = new int[n];
////for (int i = 0; i < polozh.Length; i++)
////{
////    mas[k++] = polozh[i];
////}
////for (int i = 0; i < otr.Length; i++)
////{
////    mas[k++] = otr[i];
////}
////for (int i = 0; i < nole.Length; i++)
////{
////    mas[k++] = nole[i];
////}
////Console.WriteLine("До");
////foreach (int j in arr)
////{
////    Console.Write("{0,5:0}", j);
////}
////Console.WriteLine("\nПосле");
////foreach (int j in mas)
////{
////    Console.Write("{0,5:0}", j);
////}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////int n = Convert.ToInt32(Console.ReadLine());
////Array arr = Array.CreateInstance(typeof(int), n);
////for (int i = 0; i < arr.Length; i++)
////{
////    Console.Write($"arr[{i}] = ");
////    int t = Convert.ToInt32(Console.ReadLine());
////    arr.SetValue(t, i);
////}
////Array plus = Array.FindAll<int>((int[])arr, x => x > 0);
////Array minus = Array.FindAll<int>((int[])arr, x => x < 0);
////Array nole = Array.FindAll<int>((int[])arr, x => x == 0);
////Array.Copy(plus, 0, arr, 0, plus.Length);
////Array.Copy(minus, 0, arr, plus.Length, minus.Length);
////Array.Copy(nole, 0, arr, plus.Length + minus.Length, nole.Length);
////foreach (int i in arr) Console.Write("{0, 5:0}", i);
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////Задание 3
////int m, n;
////Console.Write("Введите кол-во строк: ");
////m = Convert.ToInt32(Console.ReadLine());
////Console.Write("Введите кол-во столбцов: ");
////n = Convert.ToInt32(Console.ReadLine());
////int[,] arr = new int[m, n];
////for (int i = 0; i < m; i++)
////{
////    for (int j = 0; j < n; j++)
////    {
////        Console.Write("Введите элемент матрицы: ");
////        arr[i, j] = Convert.ToInt32(Console.ReadLine());
////    }
////}
////int sum = 0;
////for (int i = 0; i < m; i++)
////{
////    for (int j = 0; j < n; j++)
////    {
////        if (i < j)
////        {
////            sum += arr[i, j];
////        }
////    }
////}
////Console.WriteLine("Матрица:");
////for (int i = 0; i < m; i++)
////{
////    for (int j = 0; j < n; j++)
////    {
////        Console.Write(arr[i, j] + "\t");
////    }
////    Console.WriteLine();
////}
////Console.WriteLine($"Сумма: {sum}");
////using System.Diagnostics.CodeAnalysis;

////int m, n;
////do
////{
////    Console.Write("Кол-во строк: ");
////    m = Convert.ToInt32(Console.ReadLine());
////    Console.Write("Кол-во столбцов: ");
////    n = Convert.ToInt32(Console.ReadLine());
////} while (m <= 0 || n <= 0);
////Array arr = new int[m, n];
////for (int i = 0; i < arr.GetLength(0); i++)
////{
////    for (int j = 0; j < arr.GetLength(1); j++)
////    {
////        Console.Write($"arr[{i}][{j}] = ");
////        int t = Convert.ToInt32(Console.ReadLine());
////        arr.SetValue(t, i, j);
////    }
////}
////int sum = 0;
////for (int i = 0; i < arr.GetLength(0); i++)
////{
////    for (int j = 0; j < arr.GetLength(1); j++)
////    {
////        if (i < j) sum += Convert.ToInt32(arr.GetValue(i, j));
////    }
////}
////Console.WriteLine($"Сумма элементов выше главной диагонали: {sum}"); 

////Задание 4
////Console.Write("Размер матрицы: ");
////int n = Convert.ToInt32(Console.ReadLine());
////int[,] arr = new int[n, n];
////for (int i = 0; i < n; i++)
////{
////    for (int j = 0; j < n; j++)
////    {
////        Console.Write("Элемент: ");
////        arr[i, j] = Convert.ToInt32(Console.ReadLine());
////    }
////}
////int[] mas = new int[n];
////int iter = 0;
////for (int i = 0; i < n; i++)
////{
////    int max = arr[0, 0];
////    for (int j = 0; j < n; j++)
////    {
////        if (arr[i, j] > max)
////        {
////            max = arr[i, j];
////        }
////    }
////    mas[iter++] = max;
////}
////Console.WriteLine("Матрица");
////int i1 = 1;
////foreach (int x in arr)
////    if (i1++ % arr.GetLength(1) == 0)
////        Console.WriteLine(x);
////    else
////        Console.Write(x + "\t");
////Console.WriteLine("Максимальные элементы каждой строки");
////foreach (int j in mas)
////{
////    Console.WriteLine(j);
////}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////try
////{
////    int m, n;
////    do
////    {
////        Console.Write("Кол-во строк: ");
////        m = Convert.ToInt32(Console.ReadLine());
////        Console.Write("Кол-во столбцов: ");
////        n = Convert.ToInt32(Console.ReadLine());
////    } while (m <= 0 || n <= 0);
////    Array arr = new int[m, n];
////    for (int i = 0; i < arr.GetLength(0); i++)
////    {
////        for (int j = 0; j < arr.GetLength(1); j++)
////        {
////            Console.Write($"arr[{i}][{j}] = ");
////            int t = Convert.ToInt32(Console.ReadLine());
////            arr.SetValue(t, i, j);
////        }
////    }
////    int index = 0;
////    Array max = Array.CreateInstance(typeof(int), arr.GetLength(1));
////    for (int i = 0; i < arr.GetLength(0); i++)
////    {
////        int temp = Convert.ToInt32(arr.GetValue(i, 0));
////        for (int j = 0; j < arr.GetLength(1); j++)
////        {
////            if (Convert.ToInt32(arr.GetValue(i, j)) > temp)
////            {
////                temp = Convert.ToInt32(arr.GetValue(i, j));
////            }
////        }
////        max.SetValue(temp, index++);
////    }
////    foreach (int i in max) Console.WriteLine("{0,5:0}", i);
////}
////catch (FormatException)
////{
////    Console.WriteLine("Error");
////}
////catch (OverflowException)
////{
////    Console.WriteLine("Error");
////}

////Task2
////for(int i = 0; i < s.Length; i++)
////{
////    int res;
////    int index = Array.FindIndex<char>((char[])mas, x => x == s[i]);
////    res = a * index + b;
////    if (res > 31)
////    {
////        res %= 32;
////    }
////    Console.WriteLine($"{s[i]} - {mas.GetValue(res)}");
////}


////Перевод дробных двоичных чисел в десятичную систему
//// Array cel = Array.CreateInstance(typeof(int), 3);
////Array drob = Array.CreateInstance(typeof(int), 2);
////for(int i = 0; i < 3; i++)
////{
////    int t = Convert.ToInt32(Console.ReadLine());
////    cel.SetValue(t, i);
////}
////for(int i = 0; i < 2; i++)
////{
////    int t = Convert.ToInt32(Console.ReadLine());
////    drob.SetValue(t, i);
////}
////double sum = 0;
////int step = cel.Length - 1; 
////for (int i = 0; i < 3; i++)
////{
////    sum += Convert.ToInt32(Convert.ToInt32(cel.GetValue(i)) * Math.Pow(2, step--));
////}
////for (int i = 0; i < 2; i++)
////{
////    sum += Convert.ToInt32(drob.GetValue(i)) * Math.Pow(2, step--);
////}
////Console.WriteLine(sum);






////Лабораторная №5
////по значению
////по ссылке
////in и out
////Task1
////static void Func1(double a, double b, double h)
////{
////    double result;
////    for (; a <= b; a += h)
////    {
////        result = (2 * Math.Sin(a)) / (Math.Pow(1 - a, 2));
////        Console.WriteLine($"{a,5:f1}{result,15:f6}");
////    }
////}
////static double Func4(double a) => (2 * Math.Sin(a)) / (Math.Pow(1 - a, 2));
////static void Func2(double a, double b, double h, ref double res)
////{
////    for (; a <= b; a += h)
////    {
////        res = (2 * Math.Sin(a)) / (Math.Pow(1 - a, 2));
////        Console.WriteLine($"{a,5:f1}{res,15:f6}");
////    }
////}
////static void Func3(double a, in double b, in double h, out double res)
////{
////    res = 0;
////    for (; a <= b; a += h)
////    {
////        res = (2 * Math.Sin(a)) / (Math.Pow(1 - a, 2));
////        Console.WriteLine($"{a,5:f1}{res,15:f6}");
////    }
////}
////try
////{
////    double a, b, h;
////    a = -Math.PI;
////    b = Math.PI;
////    Console.Write("Шаг: ");
////    h = Convert.ToDouble(Console.ReadLine());
////    Console.Write("1 - значение\n2 - ссылка\n3 - in и out\n4 - лямбда выражение\nПункт: ");
////    int p = Convert.ToInt32(Console.ReadLine());
////    switch (p)
////    {
////        case 1:
////            Func1(a, b, h);
////            break;
////        case 2:
////            double res = 0;
////            Func2(a, b, h, ref res);
////            Console.WriteLine($"Итоговый результат: {res:f5}");
////            break;
////        case 3:
////            double result;
////            Func3(a, b, h, out result);
////            Console.WriteLine($"Итоговый результат: {result:f5}");
////            break;
////        case 4:
////            for (; a <= b; a += h) Console.WriteLine($"{a,5:f1} : {Func4(a),15:f6}");
////            break;
////        default:
////            Console.WriteLine("Error");
////            break;
////    }
////}
////catch (FormatException)
////{
////    Console.WriteLine("Error");
////}
////catch (OverflowException)
////{
////    Console.WriteLine("Error");
////}



////static double task1(double x) => 1 / (x * x - 1);
////static void task2(int n, int m, string p)
////{
////    if (n == 1)
////    {
////        Console.WriteLine(p);
////        return;
////    }
////    for (int i = 2; i <= m; i++)
////    {
////        if (n % i == 0)
////        {
////            task2(n / i, i, p + i + " ");
////        }
////    }
////}
////static (int, int) MinMax(int[] arr)
////{
////    int min = int.MaxValue, max = int.MinValue;
////    for(int i = 0; i < arr.Length; i++)
////    {
////        if (arr[i] < min)
////        {
////            min = arr[i];
////        }
////        if (arr[i] > max)
////        {
////            max = arr[i];
////        }
////    }
////    return (min, max);
////}
////int ex = 1;
////while (ex != 0)
////{
////    try
////    {
////        Console.Write("\n1 - Задание 1\n2 - Задание 2\n3 - Кортеж\n0 - Выход\nПункт: ");
////        ex = Convert.ToInt32(Console.ReadLine());
////        switch (ex)
////        {
////            case 0:
////                break;
////            case 1:
////                Console.Write("Ввести х: ");
////                double x = Convert.ToDouble(Console.ReadLine());
////                try
////                {
////                    if (x == 1 || x == -1) throw new Exception();
////                    else Console.WriteLine($"При х = {x} фнукция принимает значение: {task1(x):f2}");
////                }
////                catch
////                {
////                    Console.WriteLine("Ошибка деления на 0. Введите другой х.");
////                }
////                break;
////            case 2:
////                try
////                {
////                    Console.Write("n: ");
////                    int n = Convert.ToInt32(Console.ReadLine());
////                    if (n <= 0) throw new Exception();
////                    task2(n, n, "");
////                }
////                catch
////                {
////                    Console.WriteLine("Введите n>0.");
////                }
////                break;
////            case 3:
////                int n23 = 0;
////                do
////                {
////                    Console.Write("Размер массива: ");
////                    n23 = Convert.ToInt32(Console.ReadLine());
////                } while (n23 <= 0);
////                Random r = new Random();
////                int[] arr = new int[n23];
////                for(int i = 0; i < arr.Length; i++)
////                {
////                    arr.SetValue(r.Next(1,25), i);
////                }
////                foreach(int i in arr) Console.Write(i + " ");
////                var (min, max) = MinMax(arr);
////                Console.WriteLine($"\nMin = {min}\nMax = {max}");
////                break;
////            default:
////                Console.WriteLine("Такого задания нет.");
////                break;
////        }
////    }
////    catch (FormatException)
////    {
////        Console.WriteLine("Введите корректные значения.");
////    }
////    catch (OverflowException)
////    {
////        Console.WriteLine("Введите корректные значения."); 
////    }
////}
//using System.Text;
//using System.Text.RegularExpressions;
//StringBuilder s = new StringBuilder(Console.ReadLine());
//Regex r1 = new Regex("\\s\\d{2}-\\d{2}-\\d{2}\\s");
//Regex r2 = new Regex("\\s\\d{3}-\\d{3}\\s");
//Regex r3 = new Regex("\\s\\d{3}-\\d{2}-\\d{2}\\s");
//MatchCollection rr1 = r1.Matches(s.ToString());
//MatchCollection rr2 = r2.Matches(s.ToString());
//MatchCollection rr3 = r3.Matches(s.ToString());
//if (rr1.Count > 0)
//{
//    foreach (Match match in rr1)
//        Console.WriteLine(match.Value);
//}
//if (rr2.Count > 0)
//{
//    foreach (Match match in rr2)
//        Console.WriteLine(match.Value);
//}
//if (rr3.Count > 0)
//{
//    foreach (Match match in rr3)
//        Console.WriteLine(match.Value);
//}

//using System.Text;
//using System.Text.RegularExpressions;
//using static System.Net.Mime.MediaTypeNames;
//string r = "Привет! Меня зовут Игорь и мне 23 года. Мой день рождения 1 декабря.";
//Console.WriteLine(Regex.Replace(r, @"\d+", ""));
//string r1 = "Hello Miss Marry and Mr. Jonson, how are you?";
//Console.WriteLine(Regex.Replace(r1, @"(Miss|Mr.|Ms.|Mrs.)", ""));
//string text = "Это пример пример текста с повторяющимися словами словами.";
//string pattern = @"\b(\w+)\s+\1\b";
//string replacement = @"$1";
//string result = Regex.Replace(text, pattern, replacement);
//Console.WriteLine(result);
using System.Data;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
//static void task1()
//{
//    Console.Write("Количество футболистов: ");
//    int size = Convert.ToInt32(Console.ReadLine());
//    football[] arr = new football[size];
//    for (int i = 0; i < size; i++)
//    {
//        string name, fam;
//        DateTime dr;
//        int day, month, year, age, countOfGames, countofGol;
//        position pos;
//        Console.Write("Имя футболиста: ");
//        name = Console.ReadLine();
//        Console.Write("Фамилия футболиста: ");
//        fam = Console.ReadLine();
//        Console.Write("Возраст футболиста: ");
//        age = Convert.ToInt32(Console.ReadLine());
//        Console.Write("День рождения футболиста: ");
//        day = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Месяц рождения футболиста: ");
//        month = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Год рождения футболиста: ");
//        year = Convert.ToInt32(Console.ReadLine());
//        int t = 0;
//        do
//        {
//            Console.Write("Позиция футболиста: \n1 - Вратарь\n2 - Нападающий\n3 - Защитник\n4 - Форвард\nПункт: ");
//            t = Convert.ToInt32(Console.ReadLine());
//        } while (t < 1 || t > 4);
//        pos = t switch
//        {
//            1 => position.Вратарь,
//            2 => position.Нападающий,
//            3 => position.Защитник,
//            4 => position.Форвард
//        };
//        Console.Write("Количество сыгранных игр: ");
//        countOfGames = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Количество забитых голов: ");
//        countofGol = Convert.ToInt32(Console.ReadLine());
//        arr[i] = new football(name, fam, pos, age, countOfGames, countofGol, new DateTime(year, month, day));
//    }
//    Console.WriteLine("Футболисты: ");
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item.ToString());
//    }
//    football.task(arr);
//}
//static void task2()
//{
//    empl[] arr = new empl[4];
//    for(int i = 0; i < arr.Length; i++)
//    {
//        string name;
//        string fam;
//        string otch;
//        pol p;
//        dolzh d;
//        DateTime dr;
//        int day, month, year;
//        Console.Write("Имя: ");
//        name = Console.ReadLine();
//        Console.Write("Фамилия: ");
//        fam = Console.ReadLine();
//        Console.Write("Отчество: ");
//        otch = Console.ReadLine();
//        int p1 = 0;
//        do
//        {
//            Console.Write("Пол: \n1 - Мужской\n2 - Женский\nПункт: ");
//            p1 = Convert.ToInt32(Console.ReadLine());
//        } while (p1 < 1 || p1 > 2);
//        p = p1 switch
//        {
//            1=>pol.Мужской,
//            2=>pol.Женский
//        };
//        int p2 = 0;
//        do
//        {
//            Console.Write("Должность: \n1 - Инженер\n2 - Слесарь\n3 - Мастер\n");
//            p2 = Convert.ToInt32(Console.ReadLine());
//        } while (p2 < 1 || p2 > 3);
//        d = p2 switch 
//        {
//            1=>dolzh.Инженер,
//            2=>dolzh.Слесарь,
//            3=>dolzh.Мастер
//        };
//        Console.Write("День рождения: ");
//        day = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Месяц рождения: ");
//        month = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Год рождения: ");
//        year = Convert.ToInt32(Console.ReadLine());
//        dr = new DateTime(year, month, day);
//        arr[i] = new empl(name, fam, otch, p, d, dr);
//    }
//    empl.task(arr);
//}
//static void task3()
//{
//    string name;
//    int day, year, month;
//    otdel t;
//    int[] s = new int[3];
//    Console.Write("Размер списка учащихся: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    group[] arr = new group[n];
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write("ФИО: ");
//        name = Console.ReadLine();
//        int p1 = 0;
//        do
//        {
//            Console.Write("1 - ПОИТ\n2 - Экономика\n3 - Логистика\nПункт: ");
//            p1 = Convert.ToInt32(Console.ReadLine());
//        } while (p1 < 1 || p1 > 3);
//        t = p1 switch
//        {
//            1 => otdel.ПОИТ,
//            2=>otdel.Экономика,
//            3=>otdel.Логистика
//        };
//        Console.Write("День рождения: ");
//        day = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Месяц рождения: ");
//        month = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Год рождения: ");
//        year = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Успеваемость: ");
//        for (int j = 0; j < 3; j++)
//        {
//            Console.Write("Цифра: ");
//            s[j] = Convert.ToInt32(Console.ReadLine());
//        }
//        arr[i] = new group(name, new DateTime(year,month, day), t, s);
//    }
//    group.task(arr);
//}
//while (true)
//{
//    int temp = 0;
//    do
//    {
//        Console.Write("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\nПункт: ");
//        temp = Convert.ToInt32(Console.ReadLine());
//    } while (temp < 1 || temp > 3);
//    switch (temp)
//    {
//        case 1:
//            task1();
//            break;
//        case 2:
//            task2(); 
//            break;
//        case 3:
//            task3();
//            break;
//    }
//}
string words = "aaaaaaaaaaaaaaaaaaaaaabcccccccccccde";
int n = words.Length;
StringBuilder word = new StringBuilder(words);
StringBuilder s = new StringBuilder();
for(int i = 0; i  < n; i++)
{
    int t = 0, ind = -1;
    for(int j = 0; j  <word.Length; j++)
    {
        if (word[j] != word[i] && char.IsLetter(word[j]))
        {
            ind = j - 1;
        }
    }
    for(int j = i; j <= ind; j++)
    {
        t++;
        word[j] = word[j + 1];
        n--;
    }
    if(t <= 9 && char.IsLetter(word[i]))
    {
        s.Append(t);
        s.Append(word[i]);
    }
    else if(t > 9 && char.IsLetter(word[i]))
    {
        while (t > 9) 
        {
            s.Append(9);
            s.Append(word[i]);
            t -= 9;
        }
        if(t > 0)
        {
            s.Append(t);
            s.Append(word[i]);
        }
        
    }
   // word.Replace(word[i], ' ');
}
Console.WriteLine(s.ToString());
public enum position {Вратарь, Защитник, Нападающий, Форвард};
public enum dolzh {Инженер, Слесарь, Мастер};
public enum pol {Мужской, Женский};
public enum otdel {ПОИТ, Экономика, Логистика};
public struct group
{
    public string name;
    public DateTime date;
    public otdel ot;
    public int[] ses = new int[3];
    public double bal;
    public group(string n, DateTime d, otdel t, int[] s)
    {
        name = n;
        date = d;
        ot = t;
        for(int i = 0; i < s.Length; i++)
        {
            ses[i] = s[i];
        }
        bal = s.Sum() / 3;
    }
    public static void task(group[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j].bal > arr[j + 1].bal)
                {
                    group temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Список учащихся упорядоченный по полю SES:");
        foreach(group i in arr)
        {
            Console.WriteLine(i.ToString());
        }
        Console.WriteLine("Список учащихся, возраст которых не превышает 20 лет на 01.12.2010:");
        for (int i = 0; i < arr.Length; i++)
        {
            DateTime g = new DateTime(2010, 12,1);
            if (g.Subtract(arr[i].date).Days /365 < 20)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
    }
    public override string ToString()
    {
        return $"ФИО: {this.name}\nДата рождения: {this.date.ToShortDateString()}\nОтделение: {this.ot}\nУспеваемость: {this.ses[0]} {this.ses[1]} {this.ses[2]}";
    }
}
public struct empl
{
    public string name;
    public string fam;
    public string otch;
    public int age;
    public pol p;
    public dolzh d;
    public DateTime dr;
    public empl(string n, string f, string o, pol pp, dolzh dd, DateTime date)
    {
        this.name = n;
        this.fam = f;
        this.otch = o;
        this.p = pp;
        this.d = dd;
        this.dr = date;
        age = DateTime.Now.Subtract(date).Days / 365;
    }
    public static void task(empl[] arr)
    {
        Console.WriteLine("Инженеры пенсионного возраста:");
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i].p==pol.Мужской && arr[i].age > 65 && arr[i].d == dolzh.Инженер)||(arr[i].p == pol.Женский && arr[i].age > 60 && arr[i].d == dolzh.Инженер))
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
    }
    public override string ToString()
    {
        return $"Имя: {this.name}\nФамилия: {this.fam}\nОтчество: {this.otch}\nВозраст: {this.age}\nДата рождения: {this.dr.ToShortDateString()}\nПол: {this.p}\nДолжность: {this.d}";
    }
}
public struct football
{
    public string name;
    public string fam;
    public position pos;
    public int age;
    public int countGames;
    public int countGol;
    public DateTime dr;
    public football(string n, string fam, position p, int a, int c1, int c2, DateTime d)
    {
        this.name = n;
        this.fam = fam;
        this.pos = p;
        this.age = a;
        this.countGames = c1;
        this.countGol = c2;
        this.dr = d;
    }
    public override string ToString()
    {
        return $"Имя: {this.name}\nФамилия: {this.fam}\nВозраст: {this.age}\nДата рождения: {this.dr.ToShortDateString()}\nПозиция: {this.pos}\nКоличество сыгранных игр: {this.countGames}\nКоличество забитых голов: {this.countGol}";
    }
    public static void task(football[] arr)
    {
        football max = arr[0];
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].pos == position.Форвард)
            {
                if (arr[i].countGol > max.countGol)
                {
                    max = arr[i];
                }
            }
            if (arr[i].countGames < 5)
            {
                Console.WriteLine($"{arr[i].name} {arr[i].fam} сыграл меньше 5 игр.");
            }
        }
        if(max.pos != position.Форвард)
        {
            Console.WriteLine("Форвардов нет.");
        }
        else
        {
            Console.WriteLine($"Лучший форвард: {max.name} {max.fam}! Он забил {max.countGol} голов.");
        }
    }
}
