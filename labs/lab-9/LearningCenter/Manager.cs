namespace LearningCenter
{
    public class Manager : Person, IEmployee
    {
        public Manager(
            string surname,
            DateTime birthDate,
            string faculty,
            string position
        )
            : base(surname, birthDate)
        {
            Faculty = faculty;
            Position = position;
        }

        public string Faculty { get; set; }
        public string Position { get; set; }

        public override void Show()
        {
            Console.WriteLine("Менеджер");
            base.Show();
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine("Должность: {0}", Position);
            Console.WriteLine("Заработная плата: {0}", GetSalary());
        }

        public decimal GetSalary()
        {
            return 65000;
        }
    }
}
