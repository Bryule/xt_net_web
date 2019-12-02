using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string [] args)
        {
            int enter;
            do
            {
                Console.WriteLine("Перечень заданий: ");
                Console.WriteLine("1 - Round.");
                Console.WriteLine("2 - Triangle.");
                Console.WriteLine("3 - User.");
                Console.WriteLine("4 - MyString.");
                Console.WriteLine("5 - Employee.");
                Console.WriteLine("6 - Ring.");
                Console.WriteLine("7 - VectorGraphics");
                Console.WriteLine("0 - Exit");
                if (Int32.TryParse(Console.ReadLine(), out enter))
                {
                    switch (enter)
                    {
                        case 1:
                            Round.RoundShow();
                            Console.WriteLine();
                            break;
                        case 2:
                            Triangle.TriangleShow();
                            Console.WriteLine();
                            break;
                        case 3:
                            User.UserShow();
                            Console.WriteLine();
                            break;
                        case 4:
                            MyString.StringShow();
                            Console.WriteLine();
                            break;
                        case 5:
                            Employee.EmployeeShow();
                            Console.WriteLine();
                            break;
                        case 6:
                            Ring.RingShow();
                            Console.WriteLine();
                            break;
                        case 7:
                            Figure.CreateFigure();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат.");
                }
            } while (enter != 0);
        }
    
    }

}






      
  
