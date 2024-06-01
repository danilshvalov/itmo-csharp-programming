namespace Triangle;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Triangle t1 = new Triangle(3, 4, 5);
            t1.Show();
            Console.WriteLine("Perimeter: {0}", t1.Perimeter());
            Console.WriteLine("Square: {0}", t1.Square());

            Triangle t2 = new Triangle(5);
            t2.Show();
            Console.WriteLine("Perimeter: {0}", t2.Perimeter());
            Console.WriteLine("Square: {0}", t2.Square());

            Triangle t3 = new Triangle(3, 4, 10);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

