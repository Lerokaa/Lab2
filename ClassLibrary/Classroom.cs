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
        private readonly Employee employee;
        private readonly int seatingCapacity;
        private readonly int windowCount;
        private readonly List<Equipment> equipments; 
        //Конструктор класса
        public Classroom(string name, Employee Employee, int seatingCapacity, int windowCount)
        {
            this.name = name;
            this.employee = Employee;
            this.seatingCapacity = seatingCapacity;
            this.windowCount = windowCount;
            this.equipments = new List<Equipment>();
            
        }

        public string Name { get { return name; } }
        public Employee Employee { get { return employee; } }
        public int SeatingCapacity { get {  return seatingCapacity; } }
        public int WindowCount { get {  return windowCount; } }
        public List<Equipment> Equipments { get {  return equipments; } }

    }
}
