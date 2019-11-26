using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round
    {
        private double _radius;
        private double _x;
        private double _y;


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
        public static void Asp()
        {
            Round ring = new Round();
            Console.WriteLine("Введите радиус круга: ");
            ring.Radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X круга: ");
            ring.Absciss = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y круга: ");
            ring.Ordinata = double.Parse(Console.ReadLine());

            Console.WriteLine("Радиус круга: " + ring.Radius);
            Console.WriteLine("Координата X: " + ring.Absciss);
            Console.WriteLine("Координата Y: " + ring.Ordinata);
            Console.WriteLine("Длина описанной окружности: " + ring.CircleRange);
            Console.WriteLine("Площадь круга: " + ring.CircleArea);

        }
    }
}
