using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class Appointment
    {
        public static int count = 0;
        public int id;
        public string surname;
        public string name;
        public string lastname;
        public int phone;
        public string country;
        public string dateOfBirth;
        public string organization;
        public string status;
        



        public Appointment(int id, string surname, string name, string lastname, int phone, string country, string dateOfBirth, string organization, string status)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.country = country;
            this.dateOfBirth = dateOfBirth;
            this.organization = organization;
            this.status = status;
            
        }

        public static void NewAppointment()
        {
            Console.WriteLine("\n\rДобавление новой записи:\n\r ");
            Console.WriteLine("Фамилия: ");
            string surname = Console.ReadLine();
            while (String.IsNullOrEmpty(surname))
            {
                Console.WriteLine("Данное поле обязательное. Введите фамилию: ");
                surname = Console.ReadLine();
            }

            Console.WriteLine("Имя: ");
            string name = Console.ReadLine();
            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Данное поле обязательное. Введите имя: ");
                name = Console.ReadLine();
            }


            Console.WriteLine("Отчество (поле не является обязательным): ");
            string lastname = Console.ReadLine().ToString();
            lastname = (String.IsNullOrEmpty(lastname)) ? "-" : lastname;

            Console.WriteLine("Телефон: ");
            string sphone = Console.ReadLine();

            while (!int.TryParse(sphone, out int n))
            {
                Console.WriteLine("Некорректный формат. Введите телефон: ");
                sphone = Console.ReadLine();
            }
            int phone = Convert.ToInt32(sphone);

            Console.WriteLine("Страна: ");
            string country = Console.ReadLine();
            while (String.IsNullOrEmpty(country))
            {
                Console.WriteLine("\n\rДанное поле обязательное. Введите страну: ");
                country = Console.ReadLine();
            }

            Console.WriteLine("Дата рождения (поле не является обязательным): ");
            string dateOfBirth = Console.ReadLine().ToString();
            dateOfBirth = (String.IsNullOrEmpty(dateOfBirth)) ? "-" : dateOfBirth;

            Console.WriteLine("Организация (поле не является обязательным): ");
            string organization = Console.ReadLine().ToString();
            organization = (String.IsNullOrEmpty(organization)) ? "-" : organization;

            Console.WriteLine("Должность (поле не является обязательным): ");
            string status = Console.ReadLine().ToString();
            status = (String.IsNullOrEmpty(status)) ? "-" : status;



            count++;

            Appointment app = new Appointment(count, surname, name, lastname, phone, country, dateOfBirth, organization, status);
            Program.appointments.Add(app);
        }
        public static void RedactAppointment()
        {
            Console.WriteLine("\n\rВведите id записи: ");
            int localid = Convert.ToInt32(Console.ReadLine());
            View.OneView(localid);
            Console.WriteLine("Что вы хотите изменить? \n\r1- Фамилия. \n\r2 -  Имя. \n\r3 -  Отчество. \n\r4 - Телефон. \n\r5 - Страна. \n\r6 - Дата рождения. \n\r7 - Организация. \n\r8- Должность.");
            string whatredact = Console.ReadLine();
            Console.WriteLine("Введите новое значение: ");
            string redactitem = Console.ReadLine();
            var item = Program.appointments[localid - 1];
            switch (whatredact)
            {
                case "1":
                    item.surname = redactitem;

                    break;
                case "2":
                    item.name = redactitem;
                    break;
                case "3":
                    item.lastname = redactitem;
                    break;
                case "4":
                    while (!int.TryParse(redactitem, out int n))
                    {
                        Console.WriteLine("\n\rНомер телефона только цифрами: ");
                        redactitem = Console.ReadLine();
                    }
                    item.phone = Convert.ToInt32(redactitem);

                    break;
                case "5":
                    item.country = redactitem;
                    break;
                case "6":
                    item.dateOfBirth = redactitem;
                    break;
                case "7":
                    item.organization = redactitem;
                    break;
                case "8":
                    item.status = redactitem;
                    break;
                
                default:
                    Console.WriteLine("\n\rВведите цифру от 1 до 8. ");
                    break;


            }


        }

        public static void DeleteAppointment()
        {
            Console.WriteLine("\n\rВведите id записи: ");
            int localid = Convert.ToInt32(Console.ReadLine());
            Program.appointments.RemoveAt(localid - 1);
        }
    }
}

    

