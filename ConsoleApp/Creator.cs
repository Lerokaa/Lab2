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
                Employee employee = CreateEmployee();

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
        public static Speciality CreateSpecialit()
        {
            return null;
        }

        public static Group CreateGroup()
        {
            Console.WriteLine("Введите название группы: ");
            string name = Console.ReadLine();
            Group group = DB.Groups.FirstOrDefault<Group>(gr => gr.Name == name);
            if (group == null)
            {
                Console.WriteLine("Введите сокращение: ");
                string shortname = Console.ReadLine();

                Console.WriteLine("Введите численность: ");
                int population;
                while (!int.TryParse(Console.ReadLine(), out population) || population < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");

                Console.WriteLine("Введите год поступленя:");
                int yearOfadmission;
                while (!int.TryParse(Console.ReadLine(), out yearOfadmission) || yearOfadmission < 1900 || yearOfadmission > 2025)
                    Console.WriteLine("Нужно ввести год");

                Console.WriteLine("Введите спецаильность: ");
                Speciality speciality = CreateSpeciality();

                Console.WriteLine("Введите классного руководителя: ");
                Employee classroomteacher = CreateEmployee();


                group = new Group(name, shortname, population, yearOfadmission, speciality, classroomteacher);
                DB.Groups.Add(group);

            }
            return group;

        }
    }
}
