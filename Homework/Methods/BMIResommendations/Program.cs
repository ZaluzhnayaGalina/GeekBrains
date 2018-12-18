using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIResommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
             * 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
            double bmi_min = 19.0;
            double bmi_max = 24.0;
            Console.WriteLine("Рост (в метрах):");
            var h = ReadDouble("h");
            Console.WriteLine("Вес:");
            var m = ReadDouble("m");
            var bmi = m / (h * h);
            Console.WriteLine($"Ваш ИМТ: {bmi}");
            if (bmi > bmi_max)
                Console.WriteLine("Вам необходимо сбросить {0:F2} кг", Proficit(bmi_max, m, h));
            else if (bmi < bmi_min)
            {
                Console.WriteLine("Вам необходимо набрать  {0:F2} кг", Deficit(bmi_min, m, h));
            }
            else
                    Console.WriteLine("Ваш ИМТ в норме!");
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

        static double Deficit(double bmi_min, double m, double h)
        {
            return bmi_min * h * h - m;
        }
        static double Proficit(double bmi_max, double m, double h)
        {
            return m - bmi_max*h*h;
        }
    }
}
