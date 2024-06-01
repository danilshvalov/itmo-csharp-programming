using System;

namespace MyClass
{
    public class Book : Item
    {
        private String author;
        private String title;
        private String publisher;
        private int pages;
        private int year;
        private static double price = 9;
        private bool returnSrok = false;

        public Book() { }

        static Book()
        {
            price = 10;
        }

        public Book(
            String author,
            String title,
            String publisher,
            int pages,
            int year,
            long invNumber,
            bool taken
        )
            : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

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

        public override void Show()
        {
            Console.WriteLine("Книга:");
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("Год издания: {0}", year);
            Console.WriteLine("Страницы: {0}", pages);
            Console.WriteLine("Стоимость аренды: {0}", Book.price);
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public bool ReturnSrok
        {
            get { return returnSrok; }
            set
            {
                returnSrok = value;
                if (ReturnSrok)
                {
                    RetSrok(this);
                }
            }
        }

        public override void Return()
        {
            taken = ReturnSrok;
        }

        public delegate void ProcessBookDelegate(Book book);

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (ReturnSrok)
            {
                processBook(this);
            }
        }

        public static event ProcessBookDelegate RetSrok;

        public override string ToString()
        {
            return title + ", " + author + " Инв. номер " + invNumber;
        }
    }
}
