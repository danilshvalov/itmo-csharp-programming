namespace TargetShooting;
class Program
{
    static void Main(string[] args)
    {
        const int shotsCount = 3;
        Console.WriteLine("Get ready to make {0} shots", shotsCount);

        Random random = new Random();

        int targetX = random.Next(0, 4);
        int targetY = random.Next(0, 4);

        int score = 0;

        for (int i = 0; i < shotsCount; ++i)
        {
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = int.Parse(Console.ReadLine());

            if (random.Next(0, 10) == 5)
            {
                Console.WriteLine("Oops! Someone interrupted you!");
                x = random.Next(0, 4);
                y = random.Next(0, 4);
            }

            double distance = Math.Sqrt(
                Math.Pow(targetX - x, 2) + Math.Pow(targetY - y, 2));

            if (distance <= 1)
            {
                score += 10;
            }
            else if (distance <= 2)
            {
                score += 5;
            }
            else if (distance <= 3)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            Console.WriteLine("Score: {0}", score);
        }
    }
}

