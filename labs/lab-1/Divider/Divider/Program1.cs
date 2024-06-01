namespace Divider;
class DivideIt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first integer");
        string temp = Console.ReadLine();
        int i = Int32.Parse(temp);
        Console.WriteLine("Please enter the second integer");
        temp = Console.ReadLine();
        int j = Int32.Parse(temp);
        int k = i / j;
        Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
    }
}

