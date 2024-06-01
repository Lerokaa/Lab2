using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("0.Вывести базу данных");
                Console.WriteLine("1.Создать занятие");
                Console.WriteLine("2.Создать аудиторию");
                Console.WriteLine("3.Создать сотрудника");
                int menu;
                while (!int.TryParse(Console.ReadLine(), out menu) || menu < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                switch (menu)
                {
                    case 0:
                        {
                            foreach (Classroom classroom in DB.Classrooms)
                                Printer.PrintClassroom(classroom);
                            foreach (Employee employee in DB.Employees)
                                Printer.PrintEmployee(employee);
                            break;
                        }
                    case 1:
                        {
                            Creator.CreateLesson();
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            Creator.CreateEmployee();
                        }
                }
            }
        }
    }
}
