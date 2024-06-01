namespace MyClass;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book(
            "Толстой Л.Н.",
            "Анна Каренина",
            "Знание",
            1204,
            2014,
            103,
            true
        );
        Book b2 = new Book(
            "Неш Т",
            "Программирование для  профессионалов",
            "Вильямс",
            1200,
            2014,
            108,
            true
        );

        b1.ReturnSrok = true;
        b2.ReturnSrok = false;

        Console.WriteLine("Книги возвращены в срок:");
        b1.ProcessPaperbackBooks(Operation.PrintTitle);
        b2.ProcessPaperbackBooks(Operation.PrintTitle);
    }
}
