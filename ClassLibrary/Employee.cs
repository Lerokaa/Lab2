using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// ����� ���������
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// �������
        /// </summary>
        private string lastName;
        public string LastName
        { get { return lastName; } set { lastName = value; } }
        /// <summary>
        /// ���
        /// </summary>
        private string firstName;
        public string FirstName
        { get { return firstName; } set { firstName = value; } }
        /// <summary>
        /// ��������
        /// </summary>
        private string patronymicName;
        public string PatronymicName
        { get { return patronymicName; } set { patronymicName = value; } }
        /// <summary>
        /// ������ �� ���������
        /// </summary>
        private Speciality speciality;
        public Speciality Speciality
        { get { return speciality; } set { speciality = value; } }

        /// <summary>
        /// ����������� ����������� ��������� ��������� 
        /// (��� ��������� ������ ���� �������� � ����, ���� ���� �� ������, 
        /// �� ������� ������� ����)
        /// </summary>
        /// <param name="lastName">�������</param>
        /// <param name="firstName">���</param>
        /// <param name="patronymicName">��������</param>
        /// <param name="speciality">������ �� ���������</param>
        public Employee(string lastName, string firstName, string patronymicName, Speciality speciality)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymicName = patronymicName;
            this.speciality = speciality;
        }
    }
}