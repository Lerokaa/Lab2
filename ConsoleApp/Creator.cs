using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            TimeSpan pairstart;
            Console.Write("Введите время начала пары: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), pairstart)) 
            {
                Console.Write("Неправильный формат! Введите время начала пары: ");
            }

            TimeSpan pairend;
            Console.Write("Введите время конца пары: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), pairend))
            {
                Console.Write("Неправильный формат! Введите время конца пары: ");
            }

            TimeSpan reststart = null;
            Console.Write("Введите время начала перерыва (ничего не вводите, если перерыва нет): ");
            string _reststart = Console.ReadLine();
            while (_reststart != "" && (!TimeSpan.TryParse(_reststart, reststart) || reststart < pairstart || reststart > pairend))
            {
                Console.Write("Неправильно! Введите время начала перерыва (ничего не вводите, если перерыва нет): ");
                _reststart = Console.ReadLine();
            }

            TimeSpan restend = null;
            if (_reststart != "")
            {
                Console.Write("Введите время конца перерыва: ");
                while (!TimeSpan.TryParse(Console.ReadLine(), restend) || restend < reststart || restend > pairend)
                {
                    Console.Write("Неправильно! Введите время конца перерыва: ");
                }
            }

            Console.WriteLine("Введите смену: ");
            WorkShift shift = CreateWorkShift();

            Pair pair = new Pair(pairstart, pairend, reststart, restend, shift);

            DB.Pairs.Add(pair);

            return pair;
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



        private static bool ValidateTimeFormat(string time)
        {
            string pattern = @"^(2[0-3]|[01][0-9]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
        }
    }
}
