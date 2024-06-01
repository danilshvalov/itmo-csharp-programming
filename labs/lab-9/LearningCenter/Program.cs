using System;
using System.Globalization;

namespace LearningCenter;

class Program
{
    static void Main(string[] args)
    {
        Administrator admin = new Administrator(
            "Петров",
            DateTime.ParseExact(
                "15.04.1985",
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture
            ),
            "Лаборатория физики"
        );

        Student student = new Student(
            "Сидоров",
            DateTime.ParseExact(
                "21.06.2003",
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture
            ),
            "ИКТ",
            2
        );

        Teacher teacher = new Teacher(
            "Попов",
            DateTime.ParseExact(
                "05.02.1975",
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture
            ),
            "ИКТ",
            "Старший преподаватель",
            15
        );

        Manager manager = new Manager(
            "Коновалов",
            DateTime.ParseExact(
                "17.09.1983",
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture
            ),
            "ИКТ",
            "Менеджер по закупкам"
        );

        Person[] persons = new Person[4];
        persons[0] = admin;
        persons[1] = student;
        persons[2] = teacher;
        persons[3] = manager;

        foreach (Person p in persons)
        {
            p.Show();
            Console.WriteLine("Возраст: {0}", p.GetAge());
        }

        Console.Write("Введите минимальный возраст: ");
        int minAge = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальный возраст: ");
        int maxAge = int.Parse(Console.ReadLine());

        foreach (Person p in persons)
        {
            if (minAge <= p.GetAge() && p.GetAge() <= maxAge)
            {
                Console.WriteLine("{0}: {1}", p.Surname, p.GetAge());
            }
        }
    }
}
