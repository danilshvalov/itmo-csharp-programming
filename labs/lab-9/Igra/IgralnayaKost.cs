using System;

namespace Igra
{
    public class IgralnayaKost
    {
        Random r;

        public IgralnayaKost()
        {
            r = new Random();
        }

        public int Random()
        {
            const int maxPoint = 6;
            int points = r.Next(maxPoint) + 1;

            if (points == maxPoint)
            {
                MaxPoints(this);
            }

            return points;
        }

        public delegate void ProcessIgralnayaKostDelegate(IgralnayaKost book);

        public static event ProcessIgralnayaKostDelegate MaxPoints;
    }
}
