using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDelegate
{
    delegate double FuncWithParam(double param, double x);
    class Program
    {
        public static void Table(FuncWithParam F, double x,double a, double b)
        {
            Console.WriteLine($"a={a}");
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }


        static void Main(string[] args)
        {
            double xmin = 0;
            double xmax = 7;
            double param = 2.1;
            Console.WriteLine("F(x)=a*x^2");
            Table(Parabola, xmin, param, xmax);
            Console.WriteLine("F(x)=a*sin(x)");
            Table(ASin, xmin, param, xmax);
            Console.ReadLine();
        }
        static double Parabola(double a, double x)
        {
            return a * x * x;
        }
        static double ASin(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
