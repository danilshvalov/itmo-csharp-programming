namespace Progression;

class Program
{
    static void Main(string[] args)
    {
        ArithmeticProgression a = new ArithmeticProgression(1, 5);
        Console.WriteLine("Arithmetic progression: {0}", a.GetElement(5));

        GeometricProgression g = new GeometricProgression(1, 5);
        Console.WriteLine("Geometric progression: {0}", g.GetElement(5));
    }
}
