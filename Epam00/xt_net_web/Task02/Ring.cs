using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Ring : Round
    {
        private double _secondr;


            
        public Ring(double Radius, double Second, double Absciss, double Ordinata) : base(Radius, Second, Absciss)
        {
            this._radius = Radius;
            this._secondr = Second;
            this._x = Absciss;
        }


        public double Second
        {
            get
            {
                return _secondr;
            }
            set
            {
                if(_secondr < _radius)
                    _secondr = value;
                else
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего.");
            }
        }


        public double Length()
        {
            return 2 * Math.PI * (Second + Radius);
        }
       
        public  double Area()
        {
            return Math.PI * ((Radius * Radius) - (Second * Second));
        }


        public static void RingShow()
        {
            Console.WriteLine("Введите первый радиус: ");
            int Radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй радиус: ");
            int Second = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите X: ");
            int Absciss = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int Ordinata = Int32.Parse(Console.ReadLine());

            Ring f = new Ring(Second, Radius, Absciss , Ordinata);

            Console.WriteLine("Длина:  " + f.Length());
            Console.WriteLine("Площадь кольца: " + f.Area());     
        }
    }
}
