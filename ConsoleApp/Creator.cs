using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Creator
    {
        public static Lesson CreateLesson()
        {
            // Все ссылки для создания вашего класса должны быть получены
            // при помощи чужих методов (заглушек или реализованых методов)
            Discipline discipline = CreateDiscipline();
            Employee employee = CreateEmployee();
            Classroom classroom = CreateClassroom();
            Pair pair = CreatePair();
            ClassLibrary.Group group = CreateGroup();
            TypeOfActivity typeOfActivity = CreateTypeOfActivity();


            //Вы должны оганизовать получение ключевых данных от пользователя
            // для поиска существующей сущности в БД
            Console.WriteLine("Введите начало пары (в формате чч:мм):");
            string pairStart = Console.ReadLine();

            while (!ValidateTimeFormat(pairStart))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairStart = Console.ReadLine();
            }

            Console.WriteLine("Введите конец пары (в формате чч:мм):");
            string pairEnd = Console.ReadLine();

            while (!ValidateTimeFormat(pairEnd))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairEnd = Console.ReadLine();
            }

            // После сбора ключевых данных вы обращаетесь в БД ища существующий обект
            Lesson lesson = DB.lessons.FirstOrDefault(l => discipline == l.Discipline && employee == l.Employee && classroom == l.Classroom && pair == l.Pair && group == l.Group && typeOfActivity == l.TypeOfActivity);
            
            // Если этого обекта нет в БД, вы должны его создать
            if (lesson == null)
            {
                Console.WriteLine("Введите дату:");
                string date = Console.ReadLine();
                lesson = new Lesson(DateTime.Parse(date), discipline, employee, classroom, group, pair, typeOfActivity);
                DB.lessons.Add(lesson);
                Console.WriteLine("Занятие успешно создано.");
            }

            return lesson;
        }

        private static TypeOfActivity CreateTypeOfActivity()
        {
            return null;
        }

        private static ClassLibrary.Group CreateGroup()
        {
            return null;
        }

        private static Pair CreatePair()
        {
            return null;
        }

        private static Classroom CreateClassroom()
        {
            return null;
        }

        private static Employee CreateEmployee()
        {
            Console.WriteLine("Введите фамилию сотрудника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            string firstName = Console.ReadLine();


            Console.WriteLine("Введите отчество сотрудника:");

            string patronypicName = Console.ReadLine();

            return new Employee(lastName, firstName, patronypicName, CreateSpeciality());
        }

        public static Discipline CreateDiscipline()
        {
            Console.WriteLine("Введите название дисциплины");
            string name = Console.ReadLine();
            Discipline discipline = DB.disciplines.FirstOrDefault(d => d.Name == name);
            if (discipline == null)
            {
                Console.WriteLine("Введите сокращение: ");
                string shortname = Console.ReadLine();

                discipline = new Discipline(name, shortname);
                DB.disciplines.Add(discipline);
            }
            return discipline;
        }



        private static bool ValidateTimeFormat(string time)
        {
            string pattern = @"^(2[0-3]|[01][0-9]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
        }
    }
}
