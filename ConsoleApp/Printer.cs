using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Printer
    {
        public static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine(lesson.DateTime);
            PrintDiscipline(lesson.Discipline);
            PrintEmployee(lesson.Employee);
            PrintClassroom(lesson.Classroom);
            PrintGroup(lesson.Group);
            PrintPair(lesson.Pair);
            PrintTypeOfActivity(lesson.TypeOfActivity);
        }

        public static void PrintClassroom(Classroom classroom)
        {
            Console.WriteLine("Название аудитории: {0}", classroom.Name);
            PrintEmployee(classroom.Employee);
            Console.WriteLine("Количество мест: {0}", classroom.SeatingCapacity);
            Console.WriteLine("Количество окон: {0}", classroom.WindowCount);
            foreach (Equipment equipment in classroom.Equipments)
            {
                PrintEquipment(equipment);
            }
        }
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Ответственный сотрудник: {0}", employee);
        }
        public static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine("Оборудование: {0}", equipment);
        }
        public static void PrintPair(Pair pair)
        {
            Console.WriteLine("Время начала пары: {0}", pair.PairStart);
            Console.WriteLine("Время конца пары: {0}", pair.PairEnd);
            Console.WriteLine("Времы начала перерыва: {0}", pair.RestStart ?? "Перерыва нет");
            Console.WriteLine("Время конца перерыва: {0}", pair.RestEnd ?? "Перерыва нет");
            PrintWorkShift(pair.Shift);
        }
        public static void PrintSpeciality(Speciality speciality)
        {
            Console.WriteLine($"Название специальности:{speciality.SpecialityName}");
            Console.WriteLine($"Сокращенное название: {speciality.ReductionName}");

        }
        public static void PrintGroup(ClassLibrary.Group group)
        {
            Console.WriteLine("Группа: {0}", group);
        }
        public static void PrintTypeOfActivity(TypeOfActivity typeOfActivity)
        {
            Console.WriteLine("Тип активности: {0}", typeOfActivity);
        }
        public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine("Название дисциплины: {0}", discipline.Name);
            Console.WriteLine("Сокращенное название: {0}", discipline.ShortName);
        }
    }
}
