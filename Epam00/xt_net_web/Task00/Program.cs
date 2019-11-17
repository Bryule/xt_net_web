using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task00
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            Console.WriteLine(" Строка");
            Console.WriteLine("Введите размер строки: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Sequence(N);


            Console.WriteLine("\n\n Простое число");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Simple(n);
            if (Simple(n) == true)
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число составное");


            Console.WriteLine("\n\n Квадрат");
            int f = Convert.ToInt32(Console.ReadLine());
            Square(f);

            Console.WriteLine("\n\n Массив");
            Console.WriteLine("Введите размерность массива: ");
            int Z = Convert.ToInt32(Console.ReadLine());
            int[][] Array = new int[Z][];
            for (int i = 0; i < Z; i++)
            {
                Console.Write("Введите размерность" + i + "-го" + " подмассива: ");
                int point = Convert.ToInt32(Console.ReadLine());
                Array[i] = new int[point];
            }
            RandomNumb(Array);
            Console.WriteLine("Неотсортированный массив: ");
            Show(Array);
            Sort(Array);
            Console.WriteLine("Отсортированный массив: ");
            Show(Array);
            Console.ReadLine();

        }
        #endregion


        #region Sequence
        static int Sequence(int N)
        {
            Console.Write(" ");
            for (int i = 1; i <= N; i++)
                Console.Write(i + " ");
            return 0;
        }

        #endregion


        #region Simple   

        static bool Simple(int n)
        {
            bool result = true;
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        #endregion


        #region Square
        static int Square(int f)
        {
            int row = f / 2;
            if (f % 2 == 0)
            {
                Console.WriteLine("Число четное, введите нечетное");
            }
            else
                for (int i = 0; i < f; i++)
                {
                    if (i != 0)
                    {
                        Console.WriteLine();
                    }

                    for (int j = 0; j < f; j++)
                    {
                        if (i != row || j != row)
                            Console.Write("*");
                        else
                            Console.Write(" ");

                    }
                }
            return 0;
        }
        #endregion


        #region Array
        static void RandomNumb(int[][] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = rnd.Next(0, 100);
            }
        }

        static void Show(int[][] Array1)
        {
            Console.Write("{");
            foreach (int[] i in Array1)
            {
                Console.Write("{ ");
                foreach (int elem in i)
                {
                    Console.Write(elem + ", ");
                }
                Console.Write(" }");
            }
            Console.WriteLine("}");
        }

        static void Sort(int[][] Array1)
        {
            int i = 0;
            foreach (int[] elem in Array1)
                i += elem.Length;
            int[] arr = new int[i];
            i = 0;
            for (int l = 0; l < Array1.Length; l++)
            {
                for (int k = 0; k < Array1[l].Length; k++)
                {
                    arr[i] = Array1[l][k];
                    i++;
                }
            }
            Array.Sort(arr);
            i = 0;
            for (int l = 0; l < Array1.Length; l++)
            {
                for (int k = 0; k < Array1[l].Length; k++)
                {
                    Array1[l][k] = arr[i];
                    i++;
                }
            }
        }
    }
}
#endregion

