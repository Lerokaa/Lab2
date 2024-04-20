using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Класс сотрудник
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        private string lastName;
        public string LastName
        { get { return lastName; } set { lastName = value; } }
        /// <summary>
        /// Имя
        /// </summary>
        private string firstName;
        public string FirstName
        { get { return firstName; } set { firstName = value; } }
        /// <summary>
        /// Отчество
        /// </summary>
        private string patronymicName;
        public string PatronymicName
        { get { return patronymicName; } set { patronymicName = value; } }
        /// <summary>
        /// Ссылка на должность
        /// </summary>
        private Speciality speciality;
        public Speciality Speciality
        { get { return speciality; } set { speciality = value; } }

        /// <summary>
        /// Конструктор принимающий следующие аргументы 
        /// (все аргументы должны быть записаны в поля, если дата не задана, 
        /// то берется текущая дата)
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymicName">Отчество</param>
        /// <param name="speciality">Ссылка на должность</param>
        public Employee(string lastName, string firstName, string patronymicName, Speciality speciality)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymicName = patronymicName;
            this.speciality = speciality;
        }
    }
}
