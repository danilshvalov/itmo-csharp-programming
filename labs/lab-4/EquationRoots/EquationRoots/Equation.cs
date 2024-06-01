using System;
namespace EquationRoots
{
    public class Equation
    {
        public static int FindRoots(double a, double b, double c,
                                    ref double x1, ref double x2)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return 1;
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}

