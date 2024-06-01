namespace Loop;
class Program
{
    static void Main(string[] args)
    {
        int[] myArray;

        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        myArray = new int[n];

        for (int i = 0; i < myArray.Length; ++i)
        {
            Console.Write("a[{0}]=", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        foreach (int x in myArray)
        {
            Console.Write("{0} ", x);
        }
    }
}

