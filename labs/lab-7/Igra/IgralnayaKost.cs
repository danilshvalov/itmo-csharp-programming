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
            return r.Next(6) + 1;
        }
    }
}
