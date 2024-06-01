namespace Igra;

class Program
{
    static void Main(string[] args)
    {
        Gamer g = new Gamer("Niko");

        while (true)
        {
            int points = g.SeansGame();
            if (points == 6)
            {
                break;
            }
            Console.WriteLine("Выпало {0} очков", points);
        }
    }
}
