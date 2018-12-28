using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        /*Залужная
         2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
         Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные
        При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/
        static void Main(string[] args)
        {
            int x = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Введиете целое число:");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x % 2 > 0)
                    {

                        sum += x;
                    }
                }
                else IncorrectData(ref x);

            }
            while (x != 0);
            Console.WriteLine($"Сумма: {sum} ");
            Console.ReadLine();
        }

        static void IncorrectData(ref int x)
        {
            x = 1; //заглушка, чтобы цикл не прекращался
            Console.WriteLine("Введены неверные данные!");
        }
    }
}
