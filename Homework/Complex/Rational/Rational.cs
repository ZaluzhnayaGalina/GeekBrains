using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class Rational
    {
        private int _num;
        private int _denom;

        public int Num
        {
            get => _num;
            set { _num = value; }
        }

        public int Denom
        {
            get => _denom;
            set
            {
                if (value==0)
                    throw new ArgumentException("Знаменатель не может быть равен 0!");
                _denom = value;
            }
        }

        public Rational(int a, int b)
        {

            if (b > 0)
            {
                Num = a;
                Denom = b;
            }
            else
            {
                Num = -a;
                Denom = -b;
            }
        }

        public void Simplify()
        {
            int max = Math.Max(Math.Abs(_num), _denom);
            int min = Math.Min(Math.Abs(_num), _denom);
            int r;
            do
            {
                r = max % min;
                max = min;
                min = r;

            } while (r!=0);
            _num /= max;
            _denom /= max;

        }

        public override string ToString()
        {
            if (Denom == 1)
                return Num.ToString();
            return Num + "/" + Denom;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            var r = new Rational(r1.Num*r2.Denom+r1.Denom*r2.Num, r1.Denom*r2.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            var r = new Rational(r1.Num * r2.Denom - r1.Denom * r2.Num, r1.Denom * r2.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            var r = new Rational(r1.Num * r2.Num, r1.Denom * r2.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            var r = new Rational(r1.Num * r2.Denom , r1.Denom * r2.Num);
            r.Simplify();
            return r;
        }
        public static Rational operator +(Rational r1, int r2)
        {
            var r = new Rational(r1.Num + r1.Denom * r2, r1.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator -(Rational r1, int r2)
        {
            var r = new Rational(r1.Num - r1.Denom * r2, r1.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator *(Rational r1, int r2)
        {
            var r = new Rational(r1.Num * r2, r1.Denom);
            r.Simplify();
            return r;
        }
        public static Rational operator /(Rational r1, int r2)
        {
            var r = new Rational(r1.Num, r1.Denom * r2);
            r.Simplify();
            return r;
        }

    }
}
