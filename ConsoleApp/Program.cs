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
            ConsoleKeyInfo K = new ConsoleKeyInfo();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1.Заполнить список случайными значениями");
                    Console.WriteLine("2.Добавить элемент в начало списка");
                    Console.WriteLine("3.Добавить элемент в конец списка");
                    Console.WriteLine("4.Поиск элемента по значению");
                    Console.WriteLine("5.Поиск элемента по номеру");
                    Console.WriteLine("6.Добавить элемент перед заданным");
                    Console.WriteLine("7.Добавить элемент после заданного");
                    Console.WriteLine("8.Удалить элемент из конца списка");
                    Console.WriteLine("9.Удалить элемент из начала списка");
                    Console.WriteLine("0.Удалить элемент перед заданным");
                    Console.WriteLine("f1.Удалить элемент после заданного");
                    Console.WriteLine("f2.Задание 20: Удалить элементы списка, имеющие равных соседей");
                    Console.WriteLine("f3.Задание 30: Добавить в конец списка L1 и все элементы списка L2");
                    Console.WriteLine("f4.Вывод списка на экран в прямом порядке");
                    Console.WriteLine("f5.Вывод списка на экран в обратном порядке");
                    Console.WriteLine("Esc. Выход из программы");
                    Console.WriteLine("");
                    K = Console.ReadKey();
                    switch (K.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            {
                                Lesson lesson = Creator.CeateLesson();
                                Printer.PrintLesson(lesson);
                                break;
                            }
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D6:
                        case ConsoleKey.NumPad6:
                            {
                               
                                break;
                            }
                        case ConsoleKey.D7:
                        case ConsoleKey.NumPad7:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D8:
                        case ConsoleKey.NumPad8:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D9:
                        case ConsoleKey.NumPad9:
                            {
                                
                                break;
                            }
                        case ConsoleKey.D0:
                        case ConsoleKey.NumPad0:
                            {
                                
                                break;
                            }
                        case ConsoleKey.F1:
                            {
                                
                                break;
                            }
                        case ConsoleKey.F2:
                            {
                                
                                break;
                            }
                        case ConsoleKey.F3:
                            {
                               
                                break;
                            }
                        case ConsoleKey.F4:
                            {
                                
                                break;
                            }
                        case ConsoleKey.F5:
                            {
                               
                                break;
                            }
                        default: break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                System.Threading.Thread.Sleep(3000);
            }
            while (K.Key != ConsoleKey.Escape);
        }
    }
}
