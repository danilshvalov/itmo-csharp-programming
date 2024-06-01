namespace MyClass;

class Program
{
    static void Main(string[] args)
    {
        Item[] items = new Item[4];

        Book b = new Book();
        b.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
        items[0] = b;
        items[1] = new Book(
            "Толстой Л.Н.",
            "Война и мир",
            "Наука и жизнь",
            1234,
            2013,
            101,
            true
        );
        items[2] = new Book("Лермонтов М.Ю.", "Мцыри");
        items[3] = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);

        Array.Sort(items);

        Console.WriteLine("Сортировка по инвентарному номеру:");
        foreach (Item item in items)
        {
            item.Show();
        }
    }
}
