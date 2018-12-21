using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Program
    {
        /*Залужная
         * 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
         * Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    ArgumentException("Знаменатель не может быть равен 0");
    Добавить упрощение дробей.*/
        static void Main(string[] args)
        {
           var r1 = new Rational(3,15);
            Console.WriteLine($"r1: {r1}");
            r1.Simplify();
            Console.WriteLine($"Упростили: {r1}");
            try
            {
                var r2 = new Rational(3,0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            var r3 = new Rational(2,-5);
            Console.WriteLine($"r3: {r3}");
            Console.WriteLine($"r1 + r3 = {r1+r3}");
            Console.WriteLine($"r1 - r3 = {r1 - r3}");
            Console.WriteLine($"r1 * r3 = {r1 * r3}");
            Console.WriteLine($"r1 / r3 = {r1 / r3}");
            int r4 = 3;
            Console.WriteLine($"r4: {r4}");
            Console.WriteLine($"r1 + r4 = {r1 + r4}");
            Console.WriteLine($"r1 - r4 = {r1 - r4}");
            Console.WriteLine($"r1 * r4 = {r1 * r4}");
            Console.WriteLine($"r1 / r4 = {r1 / r4}");
            Console.ReadLine();

        }
    }
}
