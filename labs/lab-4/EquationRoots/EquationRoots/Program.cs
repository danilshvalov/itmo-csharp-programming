namespace EquationRoots;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c:");
        double c = double.Parse(Console.ReadLine());

        double x1 = 0;
        double x2 = 0;

        int result = Equation.FindRoots(a, b, c, ref x1, ref x2);
        if (result == 1)
        {
            Console.WriteLine(
                "a = {0}, b = {1}, c = {2}, x1 = {3}, x2 = {4}",
                a, b, c, x1, x2
            );
        }
        else if (result == 0)
        {
            Console.WriteLine(
                "a = {0}, b = {1}, c = {2}, x1 = x2 = {3}",
                a, b, c, x1
            );
        }
        else
        {
            Console.WriteLine(
                "a = {0}, b = {1}, c = {2}, no roots",
                a, b, c
            );
        }
    }
}

