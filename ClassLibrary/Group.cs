using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    /// <summary>
    /// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit
    /// </summary>

    public class Group
    {
        private string name;
        private string shortname;
        private int population;
        private int yearOfadmission;
        private Speciality speciality;
        private Employee classroomteacher;
        /// <summary>
        /// название
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// сокращение
        /// </summary>
        public string ShortName
        {
            get { return shortname; }
            set { shortname = value; }
        }
        /// <summary>
        /// численность
        /// </summary>
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        /// <summary>
        /// год поступления
        /// </summary>
        public int YearOfAdmission
        {
            get { return yearOfadmission; }
            set { yearOfadmission = value; }
        }
        /// <summary>
        /// классный руководитель
        /// </summary>
        public Employee ClassroomTeacher
        {
            get { return classroomteacher; }
            set { classroomteacher = value; }
        }
        /// <summary>
        /// ссылка на специальность
        /// </summary>
        public Speciality Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }
        public Group(string name, string shortname, int population, int yearOfadmission, Employee EmpLink, Speciality SpecLink)
        {
            this.Name = name;
            this.ShortName = shortname;
            this.Population = population;
            this.YearOfAdmission = yearOfadmission;
            this.ClassroomTeacher = EmpLink;
            this.Speciality = SpecLink;
        }
    }
}
