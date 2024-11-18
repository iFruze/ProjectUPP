using System.Text;
static void PrintArray(string message, char[] array)
{
    Console.WriteLine(message + new string(array));
}
int exit = -1;
while (exit != 0)
{
    try
    {
        Console.Write("\n0 - Выход\n1 - Задание 1\n2 - Задание 2\nПункт: ");
        exit = Convert.ToInt32(Console.ReadLine());
        switch (exit)
        {
            case 0:
                break;
            case 1:
                char[] a1 = { 'm', 'a', 'Х', 'i', 'M', 'u', 'S', '!', '!', '!' };
                char[] b1 = " кол около колокола ".ToCharArray();
                PrintArray("Исходный массив а: ", a1);
                int punctuationCount = 0;
                for (int x = 0; x < a1.Length; x++)
                {
                    if (char.IsLower(a1[x]))
                        a1[x] = char.ToUpper(a1[x]);
                    if (char.IsPunctuation(a1[x]))
                        punctuationCount++;
                }
                PrintArray("Измененный массив а: ", a1);
                Console.WriteLine("Количество знаков пунктуации в массиве а: " + punctuationCount);
                PrintArray("Исходный массив b: ", b1);
                Array.Reverse(b1);
                PrintArray("Измененный массив b: ", b1); 
                Console.WriteLine();
                string str45 = "тучки небесные, вечные странники...";
                string[] split1 = str45.Split(' ');
                Array.Reverse(split1);
                foreach (string str2 in split1) Console.Write(str2 + " ");
                Console.WriteLine();
                Console.WriteLine("С помощью метода Replace() можно заменить два пробела на один.");
                Console.WriteLine("В массиве parts появились пустые строки из-за того, что при разбиении по знакам припенания в строке остаются либо пробел либо ничего.");
                string poems = "Тучки небесные, вечные странники...";
                char[] div = { ' ', ',', '.' }; 
                string[] parts = poems.Split(div);
                Console.WriteLine("Результат разбиения строки на части: ");
                for (int i = 0; i < parts.Length; i++)
                {
                    if (parts[i] == "")
                    {
                        continue;
                    }
                    Console.WriteLine(parts[i]);
                }
                Console.Write("Введите строку: ");
                StringBuilder a = new StringBuilder(Console.ReadLine());
                Console.WriteLine("Исходная строка: " + a);
                string[] sp = a.ToString().Split(' ');
                StringBuilder b = new StringBuilder();
                for(int i = 0; i< sp.Length; i++)
                {
                    if (sp[i].Trim()=="")
                    {
                        continue;
                    }
                    b.Append(sp[i].Trim());
                    b.Append(' ');
                }
                string t = b.ToString().TrimEnd();
                b = new StringBuilder(t);
                for (int i = 0; i < b.Length;)
                {
                    if (char.IsPunctuation(b[i])) b.Remove(i, 1);
                    else ++i;
                }
                string str = b.ToString();
                string[] s = str.Split(' ');
                Console.WriteLine("Искомые слова: ");
                for (int i = 0; i < s.Length; i++) 
                {
                    string temp = s[i];
                    if (temp[0] == temp[temp.Length - 1]) Console.WriteLine(temp);
                }
                break;
            case 2:
                string st = Console.ReadLine();
                char[] c = st.ToCharArray();
                for(int i = 0; i < c.Length; i++)
                {
                    if (char.IsUpper(c[i]))
                    {
                        c[i] = char.ToLower(c[i]);
                    }
                    else if (char.IsLower(c[i]))
                    {
                        c[i] = char.ToUpper(c[i]);
                    }
                    Console.Write(c[i]);
                }
                Console.WriteLine();
                StringBuilder stt = new StringBuilder(Console.ReadLine());
                string[] spl = stt.ToString().Split(' ');
                for(int i = 0; i < spl.Length; i++)
                {
                    bool f = false;
                    string temp = spl[i];
                    for(int j = 0; j < spl[i].Length; j++)
                    {
                        if (temp[j] == 'к')
                        {
                            f = true;
                        }
                    }
                    if(f == true)
                    {
                        Console.WriteLine(temp);
                    }
                }
                st = Console.ReadLine();
                int max = int.MinValue;
                for(int i = 0; i < st.Length; i++)
                {
                    if (char.IsNumber(st[i]))
                    {
                        int g = Convert.ToInt32(st[i]);
                        if (g > max) max = g;
                    }
                }
                Console.WriteLine(Convert.ToChar(max));
                stt = new StringBuilder(Console.ReadLine());
                stt.Append('~');
                Console.WriteLine(stt);
                stt = new StringBuilder(Console.ReadLine());
                stt.Append(stt.Length.ToString());
                Console.WriteLine(stt);
                //string input = "Hello! World! This is a test!";
                //char[] chars = input.ToCharArray();

                //for (int i = 0; i < chars.Length; i++)
                //{
                //    if (chars[i] == '!')
                //    {
                //        chars[i] = i.ToString()[0];
                //    }
                //}

                //string result = new string(chars);
                //Console.WriteLine(result);
                stt = new StringBuilder(Console.ReadLine());
                int count = 0;
                for(int i = 0; i  <stt.Length; i++)
                {
                    if (stt[i]=='!')
                    {
                        count++;
                    }
                }
                int it = 0;
                int[] ind = new int[count];
                for (int i = 0; i < stt.Length; i++)
                {
                    if (stt[i] == '!')
                    {
                        ind[it++] = i;
                    }
                }
                string[] res= stt.ToString().Split('!');
                it = 0;
                for(int i = 0; i < res.Length; i++)
                {
                    if (it >= ind.Length)
                    {
                        Console.Write(res[i]);
                    }
                    else
                    {
                        Console.Write(res[i]);
                        Console.Write(ind[it++]);
                    }
                }
                break;
            default:
                Console.WriteLine("Такого задания нет.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Некорректные данные.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Вы вышли за размерность.");
    }
    catch (Exception e) 
    {
        Console.WriteLine("Error.");
        Console.WriteLine(e.ToString()); 
    }
} 
