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
            Triangle();
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nВведите количество строк для равнобедренного треугольника: ");
            AnotherTriangle();
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nВведите количество треугольников для новогодней елки: ");
            Xmas();
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nСумма кратных чисел для 3,5 и меньше 1000: ");
            NaturalSum();
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
            Array2();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Срежняя длина слова в предложении: ");
            AverageString();
            Console.WriteLine("------------------------------");

            Console.WriteLine("Удваивает символы в 1й строке из 2й строки: ");
            CharDoubler();
            Console.WriteLine("------------------------------");

            Console.ReadKey();
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

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Ошибка, число отрицательно или равно нулю.");
            }
            else
            {
                Console.WriteLine("Площадь: " + a * b);
            }

        }
        #endregion


        #region FirstTriangle
        /// <summary>
        /// Прямоугольный треугольник
        /// </summary>
        /// <param name="StrNumber"></param>
        /// <returns></returns>
        static string Triangle()
        {
            string StrNumber = Console.ReadLine();

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
        static string AnotherTriangle()
        {
            string StrNumber1 = Console.ReadLine();
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
        static string Xmas()
        {
            string StrNumber2 = Console.ReadLine();
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
            result2 += 1;
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
            Console.WriteLine(sum);
            return sum;      
        }


        #endregion


        #region Font Adjustment


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


        #region 2Darray
        /// <summary>
        /// Сумма элементов  стоящих на четной позиции массива
        /// </summary>
        static void Array2()
        {
            int[,] array2d = new int[3,3];
            int massiv2sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2d[i,j] = rnd.Next(0, 20);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Позиция: [" + i + "," + j + "]  Значение: " + array2d[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        massiv2sum += array2d[i, j];
                    }
                }
            }
            Console.WriteLine("\nСумма элементов : " + massiv2sum);

            Console.WriteLine();
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


        #region AverageString
        /// <summary>
        /// Средняя длина слова
        /// </summary>
        static void AverageString()
        {
            Console.WriteLine("Введите строку: ");
            var a = Console.ReadLine().ToCharArray();
            var letters = 0;
            var words = 1;
            if (a.Length ==0)
            {
                Console.WriteLine("Вы ввели пустую строку!");
            }

            for (var i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                    letters++;
                if (i > 0 && char.IsLetter(a[i - 1]) && !char.IsLetter(a[i]))
                    words++;
            }

            Console.WriteLine("Средняя длина слова:" + (((float)letters)/words));

        }
        #endregion


        #region CharDoubler
        /// <summary>
        /// Удваивает символы в первой строке, если они встречаются во введенной второй строке.
        /// </summary>
        /// <returns></returns>
        static StringBuilder CharDoubler()
        {
            
            Console.WriteLine("Поочередно введите первую и вторую строку: ");
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < a.Length; i++)
            {
                if (b.Contains(a[i]))
                {
                    str.Append(a[i]);
                }
                str.Append(a[i]);
            }
           

            Console.WriteLine(str);
            return str;
        }
        #endregion
    }

}

