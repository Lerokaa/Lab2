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
                Console.WriteLine("3.Создать дисциплину");
                Console.WriteLine("9.Создать сотрудника")
                Console.WriteLine("10.Создать должность");
                int menu;
                while (!int.TryParse(Console.ReadLine(), out menu) || menu < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                switch (menu)
                {
                    case 0:
                        {
                            foreach (Classroom classroom in DB.Classrooms)
                                Printer.PrintClassroom(classroom);

                            foreach (Lesson lesson in DB.lessons)
                                Printer.PrintLesson(lesson);

                            foreach (Discipline discipline in DB.disciplines)
                                Printer.PrintDiscipline(discipline);

                            foreach (Position position in DB.Position)
                                Printer.PrintPosition(position);

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
                            Creator.CreateDiscipline();
                            break;
                        }
                    case 9:
                        {
                            Creator.CreateEmployee();
                            break;
                        }
                    case 10:
                        {
                            Creator.CreatePosition();
                            break;
                        }
                }
            }
        }
    }
}
