namespace Loop;
class Program
{
    static void Main(string[] args)
    {
        double x, x1, x2, y;

        Console.WriteLine("Enter x1:");
        x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter x2:");
        x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("x\tsin(x)");
        x = x1;

        while (x <= x2 || x == x1)
        {
            y = Math.Sin(x);
            Console.WriteLine("{0:f3}\t{1:f3}", x, y);
            x = x + 0.01;
        }
    }
}

