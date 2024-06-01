using System;
namespace Triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new ArgumentException(
                    "The sides must satisfy the condition of the existence of a triangle"
                );
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle(double side) : this(side, side, side) { }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Show()
        {
            Console.WriteLine("Triangle: ({0}, {1}, {2})", a, b, c);
        }

        public bool IsEquilateral()
        {
            return a == b && b == c;
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }
    }
}

