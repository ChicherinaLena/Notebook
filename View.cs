using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class View
    {
        public static void OneView(int id)
        {
            Console.WriteLine("\n\r");
            Console.WriteLine("{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15} |{6,15} |{7,15} |{8,15}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Страна", "Дата рождения", "Организация", "Должность");

            var item = Program.appointments[id - 1];
            Console.WriteLine("{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15} |{6,15} |{7,15} |{8,15}", item.id, item.surname, item.name, item.lastname, item.phone, item.country, item.dateOfBirth, item.organization, item.status);
            Console.WriteLine("\n\r");

        }
        public static void FullView()
        {
            Console.WriteLine("\n\r");
            Console.WriteLine("{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15} |{6,15} |{7,15} |{8,15}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Страна", "Дата рождения", "Организация", "Должность");

            foreach (Appointment item in Program.appointments)
            {
                Console.WriteLine("{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15} |{6,15} |{7,15} |{8,15}", item.id, item.surname, item.name, item.lastname, item.phone, item.country, item.dateOfBirth, item.organization, item.status);

            }
            Console.WriteLine("\n\r");
        }
        public static void ShortView()
        {
            Console.WriteLine("\n\r");
            Console.WriteLine("{0,5} |{1,10} |{2,10} |{3,15}", "ID", "Фамилия", "Имя", "Телефон");
            foreach (Appointment item in Program.appointments)
            {
                Console.WriteLine("{0,5} |{1,10} |{2,10} |{3,15}", item.id, item.surname, item.name, item.phone);

            }
            Console.WriteLine("\n\r");
        }
    }
}

    

