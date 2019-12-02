using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class MyString
    {

        private char[] str;

        public MyString(string first)
        {
            str = first.ToCharArray();
        }

        public char this[int index]
        {
            get
            {
                return str[index];
            }
            set
            {
                str[index] = value;
            }
        }

        public char[] ArrayConvert(string first)
        {
            char[] symbols = new char[first.Length];
            for (int i = 0; i < symbols.Length - 1; i++)
            {
                symbols[i] = first[i];
            }
            return symbols;
        }

        public string StringConvert(char[] str)
        {
            string str1 = " ";
            for (int i = 0; i < str1.Length - 1; i++)
            {
                str1 += str1[i];
            }
            return str1;
        }

        public string Concatenate(string first, string second)
        {
            return first + second;
        }

        public bool Equals(string first, string second)
        {
            if (first.Length != second.Length)
                return false;
            for (int i = 0; i < first.Length; i++)
                if (first[i] != second[i])
                    return false;
            return true;
        }

        public int GetIndexOfChar(char ch)
        {
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    index = i;
                    break;
                }
                else
                {
                    Console.WriteLine("Такого символа не существует в строке.");
                }
            }
            return index;
        }

        public static void StringShow()
        {
            Console.WriteLine("Введите первую строку:");
            string first = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string second = Console.ReadLine();
            Console.WriteLine("Введите один символ для поиска его номера индекса в строке");
            char ch = Convert.ToChar(Console.ReadLine());

            MyString show = new MyString(first);
            Console.WriteLine("Объединение двух строк: " + show.Concatenate(first, second));
            Console.WriteLine("Сравнение двух строк: " + show.Equals(first, second));
            Console.WriteLine("Номер индека символа '" + ch + "' : " + show.GetIndexOfChar(ch));
            
        }
    }
}

        


    
