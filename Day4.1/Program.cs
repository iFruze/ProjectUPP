using Microsoft.Win32.SafeHandles;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

int exit = 1;
Random rand = new Random();
while(exit != 0)
{
    try
    {
        Console.Write("1 - Работа с одномерным массивом\n2 - Работа с двумерным массивом\n0 - Выход\nПункт: ");
        int punct = Convert.ToInt32(Console.ReadLine());
        int p;
        switch(punct)
        {
            case 0:
                exit = 0;
                break;
            case 1:
                Console.Write("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n0 - Выход\nПункт: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch(p)
                {
                    case 1:
                        int n1;
                        do
                        {
                            Console.Write("Размерность массива: ");
                            n1 = Convert.ToInt32(Console.ReadLine());
                        } while (n1 <= 0);
                        Array arr1 = Array.CreateInstance(typeof(int), n1);
                        for(int i = 0; i < arr1.GetLength(0); i++)
                        {
                            arr1.SetValue(rand.Next(0, 20), i);
                        }
                        Array temp = Array.FindAll<int>((int[])arr1, x=>x%2==0);
                        Console.WriteLine($"Количество чётных элементов массива: {temp.Length}");
                        break;
                    case 2:
                        int n2;
                        do
                        {
                            Console.Write("Размерность массива: ");
                            n2 = Convert.ToInt32(Console.ReadLine());
                        } while (n2 <= 0);
                        Array arr2 = Array.CreateInstance(typeof(int), n2);
                        Array arr3 = Array.CreateInstance(typeof(int), n2);
                        for (int i = 0; i < arr2.GetLength(0); i++)
                        {
                            arr2.SetValue(rand.Next(0, 20), i);
                            arr3.SetValue(rand.Next(0, 20), i);
                        }
                        Array arr4 = Array.CreateInstance(typeof(int), n2);
                        for(int i = 0; i  < arr4.GetLength(0);i++)
                        {
                            if(i%2 == 0)
                            {
                                arr4.SetValue(Convert.ToInt32(arr2.GetValue(i+1)), i);
                            }
                            else
                            {
                                arr4.SetValue(Convert.ToInt32(arr3.GetValue(i - 1)), i);
                            }
                        }
                        foreach (int x in arr2) Console.Write("{0,5:0}", x);
                        Console.WriteLine();
                        foreach (int x in arr3) Console.Write("{0,5:0}", x);
                        Console.WriteLine();
                        foreach (int x in arr4) Console.Write("{0,5:0}", x);
                        Console.WriteLine();
                        break;
                    case 3:
                        int n3;
                        do
                        {
                            Console.Write("Введите размер двоичного числа: ");
                            n3 = Convert.ToInt32(Console.ReadLine());
                        } while (n3 <= 0);
                        Array bin = Array.CreateInstance(typeof(int), n3);
                        for (int i = 0; i < bin.GetLength(0); i++)
                        {
                            int chis;
                            do
                            {
                                Console.Write("Цифра: ");
                                chis = Convert.ToInt32(Console.ReadLine());
                            } while (chis < 0 || chis > 1);
                            bin.SetValue(chis, i);
                        }
                        int sum = 0;
                        for(int i = 0; i < bin.Length; i++)
                        {
                            sum += Convert.ToInt32(Convert.ToInt32(bin.GetValue(i)) * Math.Pow(2, i));
                        }
                        foreach (int x in bin) Console.Write(x);
                        Console.WriteLine($" - {sum}");
                        break;
                    case 0:
                        exit = 0;
                        break;
                    default:
                        Console.WriteLine("Такого задания нет.");
                        break;
                }
                break;
            case 2:
                Console.Write("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n0 - Выход\nПункт: ");
                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        int m1, n1;
                        do
                        {
                            Console.Write("Кол-во строк: ");
                            m1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Кол-во столбцов: ");
                            n1 = Convert.ToInt32(Console.ReadLine());
                        } while (m1 <= 0 || n1 <= 0);
                        Array mas = new int[m1, n1];
                        for (int i = 0; i < mas.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas.GetLength(1); j++)
                            {
                                mas.SetValue(rand.Next(1, 20), i, j);
                            }
                        }
                        Console.WriteLine("Matrix:");
                        for (int i = 0; i < m1; i++)
                        {
                            for (int j = 0; j < n1; j++)
                            {
                                Console.Write(mas.GetValue(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < mas.GetLength(1) - 1; i++)
                        {
                            for (int k = 0; k < mas.GetLength(1) - 1 - i; k++)
                            {
                                if (Convert.ToInt32(mas.GetValue(m1 - 1, k)) > Convert.ToInt32(mas.GetValue(m1 - 1, k + 1)))
                                {
                                    Array temp = Array.CreateInstance(typeof(int), m1);
                                    for (int t = 0; t < mas.GetLength(0); t++)
                                    {
                                        temp.SetValue(Convert.ToInt32(mas.GetValue(t, k)), t);
                                    }
                                    for (int t = 0; t < mas.GetLength(0); t++)
                                    {
                                        mas.SetValue(Convert.ToInt32(mas.GetValue(t, k + 1)), t, k);
                                    }
                                    for (int t = 0; t < mas.GetLength(0); t++)
                                    {
                                        mas.SetValue(Convert.ToInt32(temp.GetValue(t)), t, k + 1);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Sorted:");
                        for (int i = 0; i < mas.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas.GetLength(1); j++)
                            {
                                Console.Write(mas.GetValue(i, j) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        int m2, n2;
                        do
                        {
                            Console.Write("Кол-во строк: ");
                            m2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Кол-во столбцов: ");
                            n2 = Convert.ToInt32(Console.ReadLine());
                        } while (m2 <= 0 || n2 <= 0);
                        Array mas1 = new int[m2, n2];
                        int count = 0;
                        int size = 0;
                        int ii = 0, jj = 0;
                        for (int i = 0; i < mas1.GetLength(0); i++)
                        {
                            for (int j = 0; j < mas1.GetLength(1); j++)
                            {
                                mas1.SetValue(rand.Next(-10, 10), i, j);
                                if (Convert.ToInt32(mas1.GetValue(i, j)) < 0)
                                {
                                    count++;
                                }
                                if (count == 2)
                                {
                                    ii = i;
                                    jj = j;
                                    size+=1;
                                }
                                if (count > 2)
                                {
                                    size++;
                                }
                            }
                        }
                        if (count >= 2)
                        { 
                            int[] ar = new int[size];
                            int iter = 0;
                            int count1 = 0;
                            for (int i = 0; i < mas1.GetLength(0); i++)
                            {
                                for (int j = 0; j < mas1.GetLength(1); j++)
                                {
                                    if(Convert.ToInt32(mas1.GetValue(i, j)) < 0)
                                    {
                                        count1++;
                                    }
                                    if (count1 >= 2)
                                    {
                                        ar[iter++] = Convert.ToInt32(mas1.GetValue(i, j));
                                    }
                                }
                            }
                            Console.WriteLine("Matrix:");
                            for (int i = 0; i < mas1.GetLength(0); i++)
                            {
                                for (int j = 0; j < mas1.GetLength(1); j++)
                                {
                                    Console.Write(mas1.GetValue(i, j) + "\t");
                                }
                                Console.WriteLine();
                            }
                            for (int i = 0; i < ar.Length-1; i++)
                            {
                                ar[i] = ar[i+1];
                            }
                            foreach(int i in ar) Console.Write(i + " ");
                            Array.Resize(ref ar, --size);
                            Array.Sort(ar);
                            Array.Resize(ref ar, ++size);
                            ar[size - 1] = Convert.ToInt32(mas1.GetValue(ii,jj));
                            Console.WriteLine();
                            foreach (int i in ar) Console.Write(i + " ");
                            iter = size - 1;
                            count1 = 0;
                            for(int i = 0;i < mas1.GetLength(0);i++)
                            {
                                for(int j = 0;j < mas1.GetLength(1);j++)
                                {
                                    if (Convert.ToInt32(mas1.GetValue(i, j)) < 0)
                                    {
                                        count1++;
                                    }
                                    if (count1 >= 2)
                                    {
                                        mas1.SetValue(ar[iter--], i, j);
                                    }
                                }
                            }
                            Console.WriteLine("\nSorted:");
                            for(int i = 0;i < mas1.GetLength(0);i++)
                            {
                                for(int j = 0; j < mas1.GetLength(1);j++)
                                {

                                    Console.Write(mas1.GetValue(i, j) + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Массив задан неверно");
                        }
                        break;
                    case 3:
                        Console.Write($"Количество строк: ");
                        int str = Convert.ToInt32(Console.ReadLine());
                        Array matrix = Array.CreateInstance(typeof(int), str, 2);
                        for(int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for(int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"matrix[{i}][{j}] = ");
                                int c1 = Convert.ToInt32(Console.ReadLine());
                                matrix.SetValue(c1, i, j);
                            }
                        }
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix.GetValue(i,j) + " ");
                            }
                            Console.WriteLine();
                        }
                        int it = 0;
                        Array okr = Array.CreateInstance(typeof(double), str);
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            okr.SetValue(Math.Sqrt(Math.Pow(Convert.ToInt32(matrix.GetValue(i, 0)),2) + Math.Pow(Convert.ToInt32(matrix.GetValue(i, 1)), 2)), it++);
                        }
                        Array.Sort(okr);
                        Console.WriteLine($"Радиус окружности: {Math.Round(Convert.ToDouble(okr.GetValue(okr.Length-1)),2)}");
                        break;
                    case 0:
                        exit = 0;
                        break;
                    default:
                        Console.WriteLine("Такого задания нет.");
                        break;
                }
                break;
            default:
                Console.WriteLine("Такого пункта нет.");
                break;

        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Введите число...");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Вы вышли за размерность.");
    }
    catch (Exception)
    {
        Console.WriteLine("Error");
    }
}