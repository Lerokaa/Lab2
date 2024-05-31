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
            Console.WriteLine("Введите дату (в формате гггг-мм-дд):");
            string dateInput = Console.ReadLine();
            DateTime date;
            while (!DateTime.TryParse(dateInput, out date))
            {
                Console.WriteLine("Неверный формат даты. Повторите ввод (в формате гггг-мм-дд):");
                dateInput = Console.ReadLine();
            }

            if (lesson == null)
            {
                lesson = new Lesson(date, discipline, employee, classroom, group, pair, typeOfActivity);
                DB.lessons.Add(lesson);
                // Здесь вызовите метод для сохранения изменений в базе данных, если он есть
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
            return null;
        }

        private static Discipline CreateDiscipline()
        {
            return null;
        }
        public static Student CreateStudent()
        {
            Lastname lastname = CreateLastname();
            Firstname firstname = CreateFirstname();
            Patronymic patronymic = CreatePatronymic();
            ClassLibrary.Group group = CreateGroup();
            DateTime.birthDate birthdate = CreateBirthdate();


        }
        



        private static bool ValidateTimeFormat(string time)
        {
            string pattern = @"^(2[0-3]|[01][0-9]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
        }
    }
}
