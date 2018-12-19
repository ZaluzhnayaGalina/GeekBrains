using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организуйте в центре экрана
            в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)*/
            //а
            var info = "Галина Залужная, Москва";
            Console.WriteLine(info);
            //б
            Console.SetCursorPosition(Console.WindowWidth / 2 - info.Length/2, Console.WindowHeight / 2);
            Console.WriteLine(info);
            Console.ReadLine();
            Console.Clear();
            //в
            PrintCenter(info);
            Console.ReadLine();
        }
        //в
        static void PrintCenter(string msg)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(msg);

        }
    }
}
