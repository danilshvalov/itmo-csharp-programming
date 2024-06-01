using System;

namespace Distance;

public struct Distance
{
    public int feet;
    public int inch;
}

class Program
{
    static void Main(string[] args)
    {
        Distance distance1, distance2, distance3;

        Console.WriteLine("Enter the first distance in inches:");
        distance1.inch = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second distance in inches:");
        distance2.inch = int.Parse(Console.ReadLine());

        distance3.inch = distance1.inch + distance2.inch;

        const int inches_in_feet = 12;

        distance1.feet = (int)(distance1.inch / inches_in_feet);
        distance1.inch = distance1.inch % inches_in_feet;
        distance2.feet = (int)(distance2.inch / inches_in_feet);
        distance2.inch = distance2.inch % inches_in_feet;
        distance3.feet = (int)(distance3.inch / inches_in_feet);
        distance3.inch = distance3.inch % inches_in_feet;

        Console.WriteLine("Distance 1: {0}'-{1}\"", distance1.feet, distance1.inch);
        Console.WriteLine("Distance 2: {0}'-{1}\"", distance2.feet, distance2.inch);
        Console.WriteLine("Distance 3: {0}'-{1}\"", distance3.feet, distance3.inch);
    }
}

