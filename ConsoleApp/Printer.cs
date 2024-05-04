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
            Console.WriteLine(employee);
        }
        public static void PrintEquipment(Equipment equipment)
        {
            Console.WriteLine(equipment);
        }
    }
}
