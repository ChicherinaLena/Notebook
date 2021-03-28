using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Notebook
{
    class Program
    {
        public static List<Appointment> appointments = new List<Appointment>();

        static void Main()
        {
            Console.WriteLine(
                "\n\rВведите номер операции. \n\r1 - Добавление новой записи. \n\r2 - Редактирование текущих записей. \n\r3 - Удаление записи. \n\r4 - Просмотр всех записей. \n\r5 - Просмотр кратких записей.");
            Console.WriteLine("\n\r");
            switch (Console.ReadLine().ToString())
            {
                case "1":
                    Appointment.NewAppointment();
                    Main();

                    break;
                case "2":
                    Appointment.RedactAppointment();
                    Main();
                    break;
                case "3":
                    Appointment.DeleteAppointment();
                    Main();
                    break;
                case "4":
                    View.FullView();
                    Main();
                    break;
                case "5":
                    View.ShortView();
                    Main();
                    break;
                default:
                    Console.WriteLine("\n\rВероятно, вы ошиблись.");
                    Main();
                    break;

            }
        }
    }
}
        
    

