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

        Console.WriteLine("До swap: \t" + x + " " + y);
        Utils.Swap(ref x, ref y);
        Console.WriteLine("После swap: \t" + x + " " + y);
    }
}

