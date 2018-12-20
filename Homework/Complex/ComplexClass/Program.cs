using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Complex(1, 2);
            var c2 = new Complex(2, 1);
            var c3 = 0;
            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");
            Console.WriteLine($"c1+c2 = {c1+c2}");
            Console.WriteLine($"c1-c2 = {c1 - c2}");
            Console.WriteLine($"c1*c2 = {c1 * c2}");
            try
            {
                Console.WriteLine($"c1/c2 = {c1 / c2}");
                Console.WriteLine($"c1/0 = {c1/c3}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
