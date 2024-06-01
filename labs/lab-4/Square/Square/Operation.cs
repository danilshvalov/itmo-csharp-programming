using System;
namespace Square
{
    public class Operation
    {
        public static double Square(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new ArgumentException(
                    "The sides must satisfy the condition of the existence of a triangle"
                );
            }

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double Square(double side)
        {
            return Square(side, side, side);
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }
    }
}

