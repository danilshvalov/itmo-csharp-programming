﻿using System;

namespace MyClass
{
    public class Book
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;
        private static double price = 9;

        public void SetBook(
            String author,
            String title,
            String publisher,
            int pages,
            int year
        )
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine("Книга:");
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("Год издания: {0}", year);
            Console.WriteLine("Страницы: {0}", pages);
            Console.WriteLine("Стоимость аренды: {0}", Book.price);
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}
