using System.IO;

namespace Min
{
    delegate double Func(double x);
    class BinaryFuncHelper
    {
        private Func _func;
        private double _h;//шаг
        private double _xmin, _xmax;
        public BinaryFuncHelper(Func func, double h, double x_min, double x_max)
        {
            _func = func;
            _h = h;
            _xmin = x_min;
            _xmax = x_max;
        }
        public void SaveFunc(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = _xmin;
            while (x <= _xmax)
            {
                bw.Write(_func(x));
                x += _h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] result = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                result[i] = bw.ReadDouble();
                if (result[i] < min)
                    min = result[i];
            }
            bw.Close();
            fs.Close();
            return result;

        }

    }
}
