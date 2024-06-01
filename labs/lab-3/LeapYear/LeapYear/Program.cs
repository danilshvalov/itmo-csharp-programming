namespace LeapYear;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

