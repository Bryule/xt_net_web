using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round : Figure
    {
        internal double _radius;
        internal double _x;
        internal double _y;

        public double Absciss
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double Ordinata
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                    _radius = value;
                else
                { throw new ArgumentException(" Радиус не может быть отрицательным. "); }
            }
        }

        public double CircleRange
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }
        public double CircleArea
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Round(double Radius, double Absciss, double Ordinata)
        {
            _radius = Radius;
            _x = Absciss;
            _y = Ordinata;
        }

        public static void RoundShow()
        {
            Console.WriteLine("Введите радиус круга: ");
            double Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X круга: ");
            double Absciss = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y круга: ");
            double Ordinata = double.Parse(Console.ReadLine());

            Round ring = new Round(Radius, Absciss, Ordinata);

            Console.WriteLine("Радиус круга: " + ring.Radius);
            Console.WriteLine("Координата X: " + ring.Absciss);
            Console.WriteLine("Координата Y: " + ring.Ordinata);
            Console.WriteLine("Длина описанной окружности: " + ring.CircleRange);
            Console.WriteLine("Площадь круга: " + ring.CircleArea);

        }
    }
}
