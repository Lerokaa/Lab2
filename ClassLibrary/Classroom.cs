using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit
    /// </summary>
    public class Classroom
    {
        private readonly string name;
        private readonly Employee Employee;
        private readonly int seatingCapacity;
        private readonly int windowCount;
        private readonly List<string> equipmentList; //Нет 15 варианта, поэтому так
        private readonly DateTime creationDate;
        //Конструктор класса
        public Classroom(string name, Employee Employee, int seatingCapacity, int windowCount, List<string> equipmentList, DateTime? creationDate = null)
        {
            this.name = name;
            this.Employee = Employee;
            this.seatingCapacity = seatingCapacity;
            this.windowCount = windowCount;
            this.equipmentList = equipmentList;
            this.creationDate = creationDate ?? DateTime.Now;
        }

    }
}
