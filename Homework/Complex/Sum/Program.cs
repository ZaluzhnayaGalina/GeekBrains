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
                else
                {
                    x = 1;
                    Console.WriteLine("Введены неверные данные!");
                }

            }
            while (x != 0);
            Console.WriteLine($"Сумма: {sum} ");
            Console.ReadLine();
        }
    }
}
