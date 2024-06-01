namespace Square;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the side of the triangle");
            string temp = Console.ReadLine();
            double side = Double.Parse(temp);

            double p = side * 3 / 2;
            double square = Math.Sqrt(p * Math.Pow(p - side, 3));

            Console.WriteLine("Side\tSquare");
            Console.WriteLine("{0:f2}\t{1:f2}", side, square);
        }
        catch (FormatException)
        {
            Console.WriteLine(
                "The side of the triangle must be a floating point number"
            );
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception was thrown: {0}", e.Message);
        }
    }
}
