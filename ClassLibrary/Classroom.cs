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
        private string name;
        private Employee Employee;
        private int seatingCapacity;
        private int windowCount;
        private List<string> equipmentList; //Нет 15 варианта, поэтому так
        private DateTime creationDate;
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
        // Метод для добавления оборудования в список
        public void AddEquipment(string equipment)
        {
            equipmentList.Add(equipment);
        }

    }
}
