using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.*/
            int sum = 0;
            int x = 0;
            do
            {
                x = ReadInt("x");
                if (IsPositive(x) && IsOdd(x))
                    sum += x;
            } while (x!=0);
            Console.WriteLine("Сумма: {0}",sum);
            Console.ReadLine();
        }
        static int ReadInt(string name)
        {
            string tmp = null;
            Console.WriteLine($"{name}:");
            while (tmp is null || tmp == "")
                tmp = Console.ReadLine();
            try
            {
                return int.Parse(tmp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
            
        }

        static bool IsPositive(int n)
        {
            return n > 0;
        }

        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
    }
}
