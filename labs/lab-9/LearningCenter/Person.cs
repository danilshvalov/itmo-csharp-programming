namespace LearningCenter
{
    public abstract class Person
    {
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string surname, DateTime birthDate)
        {
            Surname = surname;
            BirthDate = birthDate;
        }

        public virtual void Show()
        {
            Console.WriteLine("Фамилия: {0}", Surname);
            Console.WriteLine("Дата рождения: {0:dd.MM.yyyy}", BirthDate);
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
