using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public double AValue
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }
        public double BValue
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        public double CValue
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }

        public bool PostiveValues
        {
            get
            {
                return (_a > 0 && _b > 0 && _c > 0);
            }
        }
        public bool Exist
        {
            get
            {
                return ((_a + _b < _c) || (_b + _c > _a) || (_c + _a > _b));
            }
        }

        public void Show()
        {
            Console.WriteLine("Сторона а = {0}, сторона b = {1} , сторона с = {2}", _a, _b, _c);
        }
        public double Perimetr
        {
            get
            {
                double P = _a + _b + _c;
                return P;
            }
        }

        public Triangle(double a,double b,double c)
        {
            AValue = a;
            BValue = b;
            CValue = c;
        }

        public double Area
        {
            get
            {
                double p = ((_a + _b + _c) / 2);
                double S = Math.Sqrt(p * (p - _a) * (p - _c) * (p - _b));
                return S;
            }
        }
        public static void TriangleShow()
        {

            double a;
            double b;
            double c;

            Console.WriteLine("Введите поочередно три стороны треугольника: ");
            bool a1 = true;
            bool b1 = true;
            bool c1 = true;

            a1 =  double.TryParse(Console.ReadLine(), out a);
            b1 =  double.TryParse(Console.ReadLine(), out b);
            c1 =  double.TryParse(Console.ReadLine(), out c);

            Triangle t = new Triangle(a, b, c);

            if (t.Exist && t.PostiveValues == true)
            {
                t.Show();                
                Console.WriteLine("Периметр треугольника " + t.Perimetr);
                Console.WriteLine("Площадь треугольника " + t.Area);
            }
            else Console.WriteLine("Треугольник с такими сторонами существовать не может!");
        }
       
    }
}