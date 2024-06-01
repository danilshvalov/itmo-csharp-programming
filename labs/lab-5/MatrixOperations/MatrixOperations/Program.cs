namespace MatrixOperations;
class MatrixOperations
{
    private static double[] ReadArray()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("a[{0}]=", i);
            array[i] = double.Parse(Console.ReadLine());
        }

        return array;
    }

    private static double Sum(double[] array)
    {
        double total = 0;
        foreach (double value in array)
        {
            total += value;
        }
        return total;
    }

    private static double Average(double[] array)
    {
        return Sum(array) / array.Length;
    }

    private static double SumPositive(double[] array)
    {
        double total = 0;
        foreach (double value in array)
        {
            if (value > 0)
            {
                total += value;
            }
        }
        return total;
    }

    private static double SumNegative(double[] array)
    {
        double total = 0;
        foreach (double value in array)
        {
            if (value < 0)
            {
                total += value;
            }
        }
        return total;
    }

    private static double SumEven(double[] array)
    {
        double total = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            total += array[i];
        }
        return total;
    }

    private static double SumOdd(double[] array)
    {
        double total = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            total += array[i];
        }
        return total;
    }

    private static int MaxIndex(double[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; ++i)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    private static int MinIndex(double[] array)
    {
        int minIndex = 0;
        for (int i = 1; i < array.Length; ++i)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    private static double MultiplyBetweenMinMax(double[] array)
    {
        int minIndex = MinIndex(array);
        int maxIndex = MaxIndex(array);
        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex) - 1;

        if (start > end)
        {
            return 0;
        }

        double total = 1;
        for (int i = start; i <= end; ++i)
        {
            total *= array[i];
        }
        return total;
    }

    static void Main(string[] args)
    {
        double[] array = ReadArray();
        Console.WriteLine("Sum: {0}", Sum(array));
        Console.WriteLine("Average: {0}", Average(array));
        Console.WriteLine("Sum positive: {0}", SumPositive(array));
        Console.WriteLine("Sum negative: {0}", SumNegative(array));
        Console.WriteLine("Sum even: {0}", SumEven(array));
        Console.WriteLine("Sum odd: {0}", SumOdd(array));
        Console.WriteLine("Max index: {0}", MaxIndex(array));
        Console.WriteLine("Min index: {0}", MinIndex(array));
        Console.WriteLine(
	        "Multiply between min and max: {0}", MultiplyBetweenMinMax(array)
	    );
    }
}

