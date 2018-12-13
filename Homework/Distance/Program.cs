using System;
namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = ReadDouble("x1");
            var y1 = ReadDouble("y1");
            var x2 = ReadDouble("x2");
            var y2 = ReadDouble("y2");
            Console.WriteLine("Расстояние между точками: {0:F2}", Distance(x1,y1,x2,y2));
            Console.ReadLine();
        }

        static double ReadDouble(string name)
        {
            string tmp = null;
            Console.WriteLine($"{name}:");
            while (tmp is null || tmp == "")
                tmp = Console.ReadLine();
            return double.Parse(tmp);
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
        }
    }
}
