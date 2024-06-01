using System;

namespace Progression
{
    public class ArithmeticProgression : Progression
    {
        private double firstMember;
        private double difference;

        public ArithmeticProgression(double firstMember, double difference)
        {
            this.firstMember = firstMember;
            this.difference = difference;
        }

        public override double GetElement(int k)
        {
            return firstMember + (k - 1) * difference;
        }
    }
}
