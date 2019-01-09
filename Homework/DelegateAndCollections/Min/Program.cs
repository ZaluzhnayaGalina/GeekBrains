using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
 /*Залужная
  *2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    возвращает минимум через параметр.*/
namespace Min
{
    class Program
    {
        public static double SimpleParabola(double x)
        {
            return x * x;
        }

        public static double Parabola(double x)
        {
            return x * x - 4 * x + 3; //(x-1)(x-3)
        }

        public static double Polynomial(double x)
        {
            return x * x * x - 4 * x * x - 7 * x + 10; //(x+2)(x-1)(x-5)
        }


        static void Main(string[] args)
        {
            var list = new List<Func>() {SimpleParabola, Parabola, Polynomial};
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1. x^2");
            Console.WriteLine("2. (x-1)(x-3)");
            Console.WriteLine("3.(x+2)(x-1)(x-5)");
            int i = ReadInt();
            Console.WriteLine("Введите границы отрезка");
            double x1 = ReadDouble();
            double x2 = ReadDouble();
            var helper = new BinaryFuncHelper(list[i-1], 0.1, Math.Min(x1,x2), Math.Max(x1,x2));
            helper.SaveFunc("example.bin");
            helper.Load("example.bin", out double min);
            Console.WriteLine($"Минимум: {min}");
            Console.ReadLine();
        }

        static int ReadInt()
        {
            bool b;
            int res;
            do
            {
                var s = Console.ReadLine();
                b = int.TryParse(s, out  res);

            } while (!b);
            return res;
        }
        static double ReadDouble()
        {
            bool b;
            double res;
            do
            {
                var s = Console.ReadLine();
                b = double.TryParse(s, out res);

            } while (!b);
            return res;
        }
    }
}
