using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Employee : User
    {
        private int _experience;
        private string _speciality;

        public Employee(int Expericence, string Speciality)
 
            
        {
            _experience = Expericence;
            _speciality = Speciality;
        }

        private int WorkExperience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;                
            }
        }
        public static void EmployeeShow()
        {
            UserShow();
            Console.WriteLine("Введите стаж (в годах): ");
            int Experience = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите должность: ");
            string Speciality = Console.ReadLine();
            Employee s = new Employee(Experience, Speciality);          
            Console.WriteLine("Ваша должность: {0} . Стаж (в годах): {1} ",s._speciality, s._experience);         
        }
    }
  
}
