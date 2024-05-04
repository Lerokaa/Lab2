using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Creator
    {
        public static Classroom CreateClassroom()
        {
            Console.WriteLine("Введите название аудитории: ");
            string name = Console.ReadLine();
            
            Employee employee = CreateEmployee();
            Classroom classroom = DB.Classrooms.FirstOrDefault<Classroom>(cl => cl.Name == name);
            if(classroom == null) 
            {
                Console.WriteLine("Введите количество мест?");
                int seatingCapacity;
                while (!int.TryParse(Console.ReadLine(), out seatingCapacity) || seatingCapacity < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                Console.WriteLine("Введите количество окон?");
                int windowCount;
                while (!int.TryParse(Console.ReadLine(), out windowCount) || windowCount < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                Console.WriteLine("Введите количество оборудования:");
                int equipmentCount;
                while (!int.TryParse(Console.ReadLine(), out equipmentCount) || equipmentCount < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                List<Equipment> equipmentList = new List<Equipment>();
                for (int i = 0; i < equipmentCount; i++)
                {
                    Console.WriteLine("Создайте оборудование:");
                    equipmentList.Add(CreateEquipment());
                }
                Console.WriteLine("Введите ответственного сотрудника: ");
                
                classroom = new Classroom(name, employee, seatingCapacity, windowCount);
                foreach (Equipment equipment in equipmentList)
                {
                    classroom.Equipments.Add(equipment);
                }
                DB.Classrooms.Add(classroom);
                
            }
            return classroom;

        }

        public static Equipment CreateEquipment()
        {
            return null;
        }
        public static Employee CreateEmployee()
        {
            return null;
        }
    }
}
