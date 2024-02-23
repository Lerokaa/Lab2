using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant2_lib
{
    /// <summary>
    /// Класс аудитория, принимающий следующие значения: название, ссылка на ответственного сотрудника, количество посадочных мест,количество окон, список ссылок на Оборудование
    /// </summary>
    public class Auditorium
    {
        private string name;
        private string responsibleEmployee;
        private int seatingCapacity;
        private int windowCount;
        private List<string> equipmentList;
        private DateTime creationDate;


        //Конструктор класса
        public Auditorium(string name, string responsibleEmployee, int seatingCapacity, int windowCount, List<string> equipmentList, DateTime? creationDate = null)
        {
            this.name = name;
            this.responsibleEmployee = responsibleEmployee;
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
        //https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit

    }
}
