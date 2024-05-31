using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        private readonly string lastname;
        private readonly string firstname;
        private readonly string patronymic;
        private readonly string group;
        private readonly DateTime birthDate;
        //Конструктор класса
        public Student(string lastname, string firstname, string patronymic, string group, DateTime birthDate)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.patronymic = patronymic;
            this.group = group;
            this.birthDate = birthDate;

        }

        public string lastname { get { return lastname; } }
        public string firstname { get { return firstname; } }
        public string patronymic { get { return patronymic; } }
        public string group { get { return group; } }
        public DateTime birthDate { get { return birthDate; } }

    }
    
}
