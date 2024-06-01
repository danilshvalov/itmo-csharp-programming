namespace Utils;
class Program
{
    static void Main(string[] args)
    {
        int x;
        int y;

        Console.WriteLine("Введите первое число:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        y = int.Parse(Console.ReadLine());

        int greater = Utils.Greater(x, y);
        Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
    }
}

