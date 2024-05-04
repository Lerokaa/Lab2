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
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0.Вывести базу данных");
                Console.WriteLine("2.Создать аудиторию");
                int menu;
                while (!int.TryParse(Console.ReadLine(), out menu) || menu < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                switch (menu)
                {
                    case 0:
                        {
                            foreach (Classroom classroom in DB.Classrooms)
                                Printer.PrintClassroom(classroom);
                            break;
                        }
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            Creator.CreateClassroom();
                            break;
                        }
                }
            }
        }
    }
}
