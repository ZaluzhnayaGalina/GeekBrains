using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexStruct
{
    /*Залужная
     * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
     * Продемонстрировать работу структуры;*/
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Console.WriteLine(c1);
            Complex c2 = new Complex(2,1);
            Console.WriteLine(c2);
            c1.Add(c2);
            Console.WriteLine(" c1 + c2 = {0}", c1);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            try
            {
                c1.Division(c2);
                Console.WriteLine($"({c1})/({c2}) = {c1}");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
    struct Complex
    {
        private double _re;
        private double _im;
        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }
        public double GetReal()
        {
            return _re;
        }
        public double GetIm()
        {
            return _im;
        }
        public void Conjugation()
        {
            _im = -_im;
        }
        public double Module()
        {
            return Math.Sqrt(_re * _re + _im * _im);
        }
        public void Add(double r)
        {
            _re += r;
        }
        public void Add(Complex c)
        {
            _re += c.GetReal();
            _im += c.GetIm();
        }
        public void Substract(double r)
        {
            _re -= r;
        }
        public void Substract(Complex c)
        {
            _re -= c.GetReal();
            _im -= c.GetIm();
        }
        public void Multiply(double r)
        {
            _re *= r;
            _im *= r;
        }
        public void Multiply(Complex c)
        {
            _re = _re * c.GetReal() - _im * c.GetIm();
            _im = _re * c.GetIm() + _im * c.GetReal();
        }
        public void Division(double r)
        {
            try
            {
                _re /= r;
                _im /= r;
            }
            catch
            {
                throw new ArgumentException("Деление на ноль!");
            }
        }
        public void Division(Complex c)
        {
            try
            {
                c.Conjugation();
                Multiply(c);
                Division(c.Module()* c.Module());
            }
            catch
            {
                throw new ArgumentException("Деление на ноль!");
            }
        }
        public override string ToString()
        {
            if (_im > 0)
                return _re + " + i*" + _im;
            else if (_im < 0)
                return _re + " - i*" + Math.Abs(_im);
            else return _re.ToString("F2");
        }
    }
}
