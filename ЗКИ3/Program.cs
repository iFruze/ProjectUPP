using System.Linq.Expressions;

Console.Write("Текст, который хотите зашифровать: ");
string str = Console.ReadLine();
Console.Write("Ключ, по которому должен шифроваться текст: ");
string key = Console.ReadLine();
bool f334 = false;
for(int i = 0; i < key.Length; i++)
{
    if((int)key[i] >= 0 && (int)key[i] <= 128)
    {
        f334 = true;
        break;
    }
}
if (f334 == true)
{
    Console.WriteLine("Только одно слово на русском!!!!!!!!!");
}
else
{
    str = str.ToLower();
    key = key.ToLower();
    int iter = 0;
    char word = 'а';
    Array res = Array.CreateInstance(typeof(char), 40);
    for (int i = 0; i < key.Length; i++)
    {
        bool f = true;
        for (int j = 0; j < res.Length; j++)
        {
            if (key[i] == Convert.ToChar(res.GetValue(j)))
            {
                f = false;
            }
        }
        if (f == false)
        {
            continue;
        }
        res.SetValue(key[i], iter++);
    }
    word = 'а';
    for (int i = iter; i < res.Length; i++)
    {
        bool f = true;
        for (int j = 0; j < res.Length; j++)
        {
            if (word == Convert.ToChar(res.GetValue(j)))
            {
                f = false;
            }
        }
        if (f == false)
        {
            word++;
        }
        else
        {
            res.SetValue(word++, iter++);
        }
    }
    Array arr = Array.CreateInstance(typeof(char), 4, 8);
    iter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr.SetValue(Convert.ToChar(res.GetValue(iter++)), i, j);
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr.GetValue(i, j) + " ");
        }
        Console.WriteLine();
    }
    char[] s = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        s[i] = str[i];
    }
    for (int i = 0; i < str.Length; i++)
    {
        if (s[i] == ' ')
        {
            for (int j = i; j < s.Length - 1; j++)
            {
                s[j] = s[j + 1];
            }
        }
    }
    for (int i = 0; i < str.Length; i++)
    {
        if ((int)s[i] >= 0 && (int)s[i] <= 128)
        {
            for (int j = i; j < s.Length - 1; j++)
            {
                s[j] = s[j + 1];
            }
        }
    }
    Console.WriteLine("\nТрисемус");
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ' || ((int)str[i] >= 0 && (int)str[i] <= 128))
        {
            Console.Write(str[i]);
        }
        else
        {
            int i1 = 0, j1 = 0;
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (str[i] == Convert.ToChar(arr.GetValue(k, j)))
                    {
                        i1 = k;
                        j1 = j;
                    }
                }
            }
            if (i1 == 3)
            {
                Console.Write(arr.GetValue(0, j1));
            }
            else
            {
                Console.Write(arr.GetValue(i1 + 1, j1));
            }
        }
    }
    Console.WriteLine("\nПлейфер");
    char[] mas = new char[str.Length];
    int iterator = 0;
    for (int h = 0; h < s.Length - 1; h += 2)
    {
        int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
        for (int k = 0; k < arr.GetLength(0); k++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (s[h] == Convert.ToChar(arr.GetValue(k, j)))
                {
                    i1 = k;
                    j1 = j;
                }
                if (s[h + 1] == Convert.ToChar(arr.GetValue(k, j)))
                {
                    i2 = k;
                    j2 = j;
                }
            }

        }
        if (i1 == i2 && j1 == j2)
        {
            if (i1 == 3)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(0, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2 + 1, j2));
            }
            else if (i2 == 3)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1 + 1, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(0, j2));
            }
            else
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1 + 1, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2 + 1, j2));
            }
        }
        else if (i1 == i2)
        {
            if (j1 == 7)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1, 0));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2, j2 + 1));
            }
            else if (j2 == 7)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1, j1 + 1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2, 0));
            }
            else
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1, j1 + 1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2, j2 + 1));
            }
        }
        else if (j1 == j2)
        {
            if (i1 == 3)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(0, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2 + 1, j2));
            }
            else if (i2 == 3)
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1 + 1, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(0, j2));
            }
            else
            {
                mas[iterator++] = Convert.ToChar(arr.GetValue(i1 + 1, j1));
                mas[iterator++] = Convert.ToChar(arr.GetValue(i2 + 1, j2));
            }
        }
        else
        {

            mas[iterator++] = Convert.ToChar(arr.GetValue(i1, j2));
            mas[iterator++] = Convert.ToChar(arr.GetValue(i2, j1));

        }
    }
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == ' ' || ((int)str[i] >= 0 && (int)str[i] <= 128))
        {
            for (int j = str.Length - 1; j > i; j--)
            {
                mas[j] = mas[j - 1];
            }
            mas[i] = str[i];
        }
    }
    foreach (char t in mas) Console.Write(t);
}
