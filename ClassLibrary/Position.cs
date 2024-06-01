using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    ///https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit 
    /// <summary>
    public class Position
    {
        // Закрытые поля
        private readonly string title;
        private readonly decimal salary;
        private readonly Division division;

        // Конструктор
        public Position(string title, decimal salary, Division division)
        {
            this.title = title;
            this.salary = salary;
            this.division = division;
        }

        // Методы доступа

        public string Title { get { return title; } }
        public decimal Salary { get { return salary; } }
        public Division Division { get { return division; } }
    }
}