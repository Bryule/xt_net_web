using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class User
    {
        private string _name;
        private string _surname;
        private string _fathername;
        private DateTime _birthday;
        private int _age;

        public string UserName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string UserSurName
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public string UserFatherName
        {
            get
            {
                return _fathername;
            }
            set
            {
                _fathername = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                    _age = value;
                else
                    Console.WriteLine("Некорректный ввод, возраст не может быть отрицательным!");
            }
        }
        public DateTime UserBirthDay
        {
            get
            {
                return _birthday;
            }
            set
            {
                _birthday = value;
            }
        }

        public void User1(string _name, string _surname, string _fathername, int _age, DateTime _birthday)
        {
            UserName = _name;
            UserSurName = _surname;
            UserFatherName = _fathername;
            Age = _age;
            UserBirthDay = _birthday;
        }

        public static void UserShow()
        {
            User first = new User();
            first.UserSurName = "Иванов";
            first.UserName = "Иван";
            first.UserFatherName = "Иванович";
            first.Age = 38;
            first.UserBirthDay = new DateTime(1992,02,2, 8,52,00);
            Console.WriteLine("Пользователь. Фамилия: {0}, Имя: {1}, Отчество: {2}\nДата рождения: {3}" +
                "\nВозраст: {4}", first.UserSurName, first.UserName, first.UserFatherName, first.UserBirthDay, first.Age);
            Console.WriteLine("");

            Console.WriteLine("Введите нового пользователя по примеру выше.");
            User second = new User();
            Console.WriteLine("Имя: ");
            second.UserSurName = Console.ReadLine();
            Console.WriteLine("Фамилия: ");
            second.UserName = Console.ReadLine();
            Console.WriteLine("Отчество: ");
            second.UserFatherName = Console.ReadLine();
            Console.WriteLine("Дата рождения: ");
            second.UserBirthDay = Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Today;
            second.Age = now.Year - second.UserBirthDay.Year;
            if (second.UserBirthDay > now.AddYears(second.Age)) second.Age--;
            Console.WriteLine("Пользователь. Фамилия: {0}, Имя: {1}, Отчество: {2}\nДата рождения: {3}" +
                "\nВозраст: {4}", second.UserSurName, second.UserName, second.UserFatherName, second.UserBirthDay, second.Age);
        }
    }
}




