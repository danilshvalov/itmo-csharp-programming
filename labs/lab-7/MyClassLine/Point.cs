using System;

namespace MyClassLine
{
    public class Point
    {
        private double x;
        private double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() { }

        public void Show()
        {
            Console.WriteLine("Точка с координатами: ({0}, {1})");
        }

        public double Dlina(Point p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }

        public override string ToString()
        {
            return x + " ; " + y;
        }
    }
}
