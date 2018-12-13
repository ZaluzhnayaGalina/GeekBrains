using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
            Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.*/

            Console.WriteLine("Имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            var surname = Console.ReadLine();
            Console.WriteLine("Возраст");
            var age = Console.ReadLine();
            Console.WriteLine("Рост:");
            var height = Console.ReadLine();
            Console.WriteLine("Вес:");
            var mass =Console.ReadLine();
            Console.WriteLine("Имя: " + name + ", фамилия: " + surname + ", возраст: " + age + ", рост: " + height + ", вес: " + mass);
            Console.WriteLine("Имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}", name, surname, age, height, mass);
            Console.WriteLine($"Имя: {name}, фамилия: {surname}, возраст: {age}, рост: {height}, вес: {mass}");
            Console.ReadLine();
        }
    }
}
