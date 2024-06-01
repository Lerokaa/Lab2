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
        private readonly Group group;
        private readonly DateTime birthDate;
        //Конструктор класса
        public Student(string lastname, string firstname, string patronymic, Group group, DateTime birthDate)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.patronymic = patronymic;
            this.group = group;
            this.birthDate = birthDate;

        }

        public string Lastname { get { return lastname; } }
        public string Firstname { get { return firstname; } }
        public string Patronymic { get { return patronymic; } }
        public Group Group { get { return group; } }
        public DateTime BirthDate { get { return birthDate; } }

    }
    
}
