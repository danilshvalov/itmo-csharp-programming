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
    }
}
