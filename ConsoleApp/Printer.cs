using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

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
            Console.WriteLine("Ответственный сотрудник: {0}", employee);
        }
        public static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine("Оборудование: {0}", equipment);
        }


        public static void PrintGroup(Group group)
        {
            Console.WriteLine("Название группы: {0}", group.Name);
            Console.WriteLine("Сокращение: {0}", group.ShortName) ;
            Console.WriteLine("Численность: {0}", group.Population);
            Console.WriteLine("Год поступления: {0}", group.YearOfAdmission);
            PrintEmployee(group.Employee);
            PrintSpeciality(group.Speciality);
        }
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Ответственный сотрудник: {0}", employee);
        }
        public static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine("Оборудование: {0}", equipment);
        }
        public static void PrintSpeciality(Speciality speciality)
        {
            Console.WriteLine(" Специальность: {0}", speciality);
        }
    }
}
