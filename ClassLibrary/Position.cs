using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Position
    {
        // Закрытые поля
        private string title;
        private decimal salary;
        private string department;

        // Конструктор
        public Position(string title, decimal salary, string department)
        {
            Title = title;
            Salary = salary;
            Department = department;
        }

        // Методы доступа
        public string GetTitle()
        {
            return Title;
        }

        public decimal GetSalary()
        {
            return Salary;
        }

        public string GetDepartment()
        {
            return Department;
        }
    }

}
