namespace LearningCenter
{
    public class Student : Person
    {
        public Student(
            string surname,
            DateTime birthDate,
            string faculty,
            int course
        )
            : base(surname, birthDate)
        {
            Faculty = faculty;
            Course = course;
        }

        public string Faculty { get; set; }
        public int Course { get; set; }

        public override void Show()
        {
            Console.WriteLine("Студент");
            base.Show();
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine("Курс: {0}", Course);
        }
    }
}
