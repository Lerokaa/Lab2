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
    public class Auditorium
    {
        private string name;
        private Employee Employee;
        private int seatingCapacity;
        private int windowCount;
        private Equipment Equipment;
        private DateTime creationDate;
        //Конструктор класса
        public Auditorium(string name, Employee Employee, int seatingCapacity, int windowCount, Equipment Equipment, DateTime? creationDate = null)
        {
            this.name = name;
            this.Employee = Employee;
            this.seatingCapacity = seatingCapacity;
            this.windowCount = windowCount;
            this.Equipment = Equipment;
            this.creationDate = creationDate DateTime.Now;
        }
        // Метод для добавления оборудования в список
        public void AddEquipment(string Equipment)
        {
            equipmentList.Add(Equipment);
        }
        
    }

}
