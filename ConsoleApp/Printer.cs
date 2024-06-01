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
            Console.WriteLine("Фамилия: {0}", employee.LastName);
            Console.WriteLine("Имя: {0}", employee.FirstName);
            Console.WriteLine("Отчество: {0}", employee.PatronymicName);
            PrintSpeciality(employee.Speciality);
        }
        public static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine("Оборудование: {0}", equipment);
        }

        public static void PrintSpeciality(Speciality speciality)
        {
            Console.WriteLine($"Название специальности:{speciality.SpecialityName}");
            Console.WriteLine($"Сокращенное название: {speciality.ReductionName}");
        }
        public static void PrintDivision(Division division)

        {
            Console.WriteLine("Название подразделения: {0}", division.Name);
            PrintHead(division.Head);
            PrintOrganization(division.Organization);
        }
        public static void PrintHead(Employee head)
        {
            Console.WriteLine("Руководитель: {0}", head);
        }
        public static void PrintOrganization(Organization organization)
        {
            Console.WriteLine("Организация: {0}", organization);

        }
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
        public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine("Название дисциплины: {0}", discipline.Name);
            Console.WriteLine("Сокращенное название: {0}", discipline.ShortName);
        }
        public static void PrintGroup(ClassLibrary.Group group)
        {
            Console.WriteLine("Группа: {0}", group);
        }
        public static void PrintPair(Pair pair)
        {
            Console.WriteLine("Время начала пары: {0}", pair.PairStart.ToString());
            Console.WriteLine("Время конца пары: {0}", pair.PairEnd.ToString());
            Console.WriteLine("Времы начала перерыва: {0}", pair.RestStart.ToString() ?? "Перерыва нет");
            Console.WriteLine("Время конца перерыва: {0}", pair.RestEnd.ToString() ?? "Перерыва нет");
            PrintWorkShift(pair.WorkShift);
        }
        public static void PrintWorkShift(WorkShift workShift)
        {
            Console.WriteLine("Название смены: {0}", workShift.Name);
            Console.WriteLine("Дата смены: {0}", workShift.Date);
        }
        public static void PrintTypeOfActivity(TypeOfActivity typeOfActivity)
        {
            Console.WriteLine("Тип активности: {0}", typeOfActivity);
        }

        public static void PrintPosition(Position position)
        {
            Console.WriteLine("Должность: {0}", position.Title);
            Console.WriteLine("Оклад: {0}", position.Salary);
            PrintDivision(position.Division);
        }


        
        public static void PrintWorkShift(WorkShift workShift)
        {
            Console.WriteLine("jfkflf: {0}", workShift);
        }


    }
}
