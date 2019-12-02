using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
     class Figure
    {
        public double x { get; set; }
        public double y { get; set; }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public void ShowFigure()
        {
            CreateFigure();
        }
        public static void CreateFigure()
        {
            int enter;
            Figure number;
            do
            {
                Console.WriteLine("Перечень фигур: ");
                Console.WriteLine("1 - Line.");
                Console.WriteLine("2 - Circle.");
                Console.WriteLine("3 - Round.");
                Console.WriteLine("4 - Ring.");
                Console.WriteLine("5 - Rectangle.");
                Console.WriteLine("6 - Triangle.");
                Console.WriteLine("0 - Exit");
                if (Int32.TryParse(Console.ReadLine(), out enter))
                {
                    switch (enter)
                    {
                        case 1:
                            number = CreateLine();
                            break;
                        case 2:
                            number = CreateCircle();
                            break;
                        case 3:
                            number = CreateRound();
                            break;
                        case 4:
                            number = CreateRing();
                            break;
                        case 5:
                            number = CreateRectangle();
                            break;
                        case 6:
                            number = CreateTriangle();
                            break;
                        case 0:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат.");
                }
            } while (enter != 0);
        }

        class Circle : Figure
        {
            private int radius;

            public int Radius
            {
                get
                {
                    return radius;
                }
                set
                {
                    radius = value;
                }
            }

            public Circle(int x, int y, int radius)
            {
                X = x;
                Y = y;
                Radius = radius;
            }

            private double Length() => 2 * Math.PI * Radius;

            public static void CircleShow()
            {
                Console.WriteLine("Введите координату Х: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату Y: ");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус круга: ");
                int radius = int.Parse(Console.ReadLine());
                var f = new Circle(x, y, radius);
                Console.WriteLine("Координата X: {0}, Y: {1}. Радиус: {2}. Длина окружности: {3}.",
                                           f.X, f.Y, f.Radius, f.Length());
            }        
        }
        public static Figure CreateCircle()
        {
            Console.WriteLine("Введите радиус: ");
            int radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите X: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Координата X: {0}, Y: {1}. Радиус: {2}. Длина окружности: {3}.",
                                           x, y, radius, 2 * Math.PI * radius);
            return new Circle(x, y, radius);
        }

        public static Figure CreateRound()
        {
            Console.WriteLine("Введите радиус: ");
            int Radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите X: ");
            int Absciss = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int Ordinata = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Длина описанной окружности: " + 2 * Math.PI * Radius + " .Площадь " +
                ": " + Math.PI * Radius * Radius);
            return new Round(Absciss, Radius, Ordinata);

        }
        public static Figure CreateRing()
        {
            Console.WriteLine("Введите первый радиус: ");
            int Radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй радиус: ");
            int Second = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите X: ");
            int Absciss = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            int Ordinata = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Длина : " + 2 * Math.PI * (Second + Radius) + " .Площадь " +
                ": " + Math.PI * ((Radius * Radius) - (Second * Second)));

            return new Ring(Radius, Second, Absciss, Ordinata);
        }
        public static Figure CreateRectangle()
        {
            Console.WriteLine("Введите высоту прямоугольника: ");
            double Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника: ");
            double Width = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату X прямоугольника: ");
            double Absciss = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y прямоугольника: ");
            double Ordinata = double.Parse(Console.ReadLine());
            Console.WriteLine("Прямоугольник с высотой и шириной: " + Height + " и " + Width + ". Площадь: " 
                + Height* Width + ". Периметр: " + (Height * Width) *2);

            return new Rectangle(Height, Width, Absciss, Ordinata);
        }

        public static Figure CreateTriangle()
        {
            Console.WriteLine("Введите первую сторону треугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольника: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольника:");
            double c = double.Parse(Console.ReadLine());

            double p = ((a + b + c) / 2);
            double S = Math.Sqrt(p * (p - a) * (p - c) * (p - b));
            Console.WriteLine("Треугольник со сторонами: {0}, {1}, {2}." , a, b,c);
            Console.WriteLine("Периметр: " + (a+b+c) + ".Площадь :" + S);


            return new Triangle(a, b, c);
        }
        public static Figure CreateLine()
        {
            Console.WriteLine("Введите X для первой точки: ");
            double Point1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для первой точки: ");
            double Point2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X для второй точки: ");
            double Point3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для второй точки: ");
            double Point4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Линия с координатами \n первой точки X:{Point1}, Y:{Point2}" +
                $" и с координатами второй точки X:{Point3}, Y:{Point4} создана");              
            return new Line(Point1, Point2, Point3, Point4);
        }
        class Rectangle : Figure
        {

            private double _height;
            private double _width;

            public new double X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }
            public new double Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }
            }

            public double Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    if (value > 0)
                        _width = value;
                    else
                    { throw new ArgumentException(" Радиус не может быть отрицательным. "); }
                }
            }
            public double Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    if (value > 0)
                        _height = value;
                    else
                    { throw new ArgumentException(" Высота не может быть отрицательной. "); }
                }
            }

            public Rectangle(double Height, double Width, double Absciss, double Ordinata)
            {
                _height = Height;
                _width = Width;
                X = Absciss;
                Y = Ordinata;
            }
            
            }
        }
    class Line : Figure
    {
        private double _point1;
        private double _point2;
        private double _point3;
        private double _point4;

        public double Point1
        {
            get
            {
                return _point1;
            }
            set
            {
                _point1 = value;
            }
        }
        public double Point2
        {
            get
            {
                return _point2;
            }
            set
            {
                _point2 = value;

            }
        }
        public double Point3
        {
            get
            {
                return _point3;
            }
            set
            {
                _point3 = value;
            }
        }
        public double Point4
        {
            get
            {
                return _point4;
            }
            set
            {
                _point4 = value;
            }
        }


        public Line(double Point1, double Point2, double Point3, double Point4)
        {
            _point1 = Point1;
            _point2 = Point2;
            _point3 = Point3;
            _point4 = Point4;
        }
        public static void LineShow()
        {
            Console.WriteLine("Введите X для первой точки: ");
            double Point1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для первой точки: ");
            double Point2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите X для второй точки: ");
            double Point3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для второй точки: ");
            double Point4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Линия с координатами \n первой точки X:{Point1}, Y:{Point2}" +
                $" и с координатами второй точки X:{Point3}, Y:{Point4} создана");
        }
    }
    class VectorList
    {
        static void List()
        {
            var figures = new List<Figure> { Figure.CreateLine(), Figure.CreateCircle(),Figure.CreateRectangle(), Figure.CreateRing(),
            Figure.CreateRound(), Figure.CreateTriangle()};
            foreach (var figure in figures)
            {
                Console.WriteLine();
            }
        }
    }
}
