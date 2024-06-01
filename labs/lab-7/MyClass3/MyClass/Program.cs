﻿namespace MyClass;

class Program
{
    static void Main(string[] args)
    {
        Book b = new Book(
            "Толстой Л.Н.",
            "Война и мир",
            "Наука и жизнь",
            1234,
            2013,
            101,
            true
        );

        Magazine m = new Magazine(
            "О природе",
            5,
            "Земля и  мы",
            2014,
            1235,
            true
        );

        Console.WriteLine("Тестирование полиморфизма");

        Item it = b;
        it.TakeItem();
        it.Return();
        it.Show();

        it = m;
        it.TakeItem();
        it.Return();
        it.Show();
    }
}
