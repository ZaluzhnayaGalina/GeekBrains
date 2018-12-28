using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public class Complex
    {
        private double _re;
        private double _im;
        public double Re
        {
            get
            {
                return _re;
            }
            set
            {
                _re = value;
            }
        }
        public double Im
        {
            get
            {
                return _im;
            }
            set
            {
                _im = value;
            }
        }
        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }
        public double Module => Math.Sqrt(_re * _re + _im * _im);
        public Complex Conjugation()
        {
            return new Complex(_re,-_im);
        }
        public override string ToString()
        {
            if (_im > 0)
                return _re + " + i*" + _im;
            else if (_im < 0)
                return _re + " - i*" + Math.Abs(_im);
            else return _re.ToString("F2");
        }
        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
        }
        public static Complex operator - (Complex c1, Complex c2)
        {
            return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
        }
        public static Complex operator * (Complex c1, Complex c2)
        {
            return new Complex(c1.Re + c2.Re - c1.Im*c2.Im, c1.Im*c2.Re + c2.Im*c1.Re);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            if (c2.Module==0)
                throw new ArgumentException("Деление на ноль!");

            return c1 * c2.Conjugation() / (c2.Module * c2.Module);
        
        }
        public static Complex operator +(Complex c1, double c2)
        {
            return new Complex(c1.Re + c2, c1.Im);
        }
        public static Complex operator -(Complex c1, double c2)
        {
            return new Complex(c1.Re - c2, c1.Im);
        }
        public static Complex operator *(Complex c1, double c2)
        {
            return new Complex(c1.Re * c2, c1.Im * c2);
        }
        public static Complex operator /(Complex c1, double c2)
        {
            if (c2==0)
                throw new ArgumentException("Деление на ноль!");            
            return new Complex(c1.Re / c2, c1.Im / c2);
            
        }
    }
}
