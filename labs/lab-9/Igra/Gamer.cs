using System;

namespace Igra
{
    public class Gamer
    {
        private string name;
        private IgralnayaKost seans;

        public Gamer(string name)
        {
            this.name = name;
            seans = new IgralnayaKost();
            IgralnayaKost.MaxPoints +=
                new IgralnayaKost.ProcessIgralnayaKostDelegate(
                    MaxPointsHandler
                );
        }

        public int SeansGame()
        {
            return seans.Random();
        }

        public override string ToString()
        {
            return name;
        }

        private static void MaxPointsHandler(IgralnayaKost igralnayaKost)
        {
            Console.WriteLine("Выпало максимальное количество очков");
        }
    }
}
