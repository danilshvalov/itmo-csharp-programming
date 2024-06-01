namespace Loop;
class Program
{
    static void Main(string[] args)
    {
        int a, b, temp;

        Console.WriteLine("Enter a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        b = int.Parse(Console.ReadLine());

        temp = a;
        while (temp != b)
        {
            a = temp;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            temp = a - b;
            a = b;
        }

        Console.WriteLine("GCD: {0}", a);
    }
}
