using System;

namespace Progression
{
    public class GeometricProgression : IProgression
    {
        private double firstMember;
        private double denominator;

        public GeometricProgression(double firstMember, double difference)
        {
            this.firstMember = firstMember;
            this.denominator = difference;
        }

        double IProgression.GetElement(int k)
        {
            return firstMember * Math.Pow(denominator, k - 1);
        }
    }
}
