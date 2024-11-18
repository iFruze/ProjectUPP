using Lab9;
while (true)
{
    try
    {
        double x, y, r;
        Console.Write("0 - Выход\n1 - Обычное задание\n2 - Задание с первичным конструктором\nПукт: ");
        int punct = Convert.ToInt32(Console.ReadLine());
        switch (punct)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                try
                {
                    Console.Write("x: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y: ");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(x, y, r);
                    Console.WriteLine(circle);
                    (double x1, double y1, double r1) = circle;
                    Console.WriteLine($"Данные, полученные из деконструктора:\nx = {x1}\ny = {y1}\nr = {r1}");
                    Console.WriteLine($"Перегруженный метод length:\nДлина окружности равна {circle.length(Math.PI):f2} см.");
                    Console.WriteLine("Изменённый объект circle:\n" + ++circle);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Радиус должен быть меньше 10");
                }
                break;
            case 2:
                //Circle1 circle1 = new Circle1();
                //Console.WriteLine(circle1);
                //(double x11, double y11, double r11) = circle1;
                //Console.WriteLine($"Данные, полученные из деконструктора:\nx = {x11}\ny = {y11}\nr = {r11}");
                Shar1 shar1 = new Shar1();
                Console.WriteLine(shar1);
                (_, double rad) = shar1;
                Console.WriteLine($"Данные, полученные из деконструктора:r = {rad}");

                break;
            default:
                Console.WriteLine("Такого пункта нет.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error");
    }
}