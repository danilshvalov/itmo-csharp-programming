namespace LearningCenter
{
    public class Administrator : Person, IEmployee
    {
        public Administrator(
            string surname,
            DateTime birthDate,
            string laboratory
        )
            : base(surname, birthDate)
        {
            Laboratory = laboratory;
        }

        public string Laboratory { get; set; }

        public override void Show()
        {
            Console.WriteLine("Администратор");
            base.Show();
            Console.WriteLine("Лаборатория: {0}", Laboratory);
            Console.WriteLine("Заработная плата: {0}", GetSalary());
        }

        public decimal GetSalary()
        {
            return 60000;
        }
    }
}
