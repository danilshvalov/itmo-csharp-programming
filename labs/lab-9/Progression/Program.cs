namespace Progression;

class Program
{
    static void Main(string[] args)
    {
        IProgression a = new ArithmeticProgression(1, 5);
        Console.WriteLine("Arithmetic progression: {0}", a.GetElement(5));

        IProgression g = new GeometricProgression(1, 5);
        Console.WriteLine("Geometric progression: {0}", g.GetElement(5));
    }
}
