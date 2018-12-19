using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
             * 6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
             * Хорошим называется число, которое делится на сумму своих цифр.
             * Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/
            int higher = 1000000000;
            int count = 0;
            var begin = DateTime.Now;
            for (int n = 1; n <= higher; n++)
            {
                if (IsGood(n))
                
                    count++;
                
            }
            var end = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine("\"Хороших\" чисел: {0}", count);
            Console.WriteLine("Времени потрачено: {0} с", (end-begin).TotalMilliseconds/1000f);
            Console.ReadLine();
        }

        static bool IsGood(int number)
        {
            return number % SumDigits(number) == 0;
        }

        static int SumDigits(int number)
        {
            int sum = 0;
            while (number / 10 != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            sum += number % 10;
            return sum;
        }
    }
}
