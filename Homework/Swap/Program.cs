using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.*/
            var x = ReadDouble("x");
            var y = ReadDouble("y");
            //а
            var tmp = x;
            x = y;
            y = tmp;
            Console.WriteLine("Поменяли");
            Console.WriteLine($"x: {x}, y:{y}");
            //б
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Обратно");
            Console.WriteLine($"x: {x}, y:{y}");
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
    }
}
