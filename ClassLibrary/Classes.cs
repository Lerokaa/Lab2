using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lesson
    {
        private DateTime date;
        private string disciplina;
        private string employeer;
        private string classroom;
        private string group;
        private string lesson;
        private string lessonType;

        public Lesson(DateTime Date, string Disciplina, string Employeer,
                  string Classroom, string Group, string Lesson,
                  string LessonType)
        {
            date = Date != default ? Date : DateTime.Now;
            disciplina = Disciplina;
            employeer = Employeer;
            classroom = Classroom;
            group = Group;
            lesson = Lesson;
            lessonType = LessonType;
        }
    }
    
    public class Classes
    {
       
    }
    public class Audience
    {

    }
    public class Subject
    {

    }
    public class Group
    {

    }
}
