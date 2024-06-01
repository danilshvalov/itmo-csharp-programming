namespace Square;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Is it an equilateral triangle? (y/N)");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                Console.WriteLine("Enter the side of the triangle:");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Square: {0}", Operation.Square(side));
            }
            else
            {
                Console.WriteLine("Enter the first side of the triangle:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second side of the triangle:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third side of the triangle:");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("Square: {0}", Operation.Square(a, b, c));
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

