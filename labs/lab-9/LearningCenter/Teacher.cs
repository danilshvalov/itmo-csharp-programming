namespace LearningCenter
{
    public class Teacher : Person
    {
        public Teacher(
            string surname,
            DateTime birthDate,
            string faculty,
            string position,
            int workExperience
        )
            : base(surname, birthDate)
        {
            Faculty = faculty;
            Position = position;
            WorkExperience = workExperience;
        }

        public string Faculty { get; set; }
        public string Position { get; set; }
        public int WorkExperience { get; set; }

        public override void Show()
        {
            Console.WriteLine("Преподаватель");
            base.Show();
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine("Должность: {0}", Position);
            Console.WriteLine("Стаж: {0}", WorkExperience);
            Console.WriteLine("Заработная плата: {0}", GetSalary());
        }

        public decimal GetSalary()
        {
            return 80000;
        }
    }
}
