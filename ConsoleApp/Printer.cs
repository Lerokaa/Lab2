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
            Console.WriteLine("Группа: {0}", group);
        }
        public static void PrintStudent(Student student)
        {
            Console.WriteLine("Фамилия: {0}", student.Firstname);
            Console.WriteLine("Имя: {0}", student.Lastname);
            Console.WriteLine("Отчество: {0}", student.Patronymic);
            PrintGroup(student.Group);
            Console.WriteLine("День рождения: {0}", student.BirthDate);
        }
    }
}
