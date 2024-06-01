namespace Utils;
class Program
{
    static void Main(string[] args)
    {
        int f, x;
        bool ok;

        Console.WriteLine("Number for factorial:");
        x = int.Parse(Console.ReadLine());
        ok = Utils.Factorial(x, out f);

        if (ok)
        {
            Console.WriteLine("Factorial(" + x + ") = " + f);
        }
        else
        {
            Console.WriteLine("Cannot compute this factorial");
        }
    }
}

