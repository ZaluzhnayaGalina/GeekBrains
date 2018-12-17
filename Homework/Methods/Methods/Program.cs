using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Залужная
            Console.WriteLine(Minimum(2, 3, 4));
            Console.WriteLine(Minimum(3, 2, 1));
            Console.WriteLine(Minimum(4, -8, 2));
            Console.WriteLine(CountDigits(-100));
            Console.WriteLine(CountDigits(18));
            Console.WriteLine(CountDigits(1782391437023));
            Console.ReadLine();
        }
        //1. Написать метод, возвращающий минимальное из трех чисел.
        static double Minimum(double x1, double x2, double x3)
        {
            //возможное решение
            //return Math.Min(x1, Math.Min(x2, x3));
            var min = x1;
            if (x2 < min)
                min = x2;
            if (x3 < min)
                min = x3;
            return min;
        }
        //2. Написать метод подсчета количества цифр числа.
        static double CountDigits(long number)
        {
            int digits = 1;
            while (number / 10 != 0)
            {
                digits++;
                number = number / 10;
            }
            return digits;
        }
    }
}
