using Lab9._2;
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Library lib = new Library(n);
    for (int i = 0; i < n; i++)
    {
        string name, author, cat;
        int year;
        Console.Write("Название книги: ");
        name = Console.ReadLine();
        Console.Write("Автор книги: ");
        author = Console.ReadLine();
        Console.Write("Категория книги: ");
        cat = Console.ReadLine();
        Console.Write("Год выпуска книги: ");
        year = Convert.ToInt32(Console.ReadLine());
        lib[i] = new Book(name, author, year, cat);
    }
    Console.WriteLine(lib);
    Console.Write("Автор искомой вами книги: ");
    string srch = Console.ReadLine();
    string res = lib.Search(srch);
    Console.WriteLine(res);
    Console.Write("Индекс книги, которую вы хотите удалить: ");
    int del = Convert.ToInt32(Console.ReadLine());
    lib.Delete(del);
    Console.WriteLine(lib);
}
catch(FormatException)
{
    Console.WriteLine("Введите корректные данные.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}