using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Printer
    {
        public static void PrintLesson(Lesson lesson)
        {
            PrintDiscipline(lesson.Discipline);
        }

        public static void PrintDiscipline(Discipline discipline)
        {

        }
    }
}
