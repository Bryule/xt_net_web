using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Площадь прямоугольника:");
            Rectangle();
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nВведите количество строк для прямоугольного треугольника: ");
            string StrNumber = Console.ReadLine();
            Triangle(StrNumber);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nВведите количество строк для равнобедренного треугольника: ");
            string StrNumber1 = Console.ReadLine();
            AnotherTriangle(StrNumber1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nВведите количество треугольников для новогодней елки: ");
            string StrNumber2 = Console.ReadLine();
            Xmas(StrNumber2);
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nСумма кратных чисел для 3,5 и меньше 1000: ");
            Console.WriteLine(NaturalSum());
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nМассив: ");
            MassivMinMax();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Трехмерный массив: ");
            CubeArray();
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nCумма неотрицательных чисел массива: ");
            NonNegative();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Сумма элементов массива на четных позициях: ");
            int[][] array2d = new int[5][];       
        }

        #region Rectangle
        static void Rectangle()
        {
            int b = 0;
            int a = 0;
            Console.WriteLine("Поочередно введите две стороны: ");
            while (!Int32.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите натуральное число. ");
            }

            while (!Int32.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите натуральное число. ");
            }

            if(a<=0 || b<=0)
            {
                Console.WriteLine("Ошибка, число отрицательно или равно нулю.");
            }
            else
            {
                Console.WriteLine("Площадь: " + a*b);
            }
            
        }
        #endregion


        #region FirstTriangle
        /// <summary>
        /// Прямоугольный треугольник
        /// </summary>
        /// <param name="StrNumber"></param>
        /// <returns></returns>
        static string Triangle(string StrNumber)
        {
            int result = 0;

            bool Conversion = int.TryParse(StrNumber, out result);

            if (Conversion)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число или строку!");
            }

            for (int i = 0; i < result; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("*");

            }
            return StrNumber;
        }
        #endregion


        #region AnotherTriangle
        /// <summary>
        /// Равнобедренный треугольник
        /// </summary>
        /// <param name="StrNumber1"></param>
        /// <returns></returns>
        static string AnotherTriangle(string StrNumber1)
        {
            int result1 = 0;

            bool Conversion = int.TryParse(StrNumber1, out result1);

            if (Conversion)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число!");
            }

            for (int i = 1; i <= result1; i++)
            {
                for (int j = 0; j < result1 - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.Write('*');
                for (int j = 1; j < i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
            return StrNumber1;
        }
        #endregion


        #region Xmastree
        /// <summary>
        /// Елка
        /// </summary>
        /// <param name="StrNumber2"></param>
        /// <returns></returns>
        static string Xmas(string StrNumber2)
        {
            int result2 = 0;

            bool Conversion = int.TryParse(StrNumber2, out result2);

            if (Conversion)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вы ввели не целое число!");
            }
            result2+=1;
            for (int i = 1; i <= result2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 0; k < result2 - j; k++)
                    {
                        Console.Write(' ');
                    }

                    for (int k = 1; k < j; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write('*');
                    for (int k = 1; k < j; k++)
                    {
                        Console.Write('*');
                    }

                    Console.WriteLine();
                }
            }
            return StrNumber2;
        }


        #endregion


        #region NaturalSum
        /// <summary>
        /// Выводит сумму всех чисел кратных 3 и 5, меньше 1000
        /// </summary>
        /// <returns></returns>
        static int NaturalSum()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
        #endregion


        #region MinMaxValue.ArrayProcessing
        /// <summary>
        /// Генерирует массив, сортирует и выводит минимальное и максимальное значение
        /// </summary>
        /// <returns></returns>
        static int[] MassivMinMax()
        {
            int[] mas = new int[8];
            Random rnd = new Random();

            for (int i = 0; i < mas.Length; i++)
                mas[i] = rnd.Next(-100, 100);
            Console.WriteLine(" ");
            foreach (int elem in mas)
                Console.Write(elem + " ");
            ArraySort(mas);
            Console.WriteLine(" ");
            foreach (int elem in mas)
                Console.Write(elem + " ");
            Console.WriteLine(" ");
            Console.WriteLine("Минимальный элемент массива: " + mas[0]);
            Console.WriteLine("Минимальный элемент массива: " + mas[mas.Length - 1]);
            return mas;
        }
        #endregion


        #region NoPositive
        /// <summary>
        /// Замена в трехмерном массиве положительных чисел на 0
        /// </summary>
        /// <returns></returns>
        private static int[,,] CubeArray()
        {
            Random random = new Random();
            int[,,] array = new int[3, 3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        array[x, y, z] = random.Next(-100,100);
                    }
                }
            }
            ShowCube(array);
            Console.WriteLine(" ");
            Console.WriteLine("Измененный трехмерный массив: ");

            int row = array.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
            ShowCube(array);
            return array;
        }
        #endregion


        #region ShowCubeMas
        /// <summary>
        /// Отображение трехмерного массива
        /// </summary>
        /// <param name="array"></param>
        private static void ShowCube(int[,,] array)
        {
            int count = array.GetLength(0);
            for (int i = 0; i < count; i++)
            {
                Console.Write("{");
                for (int j = 0; j < count; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write($"{array[i, j, k]} ");
                    }
                    Console.Write("} ");
                }
                Console.WriteLine("}");
            }
        }
        #endregion


        #region NonNegative
        /// <summary>
        /// Определяет сумму положительных чисел массива
        /// </summary>
        /// <returns></returns>
        static int NonNegative()
        {
            int[] array = new int[8];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            Console.Write("Cам массив: ");
            foreach (int elem in array)
                Console.Write(elem + " ");
            Console.WriteLine(" ");
            int sum = 0;

            foreach (int a in array)
            {
                if (a > 0)
                {
                    sum += a;
                }
            }
            Console.WriteLine("Сумма: " + sum);
            return sum;
        }
        #endregion


        #region Show
        /// <summary>
        /// Отображение двумерного массива
        /// </summary>
        /// <param name="array2d"></param>
        static void Show2D(int[][] array2d)
        {
            Console.Write("{");
            foreach (int[] i in array2d)
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
        #endregion
    

        #region ArraySort
        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="mas"></param>
        public static void ArraySort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
        }
        #endregion   
    }

}

