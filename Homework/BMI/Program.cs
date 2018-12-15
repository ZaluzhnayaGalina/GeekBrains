using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Залужная
              Ввести вес и рост человека. 
              Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах*/
            string tmp=null;
            Console.WriteLine("Рост (в метрах):");
            while(tmp is null|| tmp == "")
                tmp = Console.ReadLine();
            var h = double.Parse(tmp);
            Console.WriteLine("Вес:");
            tmp = null;
            while (tmp is null)
                tmp = Console.ReadLine();
            var m = double.Parse(tmp);
            Console.WriteLine($"Ваш ИМТ: {m/(h*h)}");
            Console.ReadLine();
        }
    }
}
