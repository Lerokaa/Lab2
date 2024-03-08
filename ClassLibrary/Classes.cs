using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
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
        private string name;
        private string shortname;
        private int population;
        private int yearOfadmission;
        private Specialization specialization; //ссылка на специальность
        private Employee employee;             //классный руководитель, ссылка на сотрудника

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ShortName
        {
            get { return shortname; }
            set { shortname = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        public int YearOfAdmission
        {
            get { return yearOfadmission; }
            set { yearOfadmission = value};
        }
        public Employee EEmployee
        {
            get { return employee; }
            set {  employee = value; }
        }
        public Specialization SSpecialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public Group(string name, string shortname, int population, int yearOfadmission, Employee EmpLink, Specialization SpecLink)
        {
            this.Name = name;
            this.ShortName = shortname;
            this.Population = population;
            this.YearOfAdmission = yearOfadmission;
            this.EEmployee = EmpLink;
            this.SSpecialization = SpecLink;
        }
    }
}
