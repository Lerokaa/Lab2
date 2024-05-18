using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lesson
    {
        private readonly DateTime datetime;
        private readonly Discipline discipline;
        private readonly Employee employee;
        private readonly Classroom classroom;
        private readonly Group group;
        private readonly Pair pair;
        private readonly TypeOfActivity typeOfActivity;

        public Lesson(DateTime datetime, Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair, TypeOfActivity typeOfActivity)
        {
            this.datetime = datetime;
            this.discipline = discipline;
            this.employee = employee;
            this.classroom = classroom;
            this.group = group;
            this.pair = pair;
            this.typeOfActivity = typeOfActivity;
        }

        public DateTime DateTime { get { return datetime; } }
        public Discipline Discipline { get {  return discipline; } }
        public Employee Employee { get { return employee; } }
        public Classroom Classroom { get {  return classroom; } }
        public Group Group { get { return group; } }
        public Pair Pair { get { return pair; } }
        public TypeOfActivity TypeOfActivity { get { return typeOfActivity; } }
    }
   
}
