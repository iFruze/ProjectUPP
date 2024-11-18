Console.Write("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\nПункт: ");
int punct = Convert.ToInt32(Console.ReadLine());
switch(punct)
{
    case 1:
        double x, y;
        int num = -1;
        Console.Write("Введите вариант: ");
        try
        {
            num = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Error");
        }
        catch (OverflowException) 
        {
            Console.WriteLine("Error");
        }
        switch (num)
        {
            case 1:
                x = 3.5;
                y = 7.2;
                if(y >= 0 && y <= 2 - Math.Pow(x, 2))
                {
                    Console.WriteLine("Точка входит в область.");
                }
                else
                {
                    Console.WriteLine("Точка не входит в область.");
                }
                break;
            case 2:
                x = -0.5;
                y = 1.2;
                if(y >= 0 && y <= 2 - Math.Pow(x, 2))
                {
                    Console.WriteLine("Точка входит в область.");
                }
                else
                {
                    Console.WriteLine("Точка не входит в область.");
                }
                break;
            case 3:
                x = 1.2;
                y = -3.12;
                if(y >= 0 && y <= 2 - Math.Pow(x, 2))
                {
                    Console.WriteLine("Точка входит в область.");
                }
                else
                {
                    Console.WriteLine("Точка не входит в область.");
                }
                break;
            default:
                Console.WriteLine("Вы ввели неверный вариант.");
                break;
        }
        break;
    case 2:
        double u, x1;
        Console.Write("Введите x: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        int p;
        Console.Write("Введите цифру от 1 до 3: ");
        p = Convert.ToInt32(Console.ReadLine());  
        switch(p)
        {
            case 1:
                u = Math.Sin(x1);
                switch(u+x1>-0.5)
                {
                    case true:
                        Console.Write($"Ответ: {Math.Pow(2*u+1, 2)/(7*Math.PI + x1)}");
                        break;
                    case false:
                        switch(u+x1<=10e-3 && u+x1 >= -0.5)
                        {
                            case true:
                                Console.Write($"Ответ: {Math.Pow(Math.Cos(u), 2)-Math.Sin(u/3)}");
                                break;
                            case false:
                                switch(u+x1>10e-3)
                                {
                                    case true:
                                        Console.Write($"Ответ: {(Math.Log10(u+x1)*Math.Exp(x1))/(3.5*x1)}");
                                        break;
                                    case false:
                                        Console.WriteLine("Неверные данные.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
            case 2:
                u = Math.Cos(x1);
                switch (u + x1 > -0.5)
                {
                    case true:
                        Console.Write($"Ответ: {Math.Pow(2 * u + 1, 2) / (7 * Math.PI + x1)}");
                        break;
                    case false:
                        switch (u + x1 <= 10e-3 && u + x1 >= -0.5)
                        {
                            case true:
                                Console.Write($"Ответ: {Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3)}");
                                break;
                            case false:
                                switch (u + x1 > 10e-3)
                                {
                                    case true:
                                        Console.Write($"Ответ: {(Math.Log10(u + x1) * Math.Exp(x1)) / (3.5 * x1)}");
                                        break;
                                    case false:
                                        Console.WriteLine("Неверные данные.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
            case 3:
                u = Math.Tan(x1);
                switch (u + x1 > -0.5)
                {
                    case true:
                        Console.Write($"Ответ: {Math.Pow(2 * u + 1, 2) / (7 * Math.PI + x1)}");
                        break;
                    case false:
                        switch (u + x1 <= 10e-3 && u + x1 >= -0.5)
                        {
                            case true:
                                Console.Write($"Ответ: {Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3)}");
                                break;
                            case false:
                                switch (u + x1 > 10e-3)
                                {
                                    case true:
                                        Console.Write($"Ответ: {(Math.Log10(u + x1) * Math.Exp(x1)) / (3.5 * x1)}");
                                        break;
                                    case false:
                                        Console.WriteLine("Неверные данные.");
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
            default:
                Console.WriteLine("Такого варианта нет.");
                break;
        }
        
        break;
    case 3:
        Console.Write("Введите код города: ");
        string str = Convert.ToString(Console.ReadLine());
        double time;
        Console.Write("Введите время разговора: ");
        time = Convert.ToDouble(Console.ReadLine());
        string res = str switch
        {
            "048" => "Стоимость будет составлять " + Convert.ToString(15 * time) + " грн.",
            "044" => "Стоимость будет составлять " + Convert.ToString(18 * time) + " грн.",
            "046" => "Стоимость будет составлять " + Convert.ToString(13 * time) + " грн.",
            "045" => "Стоимость будет составлять " + Convert.ToString(11 * time) + " грн.",
            _ => "Такого города нет."
        };
        Console.WriteLine(res);
        break;
    default:
        Console.WriteLine("Такого пункта нет.");
        break;
}
