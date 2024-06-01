namespace MyClass;

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book();
        b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
        Book.SetPrice(12);
        b1.Show();
        Console.WriteLine("Итоговая стоимость аренды: {0} p.", b1.PriceBook(3));

        Book b2 = new Book(
            "Толстой Л.Н.",
            "Война и мир",
            "Наука и жизнь",
            1234,
            2013
        );
        b2.Show();

        Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
        b3.Show();
    }
}
