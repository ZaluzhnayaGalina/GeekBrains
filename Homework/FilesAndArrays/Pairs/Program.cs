using System;

namespace Pairs
{
    class Program
    {
        /*Залужная 
         *
         * Дан целочисленный массив из 20 элементов, элементы могут принимать целые значения от -10000 до 10000 включительно.
         * Написть программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
         * Пара - два подряд идущих элементов массива.
         */
        static void Main(string[] args)
        {
            var array = GenerateArray(20, -10000, 10000);
            PrintArray(array);
            int pairsCount = 0;
            for(int i=0; i<array.Length-1;i++)
                if (IsPair(array[i], array[i + 1]))
                    pairsCount++;
            Console.WriteLine("Число пар: {0}", pairsCount);
            Console.ReadLine();

        }

        public static int[] GenerateArray(int count, int min, int max)
        {
            var rand = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }

        public static bool IsPair(int a, int b)
        {
            return a % 3 == 0 || b % 3 == 0;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}  ");
            Console.Write("\n");
        }
    }
}
