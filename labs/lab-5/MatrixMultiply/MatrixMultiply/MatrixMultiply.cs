namespace MatrixMultiply;
class MatrixMultiply
{
    static void Main(string[] args)
    {
        int[,] a = new int[2, 2];
        a[0, 0] = 1;
        a[0, 1] = 2;
        a[1, 0] = 3;
        a[1, 1] = 4;

        int[,] b = new int[2, 2];
        b[0, 0] = 5;
        b[0, 1] = 6;
        b[1, 0] = 7;
        b[1, 1] = 8;

        int[,] result = new int[2, 2];
        result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
        result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
        result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
        result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

        Console.WriteLine(result[0, 0]);
        Console.WriteLine(result[0, 1]);
        Console.WriteLine(result[1, 0]);
        Console.WriteLine(result[1, 1]);
    }
}

