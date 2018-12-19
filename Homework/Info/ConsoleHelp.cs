using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public static class ConsoleHelp
    {
        /*Залужная
        6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).*/
        public static double ReadDouble(string name)
        {
            string tmp = null;
            Console.WriteLine($"{name}:");
            while (tmp is null || tmp == "")
                tmp = Console.ReadLine();
            return double.Parse(tmp);
        }
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);

        }
        static void PrintCenter(string msg)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(msg);

        }
    }
}
