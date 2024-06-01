using System;

namespace MyClass
{
    public class Magazine : Item, IPubs
    {
        private String volume;
        private int number;
        private String title;
        private int year;

        public Magazine(
            String volume,
            int number,
            String title,
            int year,
            long invNumber,
            bool taken
        )
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public Magazine() { }

        public override void Show()
        {
            Console.WriteLine("Журнал:");
            Console.WriteLine("Том: {0}", volume);
            Console.WriteLine("Номер: {0}", number);
            Console.WriteLine("Название: {0}", title);
            Console.WriteLine("Год выпуска: {0}", year);
            base.Show();
        }

        public override void Return()
        {
            taken = true;
        }

        public bool IfSubs { get; set; }

        public void Subs()
        {
            Console.WriteLine(
                "Подписка на журнал \"{0}\": {1}.",
                title,
                IfSubs
            );
        }
    }
}
