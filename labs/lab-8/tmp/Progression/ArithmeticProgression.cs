using System;

namespace Progression
{
    public class ArithmeticProgression : IProgression
    {
        private double firstMember;
        private double difference;

        public ArithmeticProgression(double firstMember, double difference)
        {
            this.firstMember = firstMember;
            this.difference = difference;
        }

        double IProgression.GetElement(int k)
        {
            return firstMember + (k - 1) * difference;
        }
    }
}
