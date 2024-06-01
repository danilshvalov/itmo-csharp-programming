namespace Sum;
class Program
{
    static void Main(string[] args)
    {
        int k, m;

        Console.WriteLine("Enter k:");
        k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m:");
        m = int.Parse(Console.ReadLine());

        int s = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i > k && i < m) continue;
            s += i;
        }
        Console.WriteLine("Sum: {0}", s);
    }
}

