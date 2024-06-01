using System;

namespace Progression
{
    public class GeometricProgression : Progression
    {
        private double firstMember;
        private double denominator;

        public GeometricProgression(double firstMember, double denominator)
        {
            this.firstMember = firstMember;
            this.denominator = denominator;
        }

        public override double GetElement(int k)
        {
            return firstMember * Math.Pow(denominator, k - 1);
        }
    }
}
