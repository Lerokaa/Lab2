using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class DB
    {
        public static List<Classroom> Classrooms = new List<Classroom>();
        public static List<Division> Division = new List<Division>();
        public static List<Pair> Pairs = new List<Pair>();
        public static List<Lesson> lessons = new List<Lesson>();

        public static List<Employee> Employees = new List<Employee>();

        public static List<Speciality> speciality = new List<Speciality>();

        public static List<Discipline> disciplines = new List<Discipline>();
    }
}
