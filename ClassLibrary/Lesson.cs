using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Lesson
    {
        private DateTime datetime;
        private Discipline discipline;
        private Employee employee;
        private Classroom classroom;
        private Group group;
        private Pair pair;

        public Lesson(DateTime datetime, Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair)
        {
            this.datetime = datetime;
            this.discipline = discipline;
            this.employee = employee;
            this.classroom = classroom;
            this.group = group;
            this.pair = pair;
        }
    }
}
